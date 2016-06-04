namespace W2.PacketSniffer
{
    partial class MainForm
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
            System.Windows.Forms.ToolStripLabel lbl_FillTheHole;
            System.Windows.Forms.ToolStripLabel toolStripLabel1;
            System.Windows.Forms.ToolStripLabel toolStripLabel2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPacketLog = new System.Windows.Forms.DataGridView();
            this.TimeStampColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacketDirectionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacketSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuTools = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsStartLogging = new System.Windows.Forms.ToolStripButton();
            this.toolsPauseLogging = new System.Windows.Forms.ToolStripButton();
            this.toolsStopLogging = new System.Windows.Forms.ToolStripButton();
            this.toolsShowDetails = new System.Windows.Forms.ToolStripButton();
            this.toolsSavePacket = new System.Windows.Forms.ToolStripButton();
            this.toolsClearView = new System.Windows.Forms.ToolStripButton();
            this.menuOptionsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptionsIgnoredPackets = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            lbl_FillTheHole = new System.Windows.Forms.ToolStripLabel();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacketLog)).BeginInit();
            this.menuTools.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_FillTheHole
            // 
            lbl_FillTheHole.ActiveLinkColor = System.Drawing.Color.Transparent;
            lbl_FillTheHole.BackColor = System.Drawing.Color.Transparent;
            lbl_FillTheHole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            lbl_FillTheHole.ForeColor = System.Drawing.Color.Transparent;
            lbl_FillTheHole.LinkColor = System.Drawing.Color.Transparent;
            lbl_FillTheHole.Name = "lbl_FillTheHole";
            lbl_FillTheHole.Size = new System.Drawing.Size(10, 22);
            lbl_FillTheHole.Text = " ";
            lbl_FillTheHole.VisitedLinkColor = System.Drawing.Color.Transparent;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.ActiveLinkColor = System.Drawing.Color.Transparent;
            toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripLabel1.ForeColor = System.Drawing.Color.Transparent;
            toolStripLabel1.LinkColor = System.Drawing.Color.Transparent;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(10, 22);
            toolStripLabel1.Text = " ";
            toolStripLabel1.VisitedLinkColor = System.Drawing.Color.Transparent;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.ActiveLinkColor = System.Drawing.Color.Transparent;
            toolStripLabel2.BackColor = System.Drawing.Color.Transparent;
            toolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripLabel2.ForeColor = System.Drawing.Color.Transparent;
            toolStripLabel2.LinkColor = System.Drawing.Color.Transparent;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new System.Drawing.Size(10, 22);
            toolStripLabel2.Text = " ";
            toolStripLabel2.VisitedLinkColor = System.Drawing.Color.Transparent;
            // 
            // dgvPacketLog
            // 
            this.dgvPacketLog.AllowUserToAddRows = false;
            this.dgvPacketLog.AllowUserToDeleteRows = false;
            this.dgvPacketLog.AllowUserToResizeRows = false;
            this.dgvPacketLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacketLog.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvPacketLog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacketLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacketLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacketLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeStampColumn,
            this.PacketDirectionColumn,
            this.FromAddressColumn,
            this.ToAddressColumn,
            this.PacketSizeColumn,
            this.OpCodeColumn,
            this.ClientIdColumn});
            this.dgvPacketLog.GridColor = System.Drawing.Color.Black;
            this.dgvPacketLog.Location = new System.Drawing.Point(9, 58);
            this.dgvPacketLog.MultiSelect = false;
            this.dgvPacketLog.Name = "dgvPacketLog";
            this.dgvPacketLog.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacketLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPacketLog.RowHeadersVisible = false;
            this.dgvPacketLog.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPacketLog.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvPacketLog.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPacketLog.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvPacketLog.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPacketLog.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacketLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacketLog.Size = new System.Drawing.Size(880, 459);
            this.dgvPacketLog.TabIndex = 1;
            this.dgvPacketLog.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacketLog_CellDoubleClick);
            this.dgvPacketLog.CurrentCellChanged += new System.EventHandler(this.dgvPacketLog_CurrentCellChanged);
            // 
            // TimeStampColumn
            // 
            this.TimeStampColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.TimeStampColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.TimeStampColumn.FillWeight = 120F;
            this.TimeStampColumn.HeaderText = "Time Stamp";
            this.TimeStampColumn.MinimumWidth = 160;
            this.TimeStampColumn.Name = "TimeStampColumn";
            this.TimeStampColumn.ReadOnly = true;
            this.TimeStampColumn.Width = 160;
            // 
            // PacketDirectionColumn
            // 
            this.PacketDirectionColumn.HeaderText = "Direction";
            this.PacketDirectionColumn.Name = "PacketDirectionColumn";
            this.PacketDirectionColumn.ReadOnly = true;
            // 
            // FromAddressColumn
            // 
            this.FromAddressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FromAddressColumn.HeaderText = "From";
            this.FromAddressColumn.MinimumWidth = 120;
            this.FromAddressColumn.Name = "FromAddressColumn";
            this.FromAddressColumn.ReadOnly = true;
            this.FromAddressColumn.Width = 120;
            // 
            // ToAddressColumn
            // 
            this.ToAddressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ToAddressColumn.HeaderText = "To";
            this.ToAddressColumn.MinimumWidth = 120;
            this.ToAddressColumn.Name = "ToAddressColumn";
            this.ToAddressColumn.ReadOnly = true;
            this.ToAddressColumn.Width = 120;
            // 
            // PacketSizeColumn
            // 
            this.PacketSizeColumn.HeaderText = "Size";
            this.PacketSizeColumn.Name = "PacketSizeColumn";
            this.PacketSizeColumn.ReadOnly = true;
            // 
            // OpCodeColumn
            // 
            this.OpCodeColumn.HeaderText = "OpCode";
            this.OpCodeColumn.Name = "OpCodeColumn";
            this.OpCodeColumn.ReadOnly = true;
            // 
            // ClientIdColumn
            // 
            this.ClientIdColumn.HeaderText = "Client ID";
            this.ClientIdColumn.Name = "ClientIdColumn";
            this.ClientIdColumn.ReadOnly = true;
            // 
            // menuTools
            // 
            this.menuTools.BackColor = System.Drawing.Color.DarkGray;
            this.menuTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lbl_FillTheHole,
            this.toolsStartLogging,
            this.toolsPauseLogging,
            this.toolsStopLogging,
            this.toolStripSeparator1,
            this.toolsShowDetails,
            this.toolsSavePacket,
            this.toolStripSeparator2,
            this.toolsClearView,
            toolStripLabel2,
            toolStripLabel1});
            this.menuTools.Location = new System.Drawing.Point(0, 24);
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(896, 25);
            this.menuTools.TabIndex = 2;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.Transparent;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(896, 24);
            this.menuMain.TabIndex = 0;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOptionsSettings,
            this.toolStripSeparator3,
            this.menuOptionsIgnoredPackets});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // toolsStartLogging
            // 
            this.toolsStartLogging.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsStartLogging.Image = global::W2.PacketSniffer.Properties.Resources.play_img;
            this.toolsStartLogging.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsStartLogging.Name = "toolsStartLogging";
            this.toolsStartLogging.Size = new System.Drawing.Size(23, 22);
            this.toolsStartLogging.Click += new System.EventHandler(this.toolsStartLogging_Click);
            // 
            // toolsPauseLogging
            // 
            this.toolsPauseLogging.CheckOnClick = true;
            this.toolsPauseLogging.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsPauseLogging.Enabled = false;
            this.toolsPauseLogging.Image = global::W2.PacketSniffer.Properties.Resources.pause_img;
            this.toolsPauseLogging.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsPauseLogging.Name = "toolsPauseLogging";
            this.toolsPauseLogging.Size = new System.Drawing.Size(23, 22);
            this.toolsPauseLogging.ToolTipText = "Stops the logging of packets.";
            // 
            // toolsStopLogging
            // 
            this.toolsStopLogging.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsStopLogging.Enabled = false;
            this.toolsStopLogging.Image = global::W2.PacketSniffer.Properties.Resources.stop_img;
            this.toolsStopLogging.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsStopLogging.Name = "toolsStopLogging";
            this.toolsStopLogging.Size = new System.Drawing.Size(23, 22);
            this.toolsStopLogging.Text = "toolStripButton3";
            this.toolsStopLogging.ToolTipText = "Stops receiving packets.";
            this.toolsStopLogging.Click += new System.EventHandler(this.toolsStopLogging_Click);
            // 
            // toolsShowDetails
            // 
            this.toolsShowDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsShowDetails.Enabled = false;
            this.toolsShowDetails.Image = global::W2.PacketSniffer.Properties.Resources.details_img;
            this.toolsShowDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsShowDetails.Name = "toolsShowDetails";
            this.toolsShowDetails.Size = new System.Drawing.Size(23, 22);
            this.toolsShowDetails.ToolTipText = "Show details of the selected packet.";
            this.toolsShowDetails.Click += new System.EventHandler(this.toolsShowDetails_Click);
            // 
            // toolsSavePacket
            // 
            this.toolsSavePacket.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsSavePacket.Enabled = false;
            this.toolsSavePacket.Image = global::W2.PacketSniffer.Properties.Resources.save_img;
            this.toolsSavePacket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsSavePacket.Name = "toolsSavePacket";
            this.toolsSavePacket.Size = new System.Drawing.Size(23, 22);
            this.toolsSavePacket.ToolTipText = "Saves the selected packet to a binary file.";
            this.toolsSavePacket.Click += new System.EventHandler(this.toolsSavePacket_Click);
            // 
            // toolsClearView
            // 
            this.toolsClearView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsClearView.Enabled = false;
            this.toolsClearView.Image = global::W2.PacketSniffer.Properties.Resources.trash_img;
            this.toolsClearView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsClearView.Name = "toolsClearView";
            this.toolsClearView.Size = new System.Drawing.Size(23, 22);
            this.toolsClearView.ToolTipText = "Clears the packet log.";
            this.toolsClearView.Click += new System.EventHandler(this.toolsClearView_Click);
            // 
            // menuOptionsSettings
            // 
            this.menuOptionsSettings.Image = global::W2.PacketSniffer.Properties.Resources.settings_img;
            this.menuOptionsSettings.Name = "menuOptionsSettings";
            this.menuOptionsSettings.Size = new System.Drawing.Size(158, 22);
            this.menuOptionsSettings.Text = "Settings";
            this.menuOptionsSettings.Click += new System.EventHandler(this.menuOptionsSettings_Click);
            // 
            // menuOptionsIgnoredPackets
            // 
            this.menuOptionsIgnoredPackets.Image = global::W2.PacketSniffer.Properties.Resources.filter_img;
            this.menuOptionsIgnoredPackets.Name = "menuOptionsIgnoredPackets";
            this.menuOptionsIgnoredPackets.Size = new System.Drawing.Size(158, 22);
            this.menuOptionsIgnoredPackets.Text = "Ignored Packets";
            this.menuOptionsIgnoredPackets.Click += new System.EventHandler(this.menuOptionsIgnoredPackets_Click);
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Image = global::W2.PacketSniffer.Properties.Resources.help_img;
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.menuHelpAbout.Text = "About";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(896, 535);
            this.Controls.Add(this.menuTools);
            this.Controls.Add(this.dgvPacketLog);
            this.Controls.Add(this.menuMain);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.Text = "W2 Packet Sniffer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacketLog)).EndInit();
            this.menuTools.ResumeLayout(false);
            this.menuTools.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPacketLog;
        private System.Windows.Forms.ToolStrip menuTools;
        private System.Windows.Forms.ToolStripButton toolsStartLogging;
        private System.Windows.Forms.ToolStripButton toolsPauseLogging;
        private System.Windows.Forms.ToolStripButton toolsStopLogging;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStampColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacketDirectionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacketSizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientIdColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolsShowDetails;
        private System.Windows.Forms.ToolStripButton toolsSavePacket;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOptionsSettings;
        private System.Windows.Forms.ToolStripButton toolsClearView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuOptionsIgnoredPackets;
    }
}