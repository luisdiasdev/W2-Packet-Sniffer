using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;

namespace W2.PacketSniffer.Core
{
    /// <summary>
    /// Indicates the direction of the packet.
    /// </summary>
    public enum PacketDirection
    {
        Unknown,
        Incoming,
        Outgoing
    }

    /// <summary>
    /// Used by <c>W2NetworkSniffer</c> to raise events of
    /// received packets.
    /// </summary>
    public class W2PacketEventArgs : EventArgs
    {
        public PacketDirection Direction { get; private set; }

        public PacketHeader PacketHeader { get; private set; }

        public IPHeader IPHeader { get; private set; }

        public TCPHeader TCPHeader { get; private set; }

        public byte[] Buffer { get; private set; }

        public W2PacketEventArgs(PacketHeader packetHeader, PacketDirection direction, IPHeader ipHeader, 
            TCPHeader tcpHeader, byte[] buffer)
        {
            PacketHeader = packetHeader;
            Direction = direction;
            IPHeader = ipHeader;
            TCPHeader = tcpHeader;
            Buffer = buffer;
        }
    }

    /// <summary>
    /// Represents a <c>NetworkSniffer</c>
    /// that filters and decrypts all network packets used by W2 protocol.
    /// </summary>
    public class W2NetworkSniffer : NetworkSniffer
    {
        /// <summary>
        /// Event that will be invoked when a packet is received.
        /// </summary>
        public event EventHandler<W2PacketEventArgs> PacketReceived;

        private Dictionary<IPAddress, SortedList<int, byte[]>> m_fragmentedBuffers;
        private bool m_isFragmenting = false;
        private int m_fragmentHeaderSize;
        private int m_totalFragmentsSize;
        private int m_firstFragmentSize;

        public W2NetworkSniffer(IPAddress interfaceAddress, IPAddress address, 
            int port)
            : base(interfaceAddress, address, port)
        {
            m_fragmentedBuffers = new Dictionary<IPAddress, SortedList<int, byte[]>>();
            m_fragmentHeaderSize = 0;
            m_totalFragmentsSize = 0;
        }

        public W2NetworkSniffer(IPAddress interfaceAddress, int port)
            : base(interfaceAddress, port)
        {
            m_fragmentedBuffers = new Dictionary<IPAddress, SortedList<int, byte[]>>();
            m_fragmentHeaderSize = 0;
            m_totalFragmentsSize = 0;
        }

        private PacketDirection GetDirection(IPHeader ipHeader, TCPHeader tcpHeader)
        {
            if (m_filterAddress)
            {
                if (ipHeader.DestinationAddress.Equals(m_address) && tcpHeader.DestinationPort == m_port)
                    return PacketDirection.Outgoing;
                else if (ipHeader.SourceAddress.Equals(m_address) && tcpHeader.SourcePort == m_port)
                    return PacketDirection.Incoming;
            }
            else
            {
                if (tcpHeader.DestinationPort == m_port)
                    return PacketDirection.Outgoing;
                else if (tcpHeader.SourcePort == m_port)
                    return PacketDirection.Incoming;
            }
            return PacketDirection.Unknown;
        }

        private IPAddress GetAddress(PacketDirection direction, IPHeader ipHeader)
        {
            IPAddress address;

            if (direction == PacketDirection.Incoming)
                address = ipHeader.SourceAddress;
            else if (direction == PacketDirection.Outgoing)
                address = ipHeader.DestinationAddress;
            else
                address = IPAddress.Any;

            return address;
        }

        #region TODO: Make fragmented packets work right!
        private void AddFragment(IPAddress address, int id, int offset, int length)
        {
            if (!m_fragmentedBuffers.ContainsKey(address))
                m_fragmentedBuffers.Add(address, new SortedList<int, byte[]>());

            m_fragmentedBuffers[address].Add(id, new byte[length]);

            W2MarshalHelper.BufferCopy(m_buffer, offset, m_fragmentedBuffers[address][id], 0, length);

            m_totalFragmentsSize += length;
        }

        private void ClearFragments(IPAddress address)
        {
            if (!m_fragmentedBuffers.ContainsKey(address))
                return;

            m_fragmentedBuffers[address].Clear();
        }
        private byte[] ConsolidateFragments(IPAddress address)
        {
            if (!m_fragmentedBuffers.ContainsKey(address))
                return null;

            // Sort based on ipheader id
            m_fragmentedBuffers[address].OrderBy(kvp => kvp.Key);

            // Gets the length of all the fragments together
            var totalLength = m_fragmentedBuffers[address].Sum(kvp => kvp.Value.Length);
            var buffer = new byte[totalLength];
            var currentOffset = 0;

            foreach (var kvp in m_fragmentedBuffers[address])
            {
                W2MarshalHelper.BufferCopy(kvp.Value, 0, buffer, currentOffset, kvp.Value.Length);
                currentOffset += kvp.Value.Length;
            }

            return buffer;
        }

