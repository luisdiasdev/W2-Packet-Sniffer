namespace W2.PacketSniffer
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lbl_InterfaceAddress;
            System.Windows.Forms.Label lbl_WatchOnAddress;
            System.Windows.Forms.Label label1;
            this.toolTipStartForm = new System.Windows.Forms.ToolTip(this.components);
            this.cmbInterfaceAddresses = new System.Windows.Forms.ComboBox();
            this.txtWatchOnAddress = new System.Windows.Forms.TextBox();
            this.numWatchOnPort = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkMonitorIP = new System.Windows.Forms.CheckBox();
            lbl_InterfaceAddress = new System.Windows.Forms.Label();
            lbl_WatchOnAddress = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numWatchOnPort)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_InterfaceAddress
            // 
            lbl_InterfaceAddress.AutoSize = true;
            lbl_InterfaceAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            lbl_InterfaceAddress.ForeColor = System.Drawing.Color.White;
            lbl_InterfaceAddress.Location = new System.Drawing.Point(9, 12);
            lbl_InterfaceAddress.Name = "lbl_InterfaceAddress";
            lbl_InterfaceAddress.Size = new System.Drawing.Size(183, 13);
            lbl_InterfaceAddress.TabIndex = 4;
            lbl_InterfaceAddress.Text = "Select the network interface address:";
            lbl_InterfaceAddress.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_WatchOnAddress
            // 
            lbl_WatchOnAddress.AutoSize = true;
            lbl_WatchOnAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            lbl_WatchOnAddress.ForeColor = System.Drawing.Color.White;
            lbl_WatchOnAddress.Location = new System.Drawing.Point(9, 52);
            lbl_WatchOnAddress.Name = "lbl_WatchOnAddress";
            lbl_WatchOnAddress.Size = new System.Drawing.Size(155, 13);
            lbl_WatchOnAddress.TabIndex = 5;
            lbl_WatchOnAddress.Text = "Enter the IP address to monitor:";
            lbl_WatchOnAddress.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(9, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 13);
            label1.TabIndex = 6;
            label1.Text = "Enter the Port to monitor:";
            label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbInterfaceAddresses
            // 
            this.cmbInterfaceAddresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterfaceAddresses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInterfaceAddresses.FormattingEnabled = true;
            this.cmbInterfaceAddresses.Location = new System.Drawing.Point(12, 28);
            this.cmbInterfaceAddresses.Name = "cmbInterfaceAddresses";
            this.cmbInterfaceAddresses.Size = new System.Drawing.Size(169, 21);
            this.cmbInterfaceAddresses.TabIndex = 0;
            this.toolTipStartForm.SetToolTip(this.cmbInterfaceAddresses, "Select an address from the available\r\ninterfaces list.\r\n\r\nIf you want to capture " +
        "packets from local network\r\nyou should select your local network interface\r\naddr" +
        "ess.\r\n");
            // 
            // txtWatchOnAddress
            // 
            this.txtWatchOnAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWatchOnAddress.Enabled = false;
            this.txtWatchOnAddress.Location = new System.Drawing.Point(12, 68);
            this.txtWatchOnAddress.Name = "txtWatchOnAddress";
            this.txtWatchOnAddress.Size = new System.Drawing.Size(169, 20);
            this.txtWatchOnAddress.TabIndex = 1;
            this.toolTipStartForm.SetToolTip(this.txtWatchOnAddress, "Represents the IP address you want to intercept the\r\npackets.\r\n\r\nWill capture all" +
        " of the packets being sent or received\r\nby this IP address.\r\n\r\n*IPV4 address for" +
        "mat only.");
            this.txtWatchOnAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtWatchOnAddress_Validating);
            // 
            // numWatchOnPort
            // 
            this.numWatchOnPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numWatchOnPort.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::W2.PacketSniffer.Properties.Settings.Default, "DefaultPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWatchOnPort.Location = new System.Drawing.Point(12, 107);
            this.numWatchOnPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numWatchOnPort.Name = "numWatchOnPort";
            this.numWatchOnPort.Size = new System.Drawing.Size(120, 20);
            this.numWatchOnPort.TabIndex = 2;
            this.toolTipStartForm.SetToolTip(this.numWatchOnPort, "Represents the port which the messages will be\r\ncaptured.\r\n\r\nMust be a valid port" +
        " (non system port).");
            this.numWatchOnPort.Value = global::W2.PacketSniffer.Properties.Settings.Default.DefaultPort;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGray;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(116, 133);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(197, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // checkMonitorIP
            // 
            this.checkMonitorIP.AutoSize = true;
            this.checkMonitorIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkMonitorIP.ForeColor = System.Drawing.Color.White;
            this.checkMonitorIP.Location = new System.Drawing.Point(188, 71);
            this.checkMonitorIP.Name = "checkMonitorIP";
            this.checkMonitorIP.Size = new System.Drawing.Size(71, 17);
            this.checkMonitorIP.TabIndex = 9;
            this.checkMonitorIP.Text = "Monitor IP";
            this.checkMonitorIP.UseVisualStyleBackColor = true;
            this.checkMonitorIP.CheckedChanged += new System.EventHandler(this.checkMonitorIP_CheckedChanged);
            // 
            // StartForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(280, 165);
            this.ControlBox = false;
            this.Controls.Add(this.checkMonitorIP);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(label1);
            this.Controls.Add(lbl_WatchOnAddress);
            this.Controls.Add(lbl_InterfaceAddress);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numWatchOnPort);
            this.Controls.Add(this.txtWatchOnAddress);
            this.Controls.Add(this.cmbInterfaceAddresses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Start Sniffer Settings";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWatchOnPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipStartForm;
        private System.Windows.Forms.ComboBox cmbInterfaceAddresses;
        private System.Windows.Forms.TextBox txtWatchOnAddress;
        private System.Windows.Forms.NumericUpDown numWatchOnPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkMonitorIP;
    }
}