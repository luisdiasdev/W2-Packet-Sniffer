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
            System.Windows.Forms.Label lbl_SelectedBytesAs;
            System.Windows.Forms.Label lblInt32;
            System.Windows.Forms.Label lblUInt32;
            System.Windows.Forms.Label lblSByte;
            System.Windows.Forms.Label lblByte;
            System.Windows.Forms.Label lblShort;
            System.Windows.Forms.Label lblUShort;
            System.Windows.Forms.Label lblUInt64;
            System.Windows.Forms.Label lblInt64;
            this.hexPacketView = new Be.Windows.Forms.HexBox();
            this.lblCurrentPosition = new System.Windows.Forms.Label();
            this.txtAsInt32 = new System.Windows.Forms.TextBox();
            this.txtAsUInt32 = new System.Windows.Forms.TextBox();
            this.txtAsSByte = new System.Windows.Forms.TextBox();
            this.txtAsByte = new System.Windows.Forms.TextBox();
            this.txtAsShort = new System.Windows.Forms.TextBox();
            this.txtAsUShort = new System.Windows.Forms.TextBox();
            this.txtAsUInt64 = new System.Windows.Forms.TextBox();
            this.txtAsInt64 = new System.Windows.Forms.TextBox();
            lbl_SelectedBytesAs = new System.Windows.Forms.Label();
            lblInt32 = new System.Windows.Forms.Label();
            lblUInt32 = new System.Windows.Forms.Label();
            lblSByte = new System.Windows.Forms.Label();
            lblByte = new System.Windows.Forms.Label();
            lblShort = new System.Windows.Forms.Label();
            lblUShort = new System.Windows.Forms.Label();
            lblUInt64 = new System.Windows.Forms.Label();
            lblInt64 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_SelectedBytesAs
            // 
            lbl_SelectedBytesAs.AutoSize = true;
            lbl_SelectedBytesAs.Location = new System.Drawing.Point(694, 15);
            lbl_SelectedBytesAs.Name = "lbl_SelectedBytesAs";
            lbl_SelectedBytesAs.Size = new System.Drawing.Size(96, 13);
            lbl_SelectedBytesAs.TabIndex = 3;
            lbl_SelectedBytesAs.Text = "Selected Bytes As:";
            // 
            // lblInt32
            // 
            lblInt32.AutoSize = true;
            lblInt32.Location = new System.Drawing.Point(695, 140);
            lblInt32.Name = "lblInt32";
            lblInt32.Size = new System.Drawing.Size(31, 13);
            lblInt32.TabIndex = 5;
            lblInt32.Text = "Int32";
            // 
            // lblUInt32
            // 
            lblUInt32.AutoSize = true;
            lblUInt32.Location = new System.Drawing.Point(695, 166);
            lblUInt32.Name = "lblUInt32";
            lblUInt32.Size = new System.Drawing.Size(39, 13);
            lblUInt32.TabIndex = 7;
            lblUInt32.Text = "UInt32";
            // 
            // lblSByte
            // 
            lblSByte.AutoSize = true;
            lblSByte.Location = new System.Drawing.Point(695, 36);
            lblSByte.Name = "lblSByte";
            lblSByte.Size = new System.Drawing.Size(35, 13);
            lblSByte.TabIndex = 9;
            lblSByte.Text = "SByte";
            // 
            // lblByte
            // 
            lblByte.AutoSize = true;
            lblByte.Location = new System.Drawing.Point(695, 62);
            lblByte.Name = "lblByte";
            lblByte.Size = new System.Drawing.Size(28, 13);
            lblByte.TabIndex = 11;
            lblByte.Text = "Byte";
            // 
            // lblShort
            // 
            lblShort.AutoSize = true;
            lblShort.Location = new System.Drawing.Point(695, 88);
            lblShort.Name = "lblShort";
            lblShort.Size = new System.Drawing.Size(32, 13);
            lblShort.TabIndex = 13;
            lblShort.Text = "Short";
            // 
            // lblUShort
            // 
            lblUShort.AutoSize = true;
            lblUShort.Location = new System.Drawing.Point(695, 114);
            lblUShort.Name = "lblUShort";
            lblUShort.Size = new System.Drawing.Size(40, 13);
            lblUShort.TabIndex = 15;
            lblUShort.Text = "UShort";
            // 
            // lblUInt64
            // 
            lblUInt64.AutoSize = true;
            lblUInt64.Location = new System.Drawing.Point(695, 218);
            lblUInt64.Name = "lblUInt64";
            lblUInt64.Size = new System.Drawing.Size(39, 13);
            lblUInt64.TabIndex = 19;
            lblUInt64.Text = "UInt64";
            // 
            // lblInt64
            // 
            lblInt64.AutoSize = true;
            lblInt64.Location = new System.Drawing.Point(695, 192);
            lblInt64.Name = "lblInt64";
            lblInt64.Size = new System.Drawing.Size(31, 13);
            lblInt64.TabIndex = 17;
            lblInt64.Text = "Int64";
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
            this.hexPacketView.Location = new System.Drawing.Point(12, 12);
            this.hexPacketView.Name = "hexPacketView";
            this.hexPacketView.ReadOnly = true;
            this.hexPacketView.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexPacketView.Size = new System.Drawing.Size(677, 354);
            this.hexPacketView.StringViewVisible = true;
            this.hexPacketView.TabIndex = 1;
            this.hexPacketView.VScrollBarVisible = true;
            this.hexPacketView.CurrentLineChanged += new System.EventHandler(this.hexPacketView_PositionChanged);
            this.hexPacketView.CurrentPositionInLineChanged += new System.EventHandler(this.hexPacketView_PositionChanged);
            // 
            // lblCurrentPosition
            // 
            this.lblCurrentPosition.AutoSize = true;
            this.lblCurrentPosition.Location = new System.Drawing.Point(12, 380);
            this.lblCurrentPosition.Name = "lblCurrentPosition";
            this.lblCurrentPosition.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentPosition.TabIndex = 2;
            // 
            // txtAsInt32
            // 
            this.txtAsInt32.BackColor = System.Drawing.Color.Silver;
            this.txtAsInt32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsInt32.Location = new System.Drawing.Point(745, 137);
            this.txtAsInt32.Name = "txtAsInt32";
            this.txtAsInt32.ReadOnly = true;
            this.txtAsInt32.Size = new System.Drawing.Size(100, 20);
            this.txtAsInt32.TabIndex = 4;
            // 
            // txtAsUInt32
            // 
            this.txtAsUInt32.BackColor = System.Drawing.Color.Silver;
            this.txtAsUInt32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsUInt32.Location = new System.Drawing.Point(745, 163);
            this.txtAsUInt32.Name = "txtAsUInt32";
            this.txtAsUInt32.ReadOnly = true;
            this.txtAsUInt32.Size = new System.Drawing.Size(100, 20);
            this.txtAsUInt32.TabIndex = 6;
            // 
            // txtAsSByte
            // 
            this.txtAsSByte.BackColor = System.Drawing.Color.Silver;
            this.txtAsSByte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsSByte.Location = new System.Drawing.Point(745, 33);
            this.txtAsSByte.Name = "txtAsSByte";
            this.txtAsSByte.ReadOnly = true;
            this.txtAsSByte.Size = new System.Drawing.Size(100, 20);
            this.txtAsSByte.TabIndex = 8;
            // 
            // txtAsByte
            // 
            this.txtAsByte.BackColor = System.Drawing.Color.Silver;
            this.txtAsByte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsByte.Location = new System.Drawing.Point(745, 59);
            this.txtAsByte.Name = "txtAsByte";
            this.txtAsByte.ReadOnly = true;
            this.txtAsByte.Size = new System.Drawing.Size(100, 20);
            this.txtAsByte.TabIndex = 10;
            // 
            // txtAsShort
            // 
            this.txtAsShort.BackColor = System.Drawing.Color.Silver;
            this.txtAsShort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsShort.Location = new System.Drawing.Point(745, 85);
            this.txtAsShort.Name = "txtAsShort";
            this.txtAsShort.ReadOnly = true;
            this.txtAsShort.Size = new System.Drawing.Size(100, 20);
            this.txtAsShort.TabIndex = 12;
            // 
            // txtAsUShort
            // 
            this.txtAsUShort.BackColor = System.Drawing.Color.Silver;
            this.txtAsUShort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsUShort.Location = new System.Drawing.Point(745, 111);
            this.txtAsUShort.Name = "txtAsUShort";
            this.txtAsUShort.ReadOnly = true;
            this.txtAsUShort.Size = new System.Drawing.Size(100, 20);
            this.txtAsUShort.TabIndex = 14;
            // 
            // txtAsUInt64
            // 
            this.txtAsUInt64.BackColor = System.Drawing.Color.Silver;
            this.txtAsUInt64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsUInt64.Location = new System.Drawing.Point(745, 215);
            this.txtAsUInt64.Name = "txtAsUInt64";
            this.txtAsUInt64.ReadOnly = true;
            this.txtAsUInt64.Size = new System.Drawing.Size(100, 20);
            this.txtAsUInt64.TabIndex = 18;
            // 
            // txtAsInt64
            // 
            this.txtAsInt64.BackColor = System.Drawing.Color.Silver;
            this.txtAsInt64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsInt64.Location = new System.Drawing.Point(745, 189);
            this.txtAsInt64.Name = "txtAsInt64";
            this.txtAsInt64.ReadOnly = true;
            this.txtAsInt64.Size = new System.Drawing.Size(100, 20);
            this.txtAsInt64.TabIndex = 16;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(855, 376);
            this.Controls.Add(lblUInt64);
            this.Controls.Add(this.txtAsUInt64);
            this.Controls.Add(lblInt64);
            this.Controls.Add(this.txtAsInt64);
            this.Controls.Add(lblUShort);
            this.Controls.Add(this.txtAsUShort);
            this.Controls.Add(lblShort);
            this.Controls.Add(this.txtAsShort);
            this.Controls.Add(lblByte);
            this.Controls.Add(this.txtAsByte);
            this.Controls.Add(lblSByte);
            this.Controls.Add(this.txtAsSByte);
            this.Controls.Add(lblUInt32);
            this.Controls.Add(this.txtAsUInt32);
            this.Controls.Add(lblInt32);
            this.Controls.Add(this.txtAsInt32);
            this.Controls.Add(lbl_SelectedBytesAs);
            this.Controls.Add(this.lblCurrentPosition);
            this.Controls.Add(this.hexPacketView);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetailsForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Details of Packet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Be.Windows.Forms.HexBox hexPacketView;
        private System.Windows.Forms.Label lblCurrentPosition;
        private System.Windows.Forms.TextBox txtAsInt32;
        private System.Windows.Forms.TextBox txtAsUInt32;
        private System.Windows.Forms.TextBox txtAsSByte;
        private System.Windows.Forms.TextBox txtAsByte;
        private System.Windows.Forms.TextBox txtAsShort;
        private System.Windows.Forms.TextBox txtAsUShort;
        private System.Windows.Forms.TextBox txtAsUInt64;
        private System.Windows.Forms.TextBox txtAsInt64;
    }
}