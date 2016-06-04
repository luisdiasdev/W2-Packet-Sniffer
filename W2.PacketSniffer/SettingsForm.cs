using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W2.PacketSniffer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        private FolderBrowserDialog folderDialog;

        private void btnSearchFolder_Click(object sender, EventArgs e)
        {
            if (folderDialog == null)
            {
                folderDialog = new FolderBrowserDialog();
                folderDialog.ShowNewFolderButton = true;
            }

            var result = folderDialog.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                if (!folderDialog.SelectedPath.EndsWith(Path.DirectorySeparatorChar.ToString()))
                    folderDialog.SelectedPath += Path.DirectorySeparatorChar;

                txtSavePacketDirectory.Text = folderDialog.SelectedPath;
                Properties.Settings.Default.SavePacketDirectory = folderDialog.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private OpenFileDialog fileDialog;

        private void btnSearchPacketFilterFile_Click(object sender, EventArgs e)
        {
            if (fileDialog == null)
            {
                fileDialog = new OpenFileDialog();
                fileDialog.CheckPathExists = true;
                fileDialog.DefaultExt = "txt";
                fileDialog.FileName = "IgnoredPackets";
                fileDialog.Filter = "Text File| *.txt";
                fileDialog.Multiselect = false;
                fileDialog.Title = "Select the Ignored Packets File:";
            }

            var result = fileDialog.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                Properties.Settings.Default.IgnoredPacketsFile = fileDialog.FileName;
                Properties.Settings.Default.Save();
            }
        }
    }
}
