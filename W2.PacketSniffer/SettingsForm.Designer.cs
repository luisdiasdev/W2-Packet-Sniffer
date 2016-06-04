namespace W2.PacketSniffer
{
    partial class SettingsForm
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
            System.Windows.Forms.GroupBox groupPacketLogging;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.GroupBox groupNetwork;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label lblIgnoredPacketFile;
            this.btnSearchFolder = new System.Windows.Forms.Button();
            this.txtSavePacketDirectory = new System.Windows.Forms.TextBox();
            this.checkAutoSavePackets = new System.Windows.Forms.CheckBox();
            this.numDefaultPort = new System.Windows.Forms.NumericUpDown();
            this.btnSearchPacketFilterFile = new System.Windows.Forms.Button();
            this.txtIgnoredPacketsFile = new System.Windows.Forms.TextBox();
            this.checkEnableIgnoredPackets = new System.Windows.Forms.CheckBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabMainSettings = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            groupPacketLogging = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            groupNetwork = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblIgnoredPacketFile = new System.Windows.Forms.Label();
            groupPacketLogging.SuspendLayout();
            groupNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDefaultPort)).BeginInit();
            groupBox1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabMainSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPacketLogging
            // 
            groupPacketLogging.Controls.Add(this.btnSearchFolder);
            groupPacketLogging.Controls.Add(label1);
            groupPacketLogging.Controls.Add(this.txtSavePacketDirectory);
            groupPacketLogging.Controls.Add(this.checkAutoSavePackets);
            groupPacketLogging.Location = new System.Drawing.Point(6, 6);
            groupPacketLogging.Name = "groupPacketLogging";
            groupPacketLogging.Size = new System.Drawing.Size(364, 78);
            groupPacketLogging.TabIndex = 3;
            groupPacketLogging.TabStop = false;
            groupPacketLogging.Text = "Packet Logging";
            // 
            // btnSearchFolder
            // 
            this.btnSearchFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchFolder.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::W2.PacketSniffer.Properties.Settings.Default, "AutoSavePackets", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSearchFolder.Enabled = global::W2.PacketSniffer.Properties.Settings.Default.AutoSavePackets;
            this.btnSearchFolder.ForeColor = System.Drawing.Color.Black;
            this.btnSearchFolder.Location = new System.Drawing.Point(332, 43);
            this.btnSearchFolder.Name = "btnSearchFolder";
            this.btnSearchFolder.Size = new System.Drawing.Size(26, 23);
            this.btnSearchFolder.TabIndex = 4;
            this.btnSearchFolder.Text = "...";
            this.btnSearchFolder.UseVisualStyleBackColor = false;
            this.btnSearchFolder.Click += new System.EventHandler(this.btnSearchFolder_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(3, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 13);
            label1.TabIndex = 3;
            label1.Text = "Saved Packet Directory:";
            // 
            // txtSavePacketDirectory
            // 
            this.txtSavePacketDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::W2.PacketSniffer.Properties.Settings.Default, "SavePacketDirectory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSavePacketDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::W2.PacketSniffer.Properties.Settings.Default, "AutoSavePackets", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSavePacketDirectory.Enabled = global::W2.PacketSniffer.Properties.Settings.Default.AutoSavePackets;
            this.txtSavePacketDirectory.Location = new System.Drawing.Point(132, 45);
            this.txtSavePacketDirectory.Name = "txtSavePacketDirectory";
            this.txtSavePacketDirectory.Size = new System.Drawing.Size(194, 20);
            this.txtSavePacketDirectory.TabIndex = 2;
            this.txtSavePacketDirectory.Text = global::W2.PacketSniffer.Properties.Settings.Default.SavePacketDirectory;
            // 
            // checkAutoSavePackets
            // 
            this.checkAutoSavePackets.AutoSize = true;
            this.checkAutoSavePackets.Checked = global::W2.PacketSniffer.Properties.Settings.Default.AutoSavePackets;
            this.checkAutoSavePackets.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::W2.PacketSniffer.Properties.Settings.Default, "AutoSavePackets", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkAutoSavePackets.ForeColor = System.Drawing.Color.Black;
            this.checkAutoSavePackets.Location = new System.Drawing.Point(6, 21);
            this.checkAutoSavePackets.Name = "checkAutoSavePackets";
            this.checkAutoSavePackets.Size = new System.Drawing.Size(154, 17);
            this.checkAutoSavePackets.TabIndex = 1;
            this.checkAutoSavePackets.Text = "Enable Auto Save Packets";
            this.checkAutoSavePackets.UseVisualStyleBackColor = true;
            // 
            // groupNetwork
            // 
            groupNetwork.Controls.Add(label2);
            groupNetwork.Controls.Add(this.numDefaultPort);
            groupNetwork.Location = new System.Drawing.Point(6, 90);
            groupNetwork.Name = "groupNetwork";
            groupNetwork.Size = new System.Drawing.Size(364, 47);
            groupNetwork.TabIndex = 4;
            groupNetwork.TabStop = false;
            groupNetwork.Text = "Network";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(6, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 13);
            label2.TabIndex = 4;
            label2.Text = "Default Port";
            // 
            // numDefaultPort
            // 
            this.numDefaultPort.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::W2.PacketSniffer.Properties.Settings.Default, "DefaultPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numDefaultPort.Location = new System.Drawing.Point(75, 16);
            this.numDefaultPort.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numDefaultPort.Name = "numDefaultPort";
            this.numDefaultPort.Size = new System.Drawing.Size(85, 20);
            this.numDefaultPort.TabIndex = 0;
            this.numDefaultPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDefaultPort.Value = global::W2.PacketSniffer.Properties.Settings.Default.DefaultPort;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.btnSearchPacketFilterFile);
            groupBox1.Controls.Add(lblIgnoredPacketFile);
            groupBox1.Controls.Add(this.txtIgnoredPacketsFile);
            groupBox1.Controls.Add(this.checkEnableIgnoredPackets);
            groupBox1.Location = new System.Drawing.Point(6, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(364, 78);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ignored Packets Filter";
            // 
            // btnSearchPacketFilterFile
            // 
            this.btnSearchPacketFilterFile.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchPacketFilterFile.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::W2.PacketSniffer.Properties.Settings.Default, "IgnorePackets", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSearchPacketFilterFile.Enabled = global::W2.PacketSniffer.Properties.Settings.Default.IgnorePackets;
            this.btnSearchPacketFilterFile.ForeColor = System.Drawing.Color.Black;
            this.btnSearchPacketFilterFile.Location = new System.Drawing.Point(332, 43);
            this.btnSearchPacketFilterFile.Name = "btnSearchPacketFilterFile";
            this.btnSearchPacketFilterFile.Size = new System.Drawing.Size(26, 23);
            this.btnSearchPacketFilterFile.TabIndex = 4;
            this.btnSearchPacketFilterFile.Text = "...";
            this.btnSearchPacketFilterFile.UseVisualStyleBackColor = false;
            this.btnSearchPacketFilterFile.Click += new System.EventHandler(this.btnSearchPacketFilterFile_Click);
            // 
            // lblIgnoredPacketFile
            // 
            lblIgnoredPacketFile.AutoSize = true;
            lblIgnoredPacketFile.ForeColor = System.Drawing.Color.Black;
            lblIgnoredPacketFile.Location = new System.Drawing.Point(3, 48);
            lblIgnoredPacketFile.Name = "lblIgnoredPacketFile";
            lblIgnoredPacketFile.Size = new System.Drawing.Size(101, 13);
            lblIgnoredPacketFile.TabIndex = 3;
            lblIgnoredPacketFile.Text = "Ignore Packets File:";
            // 
            // txtIgnoredPacketsFile
            // 
            this.txtIgnoredPacketsFile.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::W2.PacketSniffer.Properties.Settings.Default, "IgnorePackets", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtIgnoredPacketsFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::W2.PacketSniffer.Properties.Settings.Default, "IgnoredPacketsFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtIgnoredPacketsFile.Enabled = global::W2.PacketSniffer.Properties.Settings.Default.IgnorePackets;
            this.txtIgnoredPacketsFile.Location = new System.Drawing.Point(132, 45);
            this.txtIgnoredPacketsFile.Name = "txtIgnoredPacketsFile";
            this.txtIgnoredPacketsFile.Size = new System.Drawing.Size(194, 20);
            this.txtIgnoredPacketsFile.TabIndex = 2;
            this.txtIgnoredPacketsFile.Text = global::W2.PacketSniffer.Properties.Settings.Default.IgnoredPacketsFile;
            // 
            // checkEnableIgnoredPackets
            // 
            this.checkEnableIgnoredPackets.AutoSize = true;
            this.checkEnableIgnoredPackets.Checked = global::W2.PacketSniffer.Properties.Settings.Default.IgnorePackets;
            this.checkEnableIgnoredPackets.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::W2.PacketSniffer.Properties.Settings.Default, "IgnorePackets", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkEnableIgnoredPackets.ForeColor = System.Drawing.Color.Black;
            this.checkEnableIgnoredPackets.Location = new System.Drawing.Point(6, 21);
            this.checkEnableIgnoredPackets.Name = "checkEnableIgnoredPackets";
            this.checkEnableIgnoredPackets.Size = new System.Drawing.Size(165, 17);
            this.checkEnableIgnoredPackets.TabIndex = 1;
            this.checkEnableIgnoredPackets.Text = "Enable Ignored Packets Filter";
            this.checkEnableIgnoredPackets.UseVisualStyleBackColor = true;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabMainSettings);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(384, 273);
            this.tabMain.TabIndex = 0;
            // 
            // tabMainSettings
            // 
            this.tabMainSettings.Controls.Add(groupBox1);
            this.tabMainSettings.Controls.Add(groupNetwork);
            this.tabMainSettings.Controls.Add(groupPacketLogging);
            this.tabMainSettings.Location = new System.Drawing.Point(4, 22);
            this.tabMainSettings.Name = "tabMainSettings";
            this.tabMainSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainSettings.Size = new System.Drawing.Size(376, 247);
            this.tabMainSettings.TabIndex = 0;
            this.tabMainSettings.Text = "General Settings";
            this.tabMainSettings.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(321, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(240, 291);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(408, 319);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabMain);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            groupPacketLogging.ResumeLayout(false);
            groupPacketLogging.PerformLayout();
            groupNetwork.ResumeLayout(false);
            groupNetwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDefaultPort)).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabMainSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabMainSettings;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtSavePacketDirectory;
        private System.Windows.Forms.CheckBox checkAutoSavePackets;
        private System.Windows.Forms.NumericUpDown numDefaultPort;
        private System.Windows.Forms.Button btnSearchFolder;
        private System.Windows.Forms.Button btnSearchPacketFilterFile;
        private System.Windows.Forms.TextBox txtIgnoredPacketsFile;
        private System.Windows.Forms.CheckBox checkEnableIgnoredPackets;
    }
}