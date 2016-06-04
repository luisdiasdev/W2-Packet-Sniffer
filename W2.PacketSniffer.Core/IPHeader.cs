using System.Net;

namespace W2.PacketSniffer.Core
{
    public enum IPProtocol
    {
        ICMP = 1,
        IGMP = 2,
        TCP = 6,
        UDP = 17,
        Unknown = -1
    }

    public enum IPVersion
    {
        IPv4,
        IPv6,
        Unknown
    }

    public class IPHeader
    {
        public const int MinimumIPHeaderSize = 20;

        public IPVersion Version;
        public int Length;
        public byte TypeOfService;
        public ushort TotalLength;
        public ushort Id;
        public ushort FlagsAndOffset;
        public byte TTL;
        public IPProtocol Protocol;
        public ushort Checksum;
        public IPAddress SourceAddress;
        public IPAddress DestinationAddress;

        public int FragmentationOffset;
        public bool DontFragment;
        public bool MoreFragments;

        public unsafe static IPHeader ParseIPHeader(byte* buffer)
        {
            var header = new IPHeader();
            var ipVersionAndLength = buffer[0];
            header.TypeOfService = buffer[1];
            header.TotalLength = (ushort)IPAddress.NetworkToHostOrder(*(short*)&buffer[2]);
            header.Id = (ushort)IPAddress.NetworkToHostOrder(*(short*)&buffer[4]);
            header.FlagsAndOffset = (ushort)IPAddress.NetworkToHostOrder(*(short*)&buffer[6]);
            header.TTL = buffer[8];
            var protocol = buffer[9];
            header.Checksum = (ushort)IPAddress.NetworkToHostOrder(*(short*)&buffer[10]);
            var sourceAddress = *(uint*)&buffer[12];
            var destinationAddress = *(uint*)&buffer[16];

            header.SourceAddress = new IPAddress(sourceAddress);
            header.DestinationAddress = new IPAddress(destinationAddress);

            if (protocol == 6)
                header.Protocol = IPProtocol.TCP;
            else if (protocol == 17)
                header.Protocol= IPProtocol.UDP;
            else
                header.Protocol = IPProtocol.Unknown;

            if ((ipVersionAndLength >> 4) == 4)
                header.Version = IPVersion.IPv4;
            else if ((ipVersionAndLength >> 4) == 6)
                header.Version = IPVersion.IPv6;
            else
                header.Version = IPVersion.Unknown;

            // get the last 4 bits
            ipVersionAndLength <<= 4;
            ipVersionAndLength >>= 4;
            ipVersionAndLength *= 4;
            header.Length = ipVersionAndLength;

            int flags = header.FlagsAndOffset >> 13;
            header.DontFragment = (flags & 2) == 2;
            header.MoreFragments = (flags & 1) == 1;
            
            int offset = (header.FlagsAndOffset << 3);
            offset >>= 3;

            header.FragmentationOffset = offset;

            return header;
        }
    };
}
