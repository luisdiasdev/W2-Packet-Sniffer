using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using W2.PacketSniffer.Core;

namespace W2.PacketSniffer
{
    public partial class MainForm : Form
    {
        private W2NetworkSniffer m_sniffer;

        private IgnoredPackets m_ignoredPackets;

        public MainForm()
        {
            InitializeComponent();

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null,
                dgvPacketLog,
                new object[] { true });

            m_ignoredPackets = new IgnoredPackets();

            if(Properties.Settings.Default.UpgradeRequired)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeRequired = false;
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.IgnorePackets)
                m_ignoredPackets.LoadFromFile(Properties.Settings.Default.IgnoredPacketsFile);
        }

        private void Sniffer_PacketReceived(object sender, W2PacketEventArgs e)
        {
            if (toolsPauseLogging.Checked)
                return;

            if (m_ignoredPackets.ContainsOpCodeAndSize(e.PacketHeader.PacketId, e.PacketHeader.Size))
                return;

            if (dgvPacketLog.RowCount > 1000)
                dgvPacketLog.Rows.Clear();

            int currentRow = dgvPacketLog.Rows.Add(
                DateTime.Now,
                e.Direction.ToString(),
                e.IPHeader.SourceAddress,
                e.IPHeader.DestinationAddress,
                e.PacketHeader.Size,
                string.Format("0x{0:X2}", e.PacketHeader.PacketId),
                e.PacketHeader.ClientId);

            dgvPacketLog.Rows[currentRow].Tag = e;

            logPacket(e);
        }

        private void logPacket(W2PacketEventArgs packet)
        {
            bool autoSave = Properties.Settings.Default.AutoSavePackets;

            if(autoSave)
            {
                var directory = Properties.Settings.Default.SavePacketDirectory;
                if (string.IsNullOrEmpty(directory))
                    directory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                var logFilePath = directory + Path.DirectorySeparatorChar + "packetLog.txt";

                var binaryPacketFilePath = string.Format("{0}{1} - 0x{2} - {3}.bin",
                    directory,
                    packet.Direction.ToString(),
                    packet.PacketHeader.PacketId.ToString("X2"),
                    packet.PacketHeader.Size);

                using (var file = File.OpenWrite(binaryPacketFilePath))
                    file.Write(packet.Buffer, 0, packet.Buffer.Length);
                

                using (var logStream = new StreamWriter(File.Open(logFilePath, FileMode.Append)))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("--------------------------------------------\n")
                        .Append(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"))
                        .Append($"\n - Packet: Direction {packet.Direction}\n")
                        .Append($"From {packet.IPHeader.SourceAddress}:{packet.TCPHeader.SourcePort}  ")
                        .Append($"To {packet.IPHeader.DestinationAddress}:{packet.TCPHeader.DestinationPort}\n\n")
                        .Append($"Header: Size {packet.PacketHeader.Size} PacketId 0x{packet.PacketHeader.PacketId.ToString("X2")} ")
                        .Append($"ClientId {packet.PacketHeader.ClientId} TimeStamp {packet.PacketHeader.TimeStamp}\n\n");

                    logStream.Write(sb.ToString());
                }
            }
        }

        private void toolsStopLogging_Click(object sender, EventArgs e)
        {
            if (m_sniffer != null)
            {
                m_sniffer.Stop();
                m_sniffer.PacketReceived -= Sniffer_PacketReceived;
                toolsStartLogging.Enabled = true;
                toolsStopLogging.Enabled = false;
                toolsPauseLogging.Enabled = false;
                toolsClearView.Enabled = false;
                m_sniffer = null;
            }
        }

        private void toolsShowDetails_Click(object sender, EventArgs e)
        {
            if(dgvPacketLog.CurrentRow != null)
                ShowDetailsOfRow(dgvPacketLog.CurrentRow.Index);
        }

        private void toolsSavePacket_Click(object sender, EventArgs e)
        {
            if(dgvPacketLog.CurrentCell != null)
            {
                SavePacketToFile(dgvPacketLog.CurrentRow.Tag as W2PacketEventArgs);
            }
        }

        private void dgvPacketLog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                dgvPacketLog.CurrentCell = dgvPacketLog.Rows[e.RowIndex].Cells[0];
                ShowDetailsOfRow(e.RowIndex);
            }
        }

        DetailsForm detailForm;

        private void ShowDetailsOfRow(int rowId)
        {
            if(detailForm == null)
                detailForm = new DetailsForm();

            detailForm.InitializePacketDetails(dgvPacketLog.Rows[rowId].Tag as W2PacketEventArgs);
            detailForm.ShowDialog(this);
        }

        private async void toolsStartLogging_Click(object sender, EventArgs e)
        {
            if (m_sniffer == null)
            {
                StartForm form = new StartForm();
                DialogResult result = DialogResult.OK;
                do
                {
                    result = form.ShowDialog(this);
                    if (result != DialogResult.OK)
                        break;

                    m_sniffer = form.GetSniffer();
                    if (m_sniffer != null)
                        break;

                    var msgRes = MessageBox.Show(this, "Could not start sniffer.", "Error",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (msgRes != DialogResult.Retry)
                        break;

                    result = DialogResult.Cancel;


                } while (result != DialogResult.OK);
            }

            if (m_sniffer != null)
            {
                m_sniffer.PacketReceived += Sniffer_PacketReceived;
                toolsStartLogging.Enabled = false;
                toolsStopLogging.Enabled = true;
                toolsPauseLogging.Enabled = true;
                toolsClearView.Enabled = true;
                await m_sniffer.Start();
            }
        }

        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog(this);
        }

        private int m_currentRowId;

        private void dgvPacketLog_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvPacketLog.CurrentRow == null)
                return;

            m_currentRowId = dgvPacketLog.CurrentRow.Index;

            if (m_currentRowId >= 0)
                ChangePacketDetailsVisible(true);
            else
                ChangePacketDetailsVisible(false);

        }

        private void ChangePacketDetailsVisible(bool value)
        {
            toolsShowDetails.Enabled = value;
            toolsSavePacket.Enabled = value;
        }

        SaveFileDialog saveDialog;

        private void SavePacketToFile(W2PacketEventArgs packet)
        {
            if(saveDialog == null)
            {
                saveDialog = new SaveFileDialog();
                saveDialog.CheckPathExists = true;
                saveDialog.Filter = "Binary File|*.bin";
                saveDialog.Title = "Select where to save the packet binary data:";
                saveDialog.ValidateNames = true;
                saveDialog.AddExtension = true;
                saveDialog.DefaultExt = "bin";
            }
            var result = saveDialog.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                using (var fstream = saveDialog.OpenFile())
                using (var bw = new BinaryWriter(fstream))
                {
                    bw.Write(packet.Buffer);
                }
            }
        }

        private void menuOptionsSettings_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog(this);
        }

        private void toolsClearView_Click(object sender, EventArgs e)
        {
            dgvPacketLog.Rows.Clear();
        }

        IgnoredPacketsForm ignorePacketsForm;

        private void menuOptionsIgnoredPackets_Click(object sender, EventArgs e)
        {
            if (ignorePacketsForm == null)
                ignorePacketsForm = new IgnoredPacketsForm();

            ignorePacketsForm.SetIgnoredPackets(m_ignoredPackets);
            ignorePacketsForm.ShowDialog(this);
        }
    }
}
