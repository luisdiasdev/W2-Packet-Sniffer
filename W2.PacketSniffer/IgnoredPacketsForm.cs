using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace W2.PacketSniffer
{
    public partial class IgnoredPacketsForm : Form
    {
        private IgnoredPackets m_ignoredPackets;

        public IgnoredPacketsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the current ignored packet list.
        /// </summary>
        /// <param name="ignoredPackets">The ignored packets object.</param>
        public void SetIgnoredPackets(IgnoredPackets ignoredPackets)
        {
            m_ignoredPackets = ignoredPackets;
        }

        private void SaveIgnoredPacketList()
        {
            var enableIgnorePackets = Properties.Settings.Default.IgnorePackets;
            if (enableIgnorePackets)
                m_ignoredPackets.SaveToFile(Properties.Settings.Default.IgnoredPacketsFile);
        }

        private void IgnoredPacketsForm_Shown(object sender, EventArgs e)
        {
            var enableIgnorePackets = Properties.Settings.Default.IgnorePackets;
            if (enableIgnorePackets)
            {
                if (m_ignoredPackets.Count > 0)
                    listIgnoredPackets.Items.AddRange(m_ignoredPackets.GetFormatedValues().ToArray());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var opCode = (ushort)numOpCode.Value;
            var size = (ushort)numPacketSize.Value;

            if (m_ignoredPackets.ContainsOpCodeAndSize(opCode, size))
                return;

            m_ignoredPackets.Add(opCode, size);

            string fmt = "OpCode {0:X2} Size {1}";
            listIgnoredPackets.Items.Add(string.Format(fmt, opCode, size));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listIgnoredPackets.SelectedItem != null)
            {
                string str = listIgnoredPackets.SelectedItem.ToString();

                var split = str.Split(' ');

                if (split.Length != 4)
                    return;

                var opCodeStr = split[1];
                var sizeStr = split[3];

                ushort opCode = 0, size = 0;

                if (ushort.TryParse(opCodeStr, NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture,
                    out opCode))
                {
                    if (ushort.TryParse(sizeStr, out size))
                    {
                        if (m_ignoredPackets.ContainsOpCode(opCode))
                            m_ignoredPackets.Remove(opCode, size);
                    }
                }
                listIgnoredPackets.Items.RemoveAt(listIgnoredPackets.SelectedIndex);
                return;
            }
        }

        private void IgnoredPacketsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveIgnoredPacketList();
            listIgnoredPackets.Items.Clear();
        }
    }
}
