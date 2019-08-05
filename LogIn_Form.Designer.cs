namespace School_Management_System
{
    partial class LogIn_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butLogin = new ns1.BunifuThinButton2();
            this.butClose = new ns1.BunifuFlatButton();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.tbxUserName = new ns1.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbxPassword = new ns1.BunifuMaterialTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 5);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School_Management_System.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(91, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // butLogin
            // 
            this.butLogin.ActiveBorderThickness = 1;
            this.butLogin.ActiveCornerRadius = 20;
            this.butLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.butLogin.ActiveForecolor = System.Drawing.Color.White;
            this.butLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.butLogin.BackColor = System.Drawing.Color.White;
            this.butLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butLogin.BackgroundImage")));
            this.butLogin.ButtonText = "Login";
            this.butLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLogin.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.ForeColor = System.Drawing.Color.White;
            this.butLogin.IdleBorderThickness = 1;
            this.butLogin.IdleCornerRadius = 20;
            this.butLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butLogin.IdleForecolor = System.Drawing.Color.White;
            this.butLogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butLogin.Location = new System.Drawing.Point(57, 407);
            this.butLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(298, 50);
            this.butLogin.TabIndex = 2;
            this.butLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // butClose
            // 
            this.butClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.butClose.BackColor = System.Drawing.Color.White;
            this.butClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butClose.BorderRadius = 0;
            this.butClose.ButtonText = "X";
            this.butClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClose.DisabledColor = System.Drawing.Color.Gray;
            this.butClose.Iconcolor = System.Drawing.Color.Transparent;
            this.butClose.Iconimage = null;
            this.butClose.Iconimage_right = null;
            this.butClose.Iconimage_right_Selected = null;
            this.butClose.Iconimage_Selected = null;
            this.butClose.IconMarginLeft = 0;
            this.butClose.IconMarginRight = 0;
            this.butClose.IconRightVisible = true;
            this.butClose.IconRightZoom = 0D;
            this.butClose.IconVisible = true;
            this.butClose.IconZoom = 90D;
            this.butClose.IsTab = false;
            this.butClose.Location = new System.Drawing.Point(377, 11);
            this.butClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butClose.Name = "butClose";
            this.butClose.Normalcolor = System.Drawing.Color.White;
            this.butClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butClose.OnHoverTextColor = System.Drawing.Color.White;
            this.butClose.selected = false;
            this.butClose.Size = new System.Drawing.Size(30, 22);
            this.butClose.TabIndex = 3;
            this.butClose.Text = "X";
            this.butClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butClose.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "-";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(339, 11);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(30, 22);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "-";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // tbxUserName
            // 
            this.tbxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUserName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.tbxUserName.HintForeColor = System.Drawing.Color.Empty;
            this.tbxUserName.HintText = "";
            this.tbxUserName.isPassword = false;
            this.tbxUserName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.tbxUserName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.tbxUserName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.tbxUserName.LineThickness = 4;
            this.tbxUserName.Location = new System.Drawing.Point(83, 238);
            this.tbxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(264, 44);
            this.tbxUserName.TabIndex = 0;
            this.tbxUserName.Text = "User Name";
            this.tbxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxUserName_KeyUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::School_Management_System.Properties.Resources.username;
            this.pictureBox2.Location = new System.Drawing.Point(30, 246);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.tbxPassword.HintForeColor = System.Drawing.Color.Empty;
            this.tbxPassword.HintText = "";
            this.tbxPassword.isPassword = false;
            this.tbxPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.tbxPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.tbxPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.tbxPassword.LineThickness = 4;
            this.tbxPassword.Location = new System.Drawing.Point(83, 312);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(5);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(264, 54);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.Text = "Password";
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPassword.OnValueChanged += new System.EventHandler(this.tbxPassword_OnValueChanged);
            this.tbxPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxUserName_KeyUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::School_Management_System.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(30, 327);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // LogIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 487);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuThinButton2 butLogin;
        private ns1.BunifuFlatButton butClose;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuMaterialTextbox tbxUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ns1.BunifuMaterialTextbox tbxPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

