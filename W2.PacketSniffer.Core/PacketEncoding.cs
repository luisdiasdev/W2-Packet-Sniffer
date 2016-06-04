using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2.PacketSniffer.Security
{
    public abstract class PacketEncoding : IPacketEncoding
    {
        protected byte[] m_keys;

        public byte[] Keys => m_keys;

        public abstract int MaximumVersion { get; }

        public abstract int MinimumVersion { get; }

        protected PacketEncoding()
        {
        }

        public abstract bool Decrypt(byte[] buffer, int offset, int length);
    }
}
