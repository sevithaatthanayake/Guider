namespace Project_SLIIT
{
    partial class Other
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Other));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtLKR = new System.Windows.Forms.TextBox();
            this.txtANS = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboTOT = new System.Windows.Forms.ComboBox();
            this.cboUsd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboCon = new System.Windows.Forms.ComboBox();
            this.cboVal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(418, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(611, 385);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 385);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "A Map Of SriLanka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sri Dalada Maligawa ";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(20, 440);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // txtLKR
            // 
            this.txtLKR.Location = new System.Drawing.Point(104, 72);
            this.txtLKR.Name = "txtLKR";
            this.txtLKR.Size = new System.Drawing.Size(108, 22);
            this.txtLKR.TabIndex = 8;
            // 
            // txtANS
            // 
            this.txtANS.Location = new System.Drawing.Point(104, 104);
            this.txtANS.Name = "txtANS";
            this.txtANS.Size = new System.Drawing.Size(108, 22);
            this.txtANS.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboTOT);
            this.panel1.Controls.Add(this.cboUsd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLKR);
            this.panel1.Controls.Add(this.txtANS);
            this.panel1.Location = new System.Drawing.Point(350, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 152);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cboTOT
            // 
            this.cboTOT.FormattingEnabled = true;
            this.cboTOT.Items.AddRange(new object[] {
            "LKR",
            "USD"});
            this.cboTOT.Location = new System.Drawing.Point(3, 102);
            this.cboTOT.Name = "cboTOT";
            this.cboTOT.Size = new System.Drawing.Size(80, 24);
            this.cboTOT.TabIndex = 19;
            this.cboTOT.Text = "LKR";
            this.cboTOT.SelectedIndexChanged += new System.EventHandler(this.cboTOT_SelectedIndexChanged);
            // 
            // cboUsd
            // 
            this.cboUsd.FormattingEnabled = true;
            this.cboUsd.Items.AddRange(new object[] {
            "LKR",
            "USD"});
            this.cboUsd.Location = new System.Drawing.Point(3, 72);
            this.cboUsd.Name = "cboUsd";
            this.cboUsd.Size = new System.Drawing.Size(80, 24);
            this.cboUsd.TabIndex = 18;
            this.cboUsd.Text = "USD";
            this.cboUsd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Curency Converter";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboCon);
            this.panel2.Controls.Add(this.cboVal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtVal);
            this.panel2.Controls.Add(this.txtCon);
            this.panel2.Location = new System.Drawing.Point(603, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 152);
            this.panel2.TabIndex = 11;
            // 
            // cboCon
            // 
            this.cboCon.FormattingEnabled = true;
            this.cboCon.Items.AddRange(new object[] {
            "Miles",
            "Kilometers"});
            this.cboCon.Location = new System.Drawing.Point(3, 102);
            this.cboCon.Name = "cboCon";
            this.cboCon.Size = new System.Drawing.Size(80, 24);
            this.cboCon.TabIndex = 19;
            this.cboCon.Text = "Kilometers";
            this.cboCon.SelectedIndexChanged += new System.EventHandler(this.cboCon_SelectedIndexChanged);
            // 
            // cboVal
            // 
            this.cboVal.FormattingEnabled = true;
            this.cboVal.Items.AddRange(new object[] {
            "Miles",
            "Kilometers"});
            this.cboVal.Location = new System.Drawing.Point(3, 72);
            this.cboVal.Name = "cboVal";
            this.cboVal.Size = new System.Drawing.Size(80, 24);
            this.cboVal.TabIndex = 18;
            this.cboVal.Text = "Miles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Distance Converter";
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(104, 72);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(108, 22);
            this.txtVal.TabIndex = 8;
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(104, 104);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(108, 22);
            this.txtCon.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(40, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label5);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(3, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 37);
            this.panel3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "SriLanka Time";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(302, 610);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 60);
            this.panel4.TabIndex = 15;
            // 
            // Other
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 733);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "Other";
            this.Text = "Miles";
            this.Load += new System.EventHandler(this.Other_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtLKR;
        private System.Windows.Forms.TextBox txtANS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTOT;
        private System.Windows.Forms.ComboBox cboUsd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboCon;
        private System.Windows.Forms.ComboBox cboVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
    }
}