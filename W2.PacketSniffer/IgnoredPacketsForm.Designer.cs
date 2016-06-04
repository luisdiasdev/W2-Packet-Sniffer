namespace W2.PacketSniffer
{
    partial class IgnoredPacketsForm
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
            System.Windows.Forms.Label lblPacketId;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IgnoredPacketsForm));
            this.groupIgnoredPacketList = new System.Windows.Forms.GroupBox();
            this.numOpCode = new System.Windows.Forms.NumericUpDown();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numPacketSize = new System.Windows.Forms.NumericUpDown();
            this.listIgnoredPackets = new System.Windows.Forms.ListBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            lblPacketId = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupIgnoredPacketList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacketSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPacketId
            // 
            lblPacketId.AutoSize = true;
            lblPacketId.Location = new System.Drawing.Point(133, 19);
            lblPacketId.Name = "lblPacketId";
            lblPacketId.Size = new System.Drawing.Size(74, 13);
            lblPacketId.TabIndex = 3;
            lblPacketId.Text = "OpCode (Hex)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(133, 62);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 13);
            label1.TabIndex = 4;
            label1.Text = "Size (decimal)";
            // 
            // groupIgnoredPacketList
            // 
            this.groupIgnoredPacketList.Controls.Add(this.numOpCode);
            this.groupIgnoredPacketList.Controls.Add(this.btnRemove);
            this.groupIgnoredPacketList.Controls.Add(this.btnAdd);
            this.groupIgnoredPacketList.Controls.Add(label1);
            this.groupIgnoredPacketList.Controls.Add(lblPacketId);
            this.groupIgnoredPacketList.Controls.Add(this.numPacketSize);
            this.groupIgnoredPacketList.Controls.Add(this.listIgnoredPackets);
            this.groupIgnoredPacketList.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::W2.PacketSniffer.Properties.Settings.Default, "IgnorePackets", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupIgnoredPacketList.Enabled = global::W2.PacketSniffer.Properties.Settings.Default.IgnorePackets;
            this.groupIgnoredPacketList.ForeColor = System.Drawing.Color.White;
            this.groupIgnoredPacketList.Location = new System.Drawing.Point(6, 4);
            this.groupIgnoredPacketList.Name = "groupIgnoredPacketList";
            this.groupIgnoredPacketList.Size = new System.Drawing.Size(225, 339);
            this.groupIgnoredPacketList.TabIndex = 1;
            this.groupIgnoredPacketList.TabStop = false;
            this.groupIgnoredPacketList.Text = "Ignored Packet List";
            // 
            // numOpCode
            // 
            this.numOpCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numOpCode.Hexadecimal = true;
            this.numOpCode.Location = new System.Drawing.Point(132, 37);
            this.numOpCode.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numOpCode.Name = "numOpCode";
            this.numOpCode.Size = new System.Drawing.Size(86, 20);
            this.numOpCode.TabIndex = 7;
            // 
            // btnRemove
            // 
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(131, 133);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.Location = new System.Drawing.Point(132, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numPacketSize
            // 
            this.numPacketSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPacketSize.Location = new System.Drawing.Point(132, 80);
            this.numPacketSize.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numPacketSize.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numPacketSize.Name = "numPacketSize";
            this.numPacketSize.Size = new System.Drawing.Size(86, 20);
            this.numPacketSize.TabIndex = 2;
            this.numPacketSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // listIgnoredPackets
            // 
            this.listIgnoredPackets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listIgnoredPackets.Location = new System.Drawing.Point(6, 19);
            this.listIgnoredPackets.Name = "listIgnoredPackets";
            this.listIgnoredPackets.Size = new System.Drawing.Size(120, 314);
            this.listIgnoredPackets.TabIndex = 0;
            // 
            // mainToolTip
            // 
            this.mainToolTip.AutomaticDelay = 100;
            this.mainToolTip.IsBalloon = true;
            // 
            // mainImageList
            // 
            this.mainImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainImageList.ImageStream")));
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.mainImageList.Images.SetKeyName(0, "plus_img.png");
            this.mainImageList.Images.SetKeyName(1, "minus_img.png");
            // 
            // IgnoredPacketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(235, 348);
            this.Controls.Add(this.groupIgnoredPacketList);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IgnoredPacketsForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ignored Packets";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IgnoredPacketsForm_FormClosed);
            this.Shown += new System.EventHandler(this.IgnoredPacketsForm_Shown);
            this.groupIgnoredPacketList.ResumeLayout(false);
            this.groupIgnoredPacketList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacketSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupIgnoredPacketList;
        private System.Windows.Forms.ListBox listIgnoredPackets;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numPacketSize;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.NumericUpDown numOpCode;
        private System.Windows.Forms.ImageList mainImageList;
    }
}