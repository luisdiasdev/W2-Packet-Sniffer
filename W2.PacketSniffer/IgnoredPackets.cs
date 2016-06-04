using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace W2.PacketSniffer
{
    public class IgnoredPackets
    {
        private MultiValueDictionary<int, int> m_ignoredPackets;

        public IgnoredPackets()
        {
            m_ignoredPackets = new MultiValueDictionary<int, int>();
        }

        public void Add(int opCode, int size)
        {
            m_ignoredPackets.Add(opCode, size);
        }
        public void Remove(int opCode, int size)
        {
            m_ignoredPackets.Remove(opCode, size);

            if (m_ignoredPackets.ContainsKey(opCode))
            {
                if (m_ignoredPackets[opCode].Count <= 0)
                    m_ignoredPackets.Remove(opCode);
            }
        }

        public int Count => m_ignoredPackets.Count;

        public bool ContainsOpCode(int opCode)
        {
            return m_ignoredPackets.ContainsKey(opCode);
        }

        public bool ContainsOpCodeAndSize(int opCode, int size)
        {
            return m_ignoredPackets.Contains(opCode, size);
        }

        public IEnumerable<string> GetFormatedValues()
        {
            foreach(var kvp in m_ignoredPackets)
            {
                foreach (var size in kvp.Value)
                    yield return string.Format("OpCode {0:X2} Size {1}", kvp.Key, size);
            }
        }
        public void SaveToFile(string filePath)
        {
            using (var sw = new StreamWriter(filePath, false))
            {
                sw.WriteLine("# Use the 'hashtag' character to mark a comment.");
                sw.WriteLine("# To add a packet to the ignore list, just");
                sw.WriteLine("# Write the packet opcode, follwed by a comma and the size.");
                sw.WriteLine("# For example: 20D,116 ");
                sw.WriteLine("# Will ignore the packet 0x20D, if it has the size 116\n\n");
                sw.WriteLine("# Ignored Packets:");

                foreach (var kvp in m_ignoredPackets)
                {
                    foreach (var size in kvp.Value)
                        sw.WriteLine("{0:X2},{1}", kvp.Key, size);
                }
            }
        }
        public void LoadFromFile(string filePath)
        {
            using (var tr = new StreamReader(filePath))
            {
                string line = null;

                while ((line = tr.ReadLine()) != null)
                {
                    if (line.Length <= 1 || line.Substring(0, 1).Equals("#"))
                        continue;

                    var split = line.Split(',');

                    ushort packetId = 0, size = 0;

                    if (!ushort.TryParse(split[0], NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture,
                        out packetId))
                        continue;

                    if (!ushort.TryParse(split[1], out size))
                        continue;

                    m_ignoredPackets.Add(packetId, size);
                }
            }
        }
    }
}
