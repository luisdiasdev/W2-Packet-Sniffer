using System;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using W2.PacketSniffer.Core;

namespace W2.PacketSniffer
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            txtWatchOnAddress.Text = "127.0.0.1";
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            FillInterfaceAddresses();
        }

        private void FillInterfaceAddresses()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if ((nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                   || (nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                   || (nic.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                   && (nic.OperationalStatus == OperationalStatus.Up))
                {
                    foreach (var ip in nic.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            cmbInterfaceAddresses.Items.Add(ip.Address.ToString());
                    }
                }
            }
        }

        private void txtWatchOnAddress_Validating(object sender, CancelEventArgs e)
        {
            if (!AddressValidator.Validate(txtWatchOnAddress.Text))
            {
                txtWatchOnAddress.Text = "";
                e.Cancel = true;
                toolTipStartForm.Show("The value is not a valid IPV4 address.", txtWatchOnAddress, 1500);
            }
        }

        /// <summary>
        /// Gets a <code>W2NetworkSniffer</code> from the
        /// startup information.
        /// </summary>
        /// <returns>A valid <c>W2NetworkSniffer</c> object.</returns>
        public W2NetworkSniffer GetSniffer()
        {
            if (cmbInterfaceAddresses.SelectedIndex == -1)
                return null;

            IPAddress bindOnAddress;
            if (!IPAddress.TryParse(cmbInterfaceAddresses.SelectedItem.ToString(), out bindOnAddress))
                return null;

            bool useWatchAddress = false;

            if (txtWatchOnAddress.Enabled)
                useWatchAddress = true;

            IPAddress watchOnAddress;

            int port = (int)numWatchOnPort.Value;

            if (useWatchAddress)
            {
                if (!IPAddress.TryParse(txtWatchOnAddress.Text, out watchOnAddress))
                    return null;

                return
                    new W2NetworkSniffer(bindOnAddress, watchOnAddress, port);
            }

            return
                new W2NetworkSniffer(bindOnAddress, port);
        }

        private void checkMonitorIP_CheckedChanged(object sender, EventArgs e)
        {
            bool enable = checkMonitorIP.Checked ? true : false;

            txtWatchOnAddress.Enabled = enable;
        }
    }
}
