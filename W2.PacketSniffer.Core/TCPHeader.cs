using System;
using System.Net;

namespace W2.PacketSniffer.Core
{
    /// <summary>
    /// Enumerates the possible TCP Header Flags
    /// </summary>
    [Flags]
    public enum TCPFlags
    {
        FIN = 0x1,
        SYN = 0x2,
        RST = 0x4,
        PSH = 0x8,
        ACK = 0x10,
        URG = 0x20,
    }

    /// <summary>
    /// Represents the TCP header.
    /// </summary>
    public class TCPHeader
    {
        public const int MinimumTCPHeaderSize = 20;

        public int Length;
        public TCPFlags Flags;
        public ushort SourcePort;
        public ushort DestinationPort;
        public uint SequenceNumber;
        public uint AcknowledgmentNumber;
        public ushort DataOffsetAndFlags;
        public ushort Window;
        public ushort Checksum;
        public ushort UrgentPointer;

        /// <summary>
        /// Parses a buffer containing the TCP Header data.
        /// </summary>
        /// <param name="buffer">The unsafe pointer to the first element of the buffer.</param>
        /// <returns>A new TCPHeader object.</returns>
        public static unsafe TCPHeader ParseTCPHeader(byte* buffer)
        {
            var tcpHeader = new TCPHeader();

            tcpHeader.SourcePort = (ushort)IPAddress.NetworkToHostOrder(*(short*)&buffer[0]);
            tcpHeader.DestinationPort = (ushort)IPAddress.NetworkToHostOrder(*(short*)&buffer[2]);
            tcpHeader.SequenceNumber = (uint)IPAddress.NetworkToHostOrder(*(int*)&buffer[4]);
            tcpHeader.AcknowledgmentNumber = (uint)IPAddress.NetworkToHostOrder(*(int*)&buffer[8]);
            var dataOffsetAndFlags = (ushort)IPAddress.NetworkToHostOrder(*(short*)&buffer[12]);
            tcpHeader.Window = (ushort)IPAddress.NetworkToHostOrder(*(short*)&buffer[14]);
            tcpHeader.Checksum = (ushort)IPAddress.NetworkToHostOrder(*(short*)&buffer[16]);
            tcpHeader.UrgentPointer = (ushort)IPAddress.NetworkToHostOrder(*(short*)&buffer[18]);

            tcpHeader.Length = ((dataOffsetAndFlags >> 12) * 4);

            var flags = dataOffsetAndFlags & 0x3F;

            if ((flags & 0x01) != 0)
                tcpHeader.Flags |= TCPFlags.FIN;
            if ((flags & 0x02) != 0)
                tcpHeader.Flags |= TCPFlags.SYN;
            if ((flags & 0x04) != 0)
                tcpHeader.Flags |= TCPFlags.RST;
            if ((flags & 0x08) != 0)
                tcpHeader.Flags |= TCPFlags.PSH;
            if ((flags & 0x10) != 0)
                tcpHeader.Flags |= TCPFlags.ACK;
            if ((flags & 0x20) != 0)
                tcpHeader.Flags |= TCPFlags.URG;

            return tcpHeader;
        }
    };
}
