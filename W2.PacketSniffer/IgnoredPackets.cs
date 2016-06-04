using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace W2.PacketSniffer
{
    /// <summary>
    /// Represents the packets that will be ignored by the logger.
    /// </summary>
    public class IgnoredPackets
    {
        private MultiValueDictionary<int, int> m_ignoredPackets;

        public IgnoredPackets()
        {
            m_ignoredPackets = new MultiValueDictionary<int, int>();
        }

        /// <summary>
        /// Adds a new entry to the list.
        /// </summary>
        /// <param name="opCode">The opcode of the packet.</param>
        /// <param name="size">The size of the packet, in bytes.</param>
        public void Add(int opCode, int size)
        {
            m_ignoredPackets.Add(opCode, size);
        }
        /// <summary>
        /// Removes an entry from the list.
        /// If after removing this entry, the opcode list is empty,
        /// the opcode is then removed from the list as well.
        /// </summary>
        /// <param name="opCode">The opcode of the packet.</param>
        /// <param name="size">The size of the packet, in bytes.</param>
        public void Remove(int opCode, int size)
        {
            m_ignoredPackets.Remove(opCode, size);

            if (m_ignoredPackets.ContainsKey(opCode))
            {
                if (m_ignoredPackets[opCode].Count <= 0)
                    m_ignoredPackets.Remove(opCode);
            }
        }

        /// <summary>
        /// Gets the number of ignored packets.
        /// </summary>
        public int Count => m_ignoredPackets.Count;

        /// <summary>
        /// Check if the list contains the given opcode.
        /// </summary>
        /// <param name="opCode">The opcode of the packet.</param>
        /// <returns>Returns true if the list contains the opcode, false otherwise.</returns>
        public bool ContainsOpCode(int opCode)
        {
            return m_ignoredPackets.ContainsKey(opCode);
        }

        /// <summary>
        /// Check if the list contains the opcode and the associated size.
        /// </summary>
        /// <param name="opCode">The opcode of the packet.</param>
        /// <param name="size">The size of the packet.</param>
        /// <returns>Returns true if the list contains both the opcode and size, false otherwise.</returns>
        public bool ContainsOpCodeAndSize(int opCode, int size)
        {
            return m_ignoredPackets.Contains(opCode, size);
        }

        /// <summary>
        /// Gets the ignored packets as formatted strings.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetFormatedValues()
        {
            foreach(var kvp in m_ignoredPackets)
            {
                foreach (var size in kvp.Value)
                    yield return string.Format("OpCode {0:X2} Size {1}", kvp.Key, size);
            }
        }

        /// <summary>
        /// Saves the current ignored packet list to a file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
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
        /// <summary>
        /// Loads the ignored packet list from a file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
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
