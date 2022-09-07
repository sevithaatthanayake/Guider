namespace Project_SLIIT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTravel = new System.Windows.Forms.Button();
            this.btnRdRules = new System.Windows.Forms.Button();
            this.btnTips = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTravel
            // 
            this.btnTravel.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnTravel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTravel.ForeColor = System.Drawing.Color.Black;
            this.btnTravel.Location = new System.Drawing.Point(556, 111);
            this.btnTravel.Name = "btnTravel";
            this.btnTravel.Size = new System.Drawing.Size(123, 40);
            this.btnTravel.TabIndex = 1;
            this.btnTravel.Text = "Travel";
            this.btnTravel.UseVisualStyleBackColor = false;
            this.btnTravel.Click += new System.EventHandler(this.btnTravel_Click);
            // 
            // btnRdRules
            // 
            this.btnRdRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRdRules.Location = new System.Drawing.Point(556, 272);
            this.btnRdRules.Name = "btnRdRules";
            this.btnRdRules.Size = new System.Drawing.Size(123, 41);
            this.btnRdRules.TabIndex = 4;
            this.btnRdRules.Text = "Road Rules";
            this.btnRdRules.UseVisualStyleBackColor = true;
            this.btnRdRules.Click += new System.EventHandler(this.btnRdRules_Click);
            // 
            // btnTips
            // 
            this.btnTips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTips.Location = new System.Drawing.Point(556, 191);
            this.btnTips.Name = "btnTips";
            this.btnTips.Size = new System.Drawing.Size(123, 46);
            this.btnTips.TabIndex = 3;
            this.btnTips.Text = "Tips";
            this.btnTips.UseVisualStyleBackColor = true;
            this.btnTips.Click += new System.EventHandler(this.btnTips_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 408);
            this.Controls.Add(this.btnRdRules);
            this.Controls.Add(this.btnTips);
            this.Controls.Add(this.btnTravel);
            this.Font = new System.Drawing.Font("Papyrus", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Travel Ceylon";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTravel;
        private System.Windows.Forms.Button btnRdRules;
        private System.Windows.Forms.Button btnTips;
    }
}

