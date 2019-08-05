namespace School_Management_System.Custom_Controls
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxUserName = new System.Windows.Forms.GroupBox();
            this.gbxPassword = new System.Windows.Forms.GroupBox();
            this.tbxOldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxOldUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butSaveUsername = new ns1.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNewUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.butSavePassword = new ns1.BunifuThinButton2();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxUserName.SuspendLayout();
            this.gbxPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbxPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbxUserName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(885, 512);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbxUserName
            // 
            this.gbxUserName.Controls.Add(this.butSaveUsername);
            this.gbxUserName.Controls.Add(this.tbxNewUserName);
            this.gbxUserName.Controls.Add(this.label3);
            this.gbxUserName.Controls.Add(this.tbxOldUserName);
            this.gbxUserName.Controls.Add(this.label1);
            this.gbxUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxUserName.Location = new System.Drawing.Point(3, 3);
            this.gbxUserName.Name = "gbxUserName";
            this.gbxUserName.Size = new System.Drawing.Size(879, 250);
            this.gbxUserName.TabIndex = 0;
            this.gbxUserName.TabStop = false;
            this.gbxUserName.Text = "UserName";
            // 
            // gbxPassword
            // 
            this.gbxPassword.Controls.Add(this.butSavePassword);
            this.gbxPassword.Controls.Add(this.tbxNewPassword);
            this.gbxPassword.Controls.Add(this.label4);
            this.gbxPassword.Controls.Add(this.tbxOldPassword);
            this.gbxPassword.Controls.Add(this.label2);
            this.gbxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxPassword.Location = new System.Drawing.Point(3, 259);
            this.gbxPassword.Name = "gbxPassword";
            this.gbxPassword.Size = new System.Drawing.Size(879, 250);
            this.gbxPassword.TabIndex = 1;
            this.gbxPassword.TabStop = false;
            this.gbxPassword.Text = "Password";
            // 
            // tbxOldPassword
            // 
            this.tbxOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOldPassword.Location = new System.Drawing.Point(382, 48);
            this.tbxOldPassword.Name = "tbxOldPassword";
            this.tbxOldPassword.PasswordChar = '*';
            this.tbxOldPassword.Size = new System.Drawing.Size(211, 23);
            this.tbxOldPassword.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Old Password: ";
            // 
            // tbxOldUserName
            // 
            this.tbxOldUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOldUserName.Location = new System.Drawing.Point(393, 45);
            this.tbxOldUserName.Name = "tbxOldUserName";
            this.tbxOldUserName.Size = new System.Drawing.Size(211, 23);
            this.tbxOldUserName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Old User Name: ";
            // 
            // butSaveUsername
            // 
            this.butSaveUsername.ActiveBorderThickness = 1;
            this.butSaveUsername.ActiveCornerRadius = 20;
            this.butSaveUsername.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSaveUsername.ActiveForecolor = System.Drawing.Color.White;
            this.butSaveUsername.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSaveUsername.BackColor = System.Drawing.Color.White;
            this.butSaveUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSaveUsername.BackgroundImage")));
            this.butSaveUsername.ButtonText = "Save";
            this.butSaveUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSaveUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSaveUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSaveUsername.IdleBorderThickness = 1;
            this.butSaveUsername.IdleCornerRadius = 20;
            this.butSaveUsername.IdleFillColor = System.Drawing.Color.White;
            this.butSaveUsername.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSaveUsername.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSaveUsername.Location = new System.Drawing.Point(420, 149);
            this.butSaveUsername.Margin = new System.Windows.Forms.Padding(5);
            this.butSaveUsername.Name = "butSaveUsername";
            this.butSaveUsername.Size = new System.Drawing.Size(117, 56);
            this.butSaveUsername.TabIndex = 24;
            this.butSaveUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butSaveUsername.Click += new System.EventHandler(this.butSaveUsername_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "New User Name: ";
            // 
            // tbxNewUserName
            // 
            this.tbxNewUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewUserName.Location = new System.Drawing.Point(393, 89);
            this.tbxNewUserName.Name = "tbxNewUserName";
            this.tbxNewUserName.Size = new System.Drawing.Size(211, 23);
            this.tbxNewUserName.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "New Password: ";
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewPassword.Location = new System.Drawing.Point(382, 92);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.PasswordChar = '*';
            this.tbxNewPassword.Size = new System.Drawing.Size(211, 23);
            this.tbxNewPassword.TabIndex = 22;
            // 
            // butSavePassword
            // 
            this.butSavePassword.ActiveBorderThickness = 1;
            this.butSavePassword.ActiveCornerRadius = 20;
            this.butSavePassword.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSavePassword.ActiveForecolor = System.Drawing.Color.White;
            this.butSavePassword.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSavePassword.BackColor = System.Drawing.Color.White;
            this.butSavePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSavePassword.BackgroundImage")));
            this.butSavePassword.ButtonText = "Save";
            this.butSavePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSavePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSavePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSavePassword.IdleBorderThickness = 1;
            this.butSavePassword.IdleCornerRadius = 20;
            this.butSavePassword.IdleFillColor = System.Drawing.Color.White;
            this.butSavePassword.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSavePassword.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSavePassword.Location = new System.Drawing.Point(420, 152);
            this.butSavePassword.Margin = new System.Windows.Forms.Padding(5);
            this.butSavePassword.Name = "butSavePassword";
            this.butSavePassword.Size = new System.Drawing.Size(117, 56);
            this.butSavePassword.TabIndex = 24;
            this.butSavePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butSavePassword.Click += new System.EventHandler(this.butSavePassword_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(885, 512);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbxUserName.ResumeLayout(false);
            this.gbxUserName.PerformLayout();
            this.gbxPassword.ResumeLayout(false);
            this.gbxPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbxPassword;
        private System.Windows.Forms.GroupBox gbxUserName;
        private ns1.BunifuThinButton2 butSaveUsername;
        private System.Windows.Forms.TextBox tbxOldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxOldUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNewUserName;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuThinButton2 butSavePassword;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.Label label4;
    }
}
