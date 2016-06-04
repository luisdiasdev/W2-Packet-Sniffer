namespace W2.PacketSniffer.Core
{
    public class PacketHeader
    {
        public ushort Size;
        public byte Key;
        public byte Checksum;
        public ushort PacketId;
        public ushort ClientId;
        public uint TimeStamp;

        public static unsafe PacketHeader Parse(byte* pBuffer, int offset = 0)
        {
            var header = new PacketHeader();

            header.Size = *(ushort*)&pBuffer[0];
            header.Key = pBuffer[2];
            header.Checksum = pBuffer[3];
            header.PacketId = *(ushort*)&pBuffer[4];
            header.ClientId = *(ushort*)&pBuffer[6];
            header.TimeStamp = *(uint*)&pBuffer[8];

            return header;
        }
    }
}