        private const int PacketHeaderSize = 12;

        private const int MaxFragments = 100;

        private const int MaxPacketSize = 5000;

        protected unsafe override void ProcessReceivedMessage(
            IPHeader ipHeader, TCPHeader tcpHeader, byte* data, int dataOffset, int dataLength)
        {
            // OK, get the packet direction.
            var direction = GetDirection(ipHeader, tcpHeader);

            // OK, get the right address according to the direction.
            var address = GetAddress(direction, ipHeader);

            // Start the fight!
            if (dataLength <= 0)
                return;
            else if (dataLength == 4) // Hand-shake packet.
            {
                var helloPacket = *(uint*)&data[dataOffset];
                if (helloPacket == 0x1F11F311)
                    return;
            }
            else if (dataLength < PacketHeaderSize) // Not a valid 12-byte header.
                return;
            else // Data >= sizeof(PacketHeader)
            {
                if (m_isFragmenting) // Is a fragment
                {
                    // If the received length is less than the first fragment length
                    // and the total fragments can carry at least 1 full header specified message
                    if (dataLength < m_firstFragmentSize && 
                        (m_totalFragmentsSize + dataLength) >= m_fragmentHeaderSize)
                    { // Add the last fragment to the list
                        AddFragment(address, ipHeader.Id, dataOffset, dataLength);
                        // Consolidate the message into a single buffer.
                        var msgBuffer = ConsolidateFragments(address);

                        if (msgBuffer == null)
                            return;

                        var remaining = msgBuffer.Length;
                        var currentOffset = 0;

                        fixed (byte* pMsgBuffer = msgBuffer)
                        {   // We need a do-while loop, because we may get two messages
                            // glued together by tcp-fragmentation.
                            do
                            {
                                var pSize = *(ushort*)&pMsgBuffer[currentOffset];

                                W2PacketSecurity.Decrypt(pMsgBuffer, pSize, currentOffset);

                                var pHeader = PacketHeader.Parse(&pMsgBuffer[currentOffset]);

                                remaining -= pSize;

                                // Creates a new buffer, with only the current packet.
                                // This ensures that we will not use the same underlyng buffer
                                // because this buffer will be stored by the forms...
                                byte[] packetBuffer = new byte[pSize];

                                W2MarshalHelper.BufferCopy(msgBuffer, currentOffset, packetBuffer, 0, pSize);

                                PacketReceived.Raise(this, new W2PacketEventArgs(pHeader, direction, ipHeader, 
                                    tcpHeader, packetBuffer));

                                currentOffset += pSize;

                            } while (remaining >= PacketHeaderSize);
                        }
                        m_isFragmenting = false;
                        m_fragmentHeaderSize = 0;
                        m_totalFragmentsSize = 0;
                        m_fragmentedBuffers[address].Clear();
                        return;
                    }
                    else
                    {
                        AddFragment(address, ipHeader.Id, dataOffset, dataLength);
                        return;
                    }
                }
                // Gets the first ushort, which is supposed to carry the size of the packet.
                var headerSize = *(ushort*)&data[dataOffset];
                // Not a valid packet size.
                if (headerSize < PacketHeaderSize || headerSize > MaxPacketSize)
                    return;

                if (headerSize > dataLength) // The packet will be fragmented.
                {
                    AddFragment(address, ipHeader.Id, dataOffset, dataLength);
                    m_isFragmenting = true;
                    m_firstFragmentSize = dataLength;
                    m_fragmentHeaderSize = headerSize;
                    return;
                }
                else // No Fragmentation...
                {
                    var remaining = dataLength;
                    var currentOffset = dataOffset;

                    do
                    {
                        var pSize = *(ushort*)&data[currentOffset];

                        W2PacketSecurity.Decrypt(data, pSize, currentOffset);

                        var pHeader = PacketHeader.Parse(&data[currentOffset]);

                        remaining -= pSize;

                        // Creates a temp. buffer for the handler.
                        byte[] packetBuffer = new byte[pSize];

                        W2MarshalHelper.BufferCopy(m_buffer, currentOffset, packetBuffer, 0, pSize);

                        PacketReceived.Raise(this, new W2PacketEventArgs(pHeader, direction, ipHeader, tcpHeader, 
                            packetBuffer));

                        currentOffset += pSize;

                    } while (remaining >= PacketHeaderSize);
                }
            }
        }
            
        }
        #endregion
}
