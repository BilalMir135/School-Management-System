namespace School_Management_System
{
    partial class Custom_Message_Box
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Custom_Message_Box));
            this.title_Bar1 = new School_Management_System.Custom_Controls.Title_Bar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butOK = new ns1.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_Bar1
            // 
            this.title_Bar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.title_Bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_Bar1.Location = new System.Drawing.Point(0, 0);
            this.title_Bar1.MainForm = this;
            this.title_Bar1.Name = "title_Bar1";
            this.title_Bar1.Size = new System.Drawing.Size(535, 28);
            this.title_Bar1.TabIndex = 0;
            this.title_Bar1.Title = "Message Box";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(105, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 82);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Enter a valid password";
            // 
            // butOK
            // 
            this.butOK.ActiveBorderThickness = 1;
            this.butOK.ActiveCornerRadius = 20;
            this.butOK.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butOK.ActiveForecolor = System.Drawing.Color.White;
            this.butOK.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butOK.BackColor = System.Drawing.Color.White;
            this.butOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butOK.BackgroundImage")));
            this.butOK.ButtonText = "OK";
            this.butOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butOK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butOK.IdleBorderThickness = 1;
            this.butOK.IdleCornerRadius = 20;
            this.butOK.IdleFillColor = System.Drawing.Color.White;
            this.butOK.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butOK.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butOK.Location = new System.Drawing.Point(396, 111);
            this.butOK.Margin = new System.Windows.Forms.Padding(5);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(125, 48);
            this.butOK.TabIndex = 3;
            this.butOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // Custom_Message_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 173);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title_Bar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 738);
            this.Name = "Custom_Message_Box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom_Controls.Title_Bar title_Bar1;
        private ns1.BunifuThinButton2 butOK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}