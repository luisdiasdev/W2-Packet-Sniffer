using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using NetFwTypeLib;

namespace W2.PacketSniffer.Core
{
    /// <summary>
    /// A generic network sniffer.
    /// Receives messages from a given network interface address & port.
    /// </summary>
    public abstract class NetworkSniffer : IDisposable
    {
        /// <summary>
        /// The size of our internal buffer.
        /// </summary>
        protected const int BufferSize = 16 * 1024;

        private CancellationTokenSource m_cts;
        private Socket m_rawSocket;
        protected bool m_filterAddress;
        protected IPAddress m_address;
        protected IPAddress m_interfaceAddress;
        protected int m_port;
        protected byte[] m_buffer;
        
        /// <summary>
        /// Creates a new <c>NetworkSniffer</c> instance that will receive all packets from
        /// <paramref name="interfaceAddress"/> and discards all messages that are not from/to
        /// the specified <paramref name="address"/> : <paramref name="port"/> combination.
        /// </summary>
        /// <param name="interfaceAddress">The interface address to bind on.</param>
        /// <param name="address">The network address to filter.</param>
        /// <param name="port">The port to filter.</param>
        public NetworkSniffer(IPAddress interfaceAddress, IPAddress address, int port)
            : this(interfaceAddress, address, port, true)
        {
        }

        /// <summary>
        /// Creates a new <c>NetworkSniffer</c> instance that will receive all packets from
        /// <paramref name="interfaceAddress"/> and discards all messages that are not from/to
        /// the specified <paramref name="port"/>.
        /// </summary>
        /// <param name="interfaceAddress">The interface address to bind on.</param>
        /// <param name="address">The network address to filter.</param>
        /// <param name="port">The port to filter.</param>
        public NetworkSniffer(IPAddress interfaceAddress, int port)
            : this(interfaceAddress, IPAddress.Any, port, false)
        {
        }

        protected NetworkSniffer(IPAddress interfaceAddress, IPAddress address, int port, bool filterAddress)
        {
            m_buffer = new byte[BufferSize];
            m_cts = new CancellationTokenSource();
            m_address = address;
            m_interfaceAddress = interfaceAddress;
            m_port = port;
            m_filterAddress = filterAddress;
        }

        /// <summary>
        /// Starts the sniffer asynchronously. 
        /// </summary>
        /// <returns></returns>
        public async Task Start()
        {
            try
            {
                // Adds our program to the firewall, so we can receive incoming packets.
                SetFirewallRule(true);

                // Creates our raw socket
                m_rawSocket = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP);
                // Bind it to the interface address.
                m_rawSocket.Bind(new IPEndPoint(m_interfaceAddress, 0));
                
                m_rawSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, true);

                byte[] optionIn = new byte[4] { 1, 0, 0, 0 };
                byte[] optionOut = new byte[4] { 0, 0, 0, 0 };

                m_rawSocket.IOControl(IOControlCode.ReceiveAll, optionIn, optionOut);

                await WaitForMessages(m_cts.Token);
            }
            catch(SocketException ex)
            {
                // TODO: Handle exceptions
            }
            catch(Exception)
            {
                // TODO: Handle exceptions
            }
        }

        /// <summary>
        /// Stops the sniffer.
        /// </summary>
        public void Stop() => m_cts.Cancel();

        private void SetFirewallRule(bool enabled)
        {
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(
                    Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

            if (!enabled)
                fwPolicy2.Rules.Remove("W2 Packet Sniffer");
            else
            {
                // Let's create a new rule
                INetFwRule2 rule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));

                rule.Name = "W2 Packet Sniffer";
                rule.Description = "W2 Packet Sniffer - Allow network traffic";
                rule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP; //TCP
                rule.LocalPorts = m_port.ToString();
                rule.InterfaceTypes = "All";
                rule.Enabled = true;
                rule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                rule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
                rule.Profiles = fwPolicy2.CurrentProfileTypes;

                fwPolicy2.Rules.Add(rule);
            }
        }

        private async Task WaitForMessages(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                if (m_rawSocket != null)
                {
                    var numReceived =
                        await m_rawSocket.ReceiveTaskAsync(m_buffer, 0, m_buffer.Length, SocketFlags.None);

                    OnMessageReceived(numReceived);
                }
            }

            m_rawSocket.Close();
        }
                        
        private unsafe void OnMessageReceived(int receivedLength)
        {
            if (receivedLength < (IPHeader.MinimumIPHeaderSize + TCPHeader.MinimumTCPHeaderSize))
                return;

            fixed (byte* pBuffer = m_buffer)
            {
                var ipHeader = IPHeader.ParseIPHeader(pBuffer);

                if (ipHeader.Protocol != IPProtocol.TCP)
                    return; 

                if(m_filterAddress)
                {
                    if (ipHeader.DestinationAddress != m_address
                        || ipHeader.SourceAddress != m_address)
                        return;
                }

                var tcpHeader = TCPHeader.ParseTCPHeader(&pBuffer[ipHeader.Length]);

                if (tcpHeader.SourcePort == m_port || tcpHeader.DestinationPort == m_port)
                {
                    var offset = ipHeader.Length + tcpHeader.Length;

                    var length = receivedLength - offset;

                    ProcessReceivedMessage(ipHeader, tcpHeader, pBuffer, offset, length);                   
                }
            }
        }

        protected abstract unsafe void ProcessReceivedMessage(
            IPHeader ipHeader, TCPHeader tcpHeader, byte* data, int dataOffset, int dataLength);

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing) // Dispose managed resources
                {
                    // Remove firewall rule
                    SetFirewallRule(false);
                    // Stops the receive loop.
                    m_cts.Cancel();
                    // Close the raw socket.
                    m_rawSocket.Close();
                    // Dispose the CancellationTokenSource
                    m_cts.Dispose();
                    m_cts = null;
                    m_rawSocket = null;
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
