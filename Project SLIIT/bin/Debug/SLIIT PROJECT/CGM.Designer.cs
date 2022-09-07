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
            this.btnTips = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTravel
            // 
            this.btnTravel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTravel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTravel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTravel.Font = new System.Drawing.Font("Stencil Std", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTravel.ForeColor = System.Drawing.Color.White;
            this.btnTravel.Location = new System.Drawing.Point(575, 33);
            this.btnTravel.Name = "btnTravel";
            this.btnTravel.Size = new System.Drawing.Size(123, 40);
            this.btnTravel.TabIndex = 1;
            this.btnTravel.Text = "Travel";
            this.btnTravel.UseVisualStyleBackColor = false;
            this.btnTravel.Click += new System.EventHandler(this.btnTravel_Click);
            // 
            // btnTips
            // 
            this.btnTips.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTips.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTips.Font = new System.Drawing.Font("Stencil Std", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTips.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTips.Location = new System.Drawing.Point(575, 134);
            this.btnTips.Name = "btnTips";
            this.btnTips.Size = new System.Drawing.Size(123, 41);
            this.btnTips.TabIndex = 4;
            this.btnTips.Text = "Tips";
            this.btnTips.UseVisualStyleBackColor = false;
            this.btnTips.Click += new System.EventHandler(this.btnRdRules_Click);
            // 
            // btnOther
            // 
            this.btnOther.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOther.Font = new System.Drawing.Font("Stencil Std", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.Location = new System.Drawing.Point(575, 219);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(123, 46);
            this.btnOther.TabIndex = 3;
            this.btnOther.Text = "Other";
            this.btnOther.UseVisualStyleBackColor = false;
            this.btnOther.Click += new System.EventHandler(this.btnTips_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil Std", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(575, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Diary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTips);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.btnTravel);
            this.Font = new System.Drawing.Font("Papyrus", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ceylon Guider";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTravel;
        private System.Windows.Forms.Button btnTips;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button button1;
    }
}

