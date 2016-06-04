namespace W2.PacketSniffer
{
    partial class DetailsForm
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
            System.Windows.Forms.GroupBox groupPacketHeader;
            System.Windows.Forms.Label lblTimestamp;
            System.Windows.Forms.Label lblClientId;
            System.Windows.Forms.Label lblOpcode;
            System.Windows.Forms.Label lblCsum;
            System.Windows.Forms.Label lblKey;
            System.Windows.Forms.Label lblSize;
            System.Windows.Forms.Label lblUInt64;
            System.Windows.Forms.Label lblInt64;
            System.Windows.Forms.Label lblUShort;
            System.Windows.Forms.Label lblShort;
            System.Windows.Forms.Label lblByte;
            System.Windows.Forms.Label lblSByte;
            System.Windows.Forms.Label lblUInt32;
            System.Windows.Forms.Label lblInt32;
            this.txtPacketTimeStamp = new System.Windows.Forms.TextBox();
            this.txtPacketClientId = new System.Windows.Forms.TextBox();
            this.txtPacketOpCode = new System.Windows.Forms.TextBox();
            this.txtPacketCheckSum = new System.Windows.Forms.TextBox();
            this.txtPacketKey = new System.Windows.Forms.TextBox();
            this.txtPacketSize = new System.Windows.Forms.TextBox();
            this.hexPacketView = new Be.Windows.Forms.HexBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAsUInt64 = new System.Windows.Forms.TextBox();
            this.txtAsInt64 = new System.Windows.Forms.TextBox();
            this.txtAsUShort = new System.Windows.Forms.TextBox();
            this.txtAsShort = new System.Windows.Forms.TextBox();
            this.txtAsByte = new System.Windows.Forms.TextBox();
            this.txtAsSByte = new System.Windows.Forms.TextBox();
            this.txtAsUInt32 = new System.Windows.Forms.TextBox();
            this.txtAsInt32 = new System.Windows.Forms.TextBox();
            groupPacketHeader = new System.Windows.Forms.GroupBox();
            lblTimestamp = new System.Windows.Forms.Label();
            lblClientId = new System.Windows.Forms.Label();
            lblOpcode = new System.Windows.Forms.Label();
            lblCsum = new System.Windows.Forms.Label();
            lblKey = new System.Windows.Forms.Label();
            lblSize = new System.Windows.Forms.Label();
            lblUInt64 = new System.Windows.Forms.Label();
            lblInt64 = new System.Windows.Forms.Label();
            lblUShort = new System.Windows.Forms.Label();
            lblShort = new System.Windows.Forms.Label();
            lblByte = new System.Windows.Forms.Label();
            lblSByte = new System.Windows.Forms.Label();
            lblUInt32 = new System.Windows.Forms.Label();
            lblInt32 = new System.Windows.Forms.Label();
            groupPacketHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPacketHeader
            // 
            groupPacketHeader.BackColor = System.Drawing.Color.DimGray;
            groupPacketHeader.Controls.Add(lblTimestamp);
            groupPacketHeader.Controls.Add(lblClientId);
            groupPacketHeader.Controls.Add(lblOpcode);
            groupPacketHeader.Controls.Add(lblCsum);
            groupPacketHeader.Controls.Add(lblKey);
            groupPacketHeader.Controls.Add(lblSize);
            groupPacketHeader.Controls.Add(this.txtPacketTimeStamp);
            groupPacketHeader.Controls.Add(this.txtPacketClientId);
            groupPacketHeader.Controls.Add(this.txtPacketOpCode);
            groupPacketHeader.Controls.Add(this.txtPacketCheckSum);
            groupPacketHeader.Controls.Add(this.txtPacketKey);
            groupPacketHeader.Controls.Add(this.txtPacketSize);
            groupPacketHeader.ForeColor = System.Drawing.Color.White;
            groupPacketHeader.Location = new System.Drawing.Point(3, 3);
            groupPacketHeader.Name = "groupPacketHeader";
            groupPacketHeader.Size = new System.Drawing.Size(159, 189);
            groupPacketHeader.TabIndex = 0;
            groupPacketHeader.TabStop = false;
            groupPacketHeader.Text = "Packet Header";
            // 
            // lblTimestamp
            // 
            lblTimestamp.AutoSize = true;
            lblTimestamp.Location = new System.Drawing.Point(6, 157);
            lblTimestamp.Name = "lblTimestamp";
            lblTimestamp.Size = new System.Drawing.Size(60, 13);
            lblTimestamp.TabIndex = 11;
            lblTimestamp.Text = "TimeStamp";
            // 
            // lblClientId
            // 
            lblClientId.AutoSize = true;
            lblClientId.Location = new System.Drawing.Point(6, 131);
            lblClientId.Name = "lblClientId";
            lblClientId.Size = new System.Drawing.Size(47, 13);
            lblClientId.TabIndex = 10;
            lblClientId.Text = "Client ID";
            // 
            // lblOpcode
            // 
            lblOpcode.AutoSize = true;
            lblOpcode.Location = new System.Drawing.Point(6, 105);
            lblOpcode.Name = "lblOpcode";
            lblOpcode.Size = new System.Drawing.Size(46, 13);
            lblOpcode.TabIndex = 9;
            lblOpcode.Text = "OpCode";
            // 
            // lblCsum
            // 
            lblCsum.AutoSize = true;
            lblCsum.Location = new System.Drawing.Point(6, 79);
            lblCsum.Name = "lblCsum";
            lblCsum.Size = new System.Drawing.Size(59, 13);
            lblCsum.TabIndex = 8;
            lblCsum.Text = "CheckSum";
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Location = new System.Drawing.Point(6, 53);
            lblKey.Name = "lblKey";
            lblKey.Size = new System.Drawing.Size(25, 13);
            lblKey.TabIndex = 7;
            lblKey.Text = "Key";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new System.Drawing.Point(6, 27);
            lblSize.Name = "lblSize";
            lblSize.Size = new System.Drawing.Size(27, 13);
            lblSize.TabIndex = 6;
            lblSize.Text = "Size";
            // 
            // txtPacketTimeStamp
            // 
            this.txtPacketTimeStamp.BackColor = System.Drawing.Color.Silver;
            this.txtPacketTimeStamp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPacketTimeStamp.Location = new System.Drawing.Point(71, 155);
            this.txtPacketTimeStamp.Name = "txtPacketTimeStamp";
            this.txtPacketTimeStamp.ReadOnly = true;
            this.txtPacketTimeStamp.Size = new System.Drawing.Size(82, 20);
            this.txtPacketTimeStamp.TabIndex = 5;
            // 
            // txtPacketClientId
            // 
            this.txtPacketClientId.BackColor = System.Drawing.Color.Silver;
            this.txtPacketClientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPacketClientId.Location = new System.Drawing.Point(71, 129);
            this.txtPacketClientId.Name = "txtPacketClientId";
            this.txtPacketClientId.ReadOnly = true;
            this.txtPacketClientId.Size = new System.Drawing.Size(82, 20);
            this.txtPacketClientId.TabIndex = 4;
            // 
            // txtPacketOpCode
            // 
            this.txtPacketOpCode.BackColor = System.Drawing.Color.Silver;
            this.txtPacketOpCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPacketOpCode.Location = new System.Drawing.Point(71, 103);
            this.txtPacketOpCode.Name = "txtPacketOpCode";
            this.txtPacketOpCode.ReadOnly = true;
            this.txtPacketOpCode.Size = new System.Drawing.Size(82, 20);
            this.txtPacketOpCode.TabIndex = 3;
            // 
            // txtPacketCheckSum
            // 
            this.txtPacketCheckSum.BackColor = System.Drawing.Color.Silver;
            this.txtPacketCheckSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPacketCheckSum.Location = new System.Drawing.Point(71, 77);
            this.txtPacketCheckSum.Name = "txtPacketCheckSum";
            this.txtPacketCheckSum.ReadOnly = true;
            this.txtPacketCheckSum.Size = new System.Drawing.Size(82, 20);
            this.txtPacketCheckSum.TabIndex = 2;
            // 
            // txtPacketKey
            // 
            this.txtPacketKey.BackColor = System.Drawing.Color.Silver;
            this.txtPacketKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPacketKey.Location = new System.Drawing.Point(71, 51);
            this.txtPacketKey.Name = "txtPacketKey";
            this.txtPacketKey.ReadOnly = true;
            this.txtPacketKey.Size = new System.Drawing.Size(82, 20);
            this.txtPacketKey.TabIndex = 1;
            // 
            // txtPacketSize
            // 
            this.txtPacketSize.BackColor = System.Drawing.Color.Silver;
            this.txtPacketSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPacketSize.Location = new System.Drawing.Point(71, 25);
            this.txtPacketSize.Name = "txtPacketSize";
            this.txtPacketSize.ReadOnly = true;
            this.txtPacketSize.Size = new System.Drawing.Size(82, 20);
            this.txtPacketSize.TabIndex = 0;
            // 
            // lblUInt64
            // 
            lblUInt64.AutoSize = true;
            lblUInt64.Location = new System.Drawing.Point(6, 209);
            lblUInt64.Name = "lblUInt64";
            lblUInt64.Size = new System.Drawing.Size(39, 13);
            lblUInt64.TabIndex = 7;
            lblUInt64.Text = "UInt64";
            // 
            // lblInt64
            // 
            lblInt64.AutoSize = true;
            lblInt64.Location = new System.Drawing.Point(6, 183);
            lblInt64.Name = "lblInt64";
            lblInt64.Size = new System.Drawing.Size(31, 13);
            lblInt64.TabIndex = 6;
            lblInt64.Text = "Int64";
            // 
            // lblUShort
            // 
            lblUShort.AutoSize = true;
            lblUShort.Location = new System.Drawing.Point(6, 105);
            lblUShort.Name = "lblUShort";
            lblUShort.Size = new System.Drawing.Size(40, 13);
            lblUShort.TabIndex = 3;
            lblUShort.Text = "UShort";
            // 
            // lblShort
            // 
            lblShort.AutoSize = true;
            lblShort.Location = new System.Drawing.Point(6, 79);
            lblShort.Name = "lblShort";
            lblShort.Size = new System.Drawing.Size(32, 13);
            lblShort.TabIndex = 2;
            lblShort.Text = "Short";
            // 
            // lblByte
            // 
            lblByte.AutoSize = true;
            lblByte.Location = new System.Drawing.Point(6, 53);
            lblByte.Name = "lblByte";
            lblByte.Size = new System.Drawing.Size(28, 13);
            lblByte.TabIndex = 1;
            lblByte.Text = "Byte";
            // 
            // lblSByte
            // 
            lblSByte.AutoSize = true;
            lblSByte.Location = new System.Drawing.Point(6, 27);
            lblSByte.Name = "lblSByte";
            lblSByte.Size = new System.Drawing.Size(35, 13);
            lblSByte.TabIndex = 0;
            lblSByte.Text = "SByte";
            // 
            // lblUInt32
            // 
            lblUInt32.AutoSize = true;
            lblUInt32.Location = new System.Drawing.Point(6, 157);
            lblUInt32.Name = "lblUInt32";
            lblUInt32.Size = new System.Drawing.Size(39, 13);
            lblUInt32.TabIndex = 5;
            lblUInt32.Text = "UInt32";
            // 
            // lblInt32
            // 
            lblInt32.AutoSize = true;
            lblInt32.Location = new System.Drawing.Point(6, 131);
            lblInt32.Name = "lblInt32";
            lblInt32.Size = new System.Drawing.Size(31, 13);
            lblInt32.TabIndex = 4;
            lblInt32.Text = "Int32";
            // 
            // hexPacketView
            // 
            this.hexPacketView.BackColor = System.Drawing.Color.DarkGray;
            this.hexPacketView.BackColorDisabled = System.Drawing.Color.DimGray;
            this.hexPacketView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hexPacketView.ColumnInfoVisible = true;
            this.hexPacketView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hexPacketView.ForeColor = System.Drawing.Color.Black;
            this.hexPacketView.InfoForeColor = System.Drawing.Color.White;
            this.hexPacketView.LineInfoVisible = true;
            this.hexPacketView.Location = new System.Drawing.Point(168, 8);
            this.hexPacketView.Name = "hexPacketView";
            this.hexPacketView.ReadOnly = true;
            this.hexPacketView.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexPacketView.Size = new System.Drawing.Size(677, 354);
            this.hexPacketView.StringViewVisible = true;
            this.hexPacketView.TabIndex = 1;
            this.hexPacketView.UseFixedBytesPerLine = true;
            this.hexPacketView.VScrollBarVisible = true;
            this.hexPacketView.CurrentLineChanged += new System.EventHandler(this.hexPacketView_PositionChanged);
            this.hexPacketView.CurrentPositionInLineChanged += new System.EventHandler(this.hexPacketView_PositionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(lblUInt64);
            this.groupBox1.Controls.Add(this.txtAsUInt64);
            this.groupBox1.Controls.Add(lblInt64);
            this.groupBox1.Controls.Add(this.txtAsInt64);
            this.groupBox1.Controls.Add(lblUShort);
            this.groupBox1.Controls.Add(this.txtAsUShort);
            this.groupBox1.Controls.Add(lblShort);
            this.groupBox1.Controls.Add(this.txtAsShort);
            this.groupBox1.Controls.Add(lblByte);
            this.groupBox1.Controls.Add(this.txtAsByte);
            this.groupBox1.Controls.Add(lblSByte);
            this.groupBox1.Controls.Add(this.txtAsSByte);
            this.groupBox1.Controls.Add(lblUInt32);
            this.groupBox1.Controls.Add(this.txtAsUInt32);
            this.groupBox1.Controls.Add(lblInt32);
            this.groupBox1.Controls.Add(this.txtAsInt32);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(851, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 241);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Byte As:";
            // 
            // txtAsUInt64
            // 
            this.txtAsUInt64.BackColor = System.Drawing.Color.Silver;
            this.txtAsUInt64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsUInt64.Location = new System.Drawing.Point(56, 206);
            this.txtAsUInt64.Name = "txtAsUInt64";
            this.txtAsUInt64.ReadOnly = true;
            this.txtAsUInt64.Size = new System.Drawing.Size(100, 20);
            this.txtAsUInt64.TabIndex = 15;
            // 
            // txtAsInt64
            // 
            this.txtAsInt64.BackColor = System.Drawing.Color.Silver;
            this.txtAsInt64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsInt64.Location = new System.Drawing.Point(56, 180);
            this.txtAsInt64.Name = "txtAsInt64";
            this.txtAsInt64.ReadOnly = true;
            this.txtAsInt64.Size = new System.Drawing.Size(100, 20);
            this.txtAsInt64.TabIndex = 14;
            // 
            // txtAsUShort
            // 
            this.txtAsUShort.BackColor = System.Drawing.Color.Silver;
            this.txtAsUShort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsUShort.Location = new System.Drawing.Point(56, 102);
            this.txtAsUShort.Name = "txtAsUShort";
            this.txtAsUShort.ReadOnly = true;
            this.txtAsUShort.Size = new System.Drawing.Size(100, 20);
            this.txtAsUShort.TabIndex = 11;
            // 
            // txtAsShort
            // 
            this.txtAsShort.BackColor = System.Drawing.Color.Silver;
            this.txtAsShort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsShort.Location = new System.Drawing.Point(56, 76);
            this.txtAsShort.Name = "txtAsShort";
            this.txtAsShort.ReadOnly = true;
            this.txtAsShort.Size = new System.Drawing.Size(100, 20);
            this.txtAsShort.TabIndex = 10;
            // 
            // txtAsByte
            // 
            this.txtAsByte.BackColor = System.Drawing.Color.Silver;
            this.txtAsByte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsByte.Location = new System.Drawing.Point(56, 50);
            this.txtAsByte.Name = "txtAsByte";
            this.txtAsByte.ReadOnly = true;
            this.txtAsByte.Size = new System.Drawing.Size(100, 20);
            this.txtAsByte.TabIndex = 9;
            // 
            // txtAsSByte
            // 
            this.txtAsSByte.BackColor = System.Drawing.Color.Silver;
            this.txtAsSByte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsSByte.Location = new System.Drawing.Point(56, 24);
            this.txtAsSByte.Name = "txtAsSByte";
            this.txtAsSByte.ReadOnly = true;
            this.txtAsSByte.Size = new System.Drawing.Size(100, 20);
            this.txtAsSByte.TabIndex = 8;
            // 
            // txtAsUInt32
            // 
            this.txtAsUInt32.BackColor = System.Drawing.Color.Silver;
            this.txtAsUInt32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsUInt32.Location = new System.Drawing.Point(56, 154);
            this.txtAsUInt32.Name = "txtAsUInt32";
            this.txtAsUInt32.ReadOnly = true;
            this.txtAsUInt32.Size = new System.Drawing.Size(100, 20);
            this.txtAsUInt32.TabIndex = 13;
            // 
            // txtAsInt32
            // 
            this.txtAsInt32.BackColor = System.Drawing.Color.Silver;
            this.txtAsInt32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsInt32.Location = new System.Drawing.Point(56, 128);
            this.txtAsInt32.Name = "txtAsInt32";
            this.txtAsInt32.ReadOnly = true;
            this.txtAsInt32.Size = new System.Drawing.Size(100, 20);
            this.txtAsInt32.TabIndex = 12;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1032, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(groupPacketHeader);
            this.Controls.Add(this.hexPacketView);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetailsForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Details of Packet";
            groupPacketHeader.ResumeLayout(false);
            groupPacketHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Be.Windows.Forms.HexBox hexPacketView;
        private System.Windows.Forms.TextBox txtPacketTimeStamp;
        private System.Windows.Forms.TextBox txtPacketClientId;
        private System.Windows.Forms.TextBox txtPacketOpCode;
        private System.Windows.Forms.TextBox txtPacketCheckSum;
        private System.Windows.Forms.TextBox txtPacketKey;
        private System.Windows.Forms.TextBox txtPacketSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAsUInt64;
        private System.Windows.Forms.TextBox txtAsInt64;
        private System.Windows.Forms.TextBox txtAsUShort;
        private System.Windows.Forms.TextBox txtAsShort;
        private System.Windows.Forms.TextBox txtAsByte;
        private System.Windows.Forms.TextBox txtAsSByte;
        private System.Windows.Forms.TextBox txtAsUInt32;
        private System.Windows.Forms.TextBox txtAsInt32;
    }
}