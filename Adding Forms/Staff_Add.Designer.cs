namespace School_Management_System.Adding_Forms
{
    partial class Staff_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Add));
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCNIC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butAddform = new ns1.BunifuThinButton2();
            this.butSave = new ns1.BunifuThinButton2();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.butSearch = new ns1.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(124, 64);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(211, 23);
            this.tbxName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Last Name: ";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(125, 93);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(211, 23);
            this.tbxLastName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "CNIC: ";
            // 
            // tbxCNIC
            // 
            this.tbxCNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCNIC.Location = new System.Drawing.Point(124, 122);
            this.tbxCNIC.Name = "tbxCNIC";
            this.tbxCNIC.Size = new System.Drawing.Size(211, 23);
            this.tbxCNIC.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Phone: ";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(124, 151);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(211, 23);
            this.tbxPhone.TabIndex = 18;
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.cbxStatus.Location = new System.Drawing.Point(125, 267);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(211, 24);
            this.cbxStatus.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Role:";
            // 
            // cbxRole
            // 
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(125, 237);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(211, 24);
            this.cbxRole.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Address: ";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.Location = new System.Drawing.Point(124, 208);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(211, 23);
            this.tbxAddress.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Image:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Gender:";
            // 
            // cbxGender
            // 
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbxGender.Location = new System.Drawing.Point(124, 297);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(211, 24);
            this.cbxGender.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School_Management_System.Properties.Resources.default_image;
            this.pictureBox1.Location = new System.Drawing.Point(124, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // butAddform
            // 
            this.butAddform.ActiveBorderThickness = 1;
            this.butAddform.ActiveCornerRadius = 20;
            this.butAddform.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butAddform.ActiveForecolor = System.Drawing.Color.White;
            this.butAddform.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butAddform.BackColor = System.Drawing.Color.White;
            this.butAddform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butAddform.BackgroundImage")));
            this.butAddform.ButtonText = "Browse";
            this.butAddform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAddform.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butAddform.IdleBorderThickness = 1;
            this.butAddform.IdleCornerRadius = 20;
            this.butAddform.IdleFillColor = System.Drawing.Color.White;
            this.butAddform.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butAddform.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butAddform.Location = new System.Drawing.Point(240, 385);
            this.butAddform.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butAddform.Name = "butAddform";
            this.butAddform.Size = new System.Drawing.Size(71, 34);
            this.butAddform.TabIndex = 22;
            this.butAddform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butAddform.Click += new System.EventHandler(this.butAddform_Click);
            // 
            // butSave
            // 
            this.butSave.ActiveBorderThickness = 1;
            this.butSave.ActiveCornerRadius = 20;
            this.butSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSave.ActiveForecolor = System.Drawing.Color.White;
            this.butSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSave.BackColor = System.Drawing.Color.White;
            this.butSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSave.BackgroundImage")));
            this.butSave.ButtonText = "Save";
            this.butSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSave.IdleBorderThickness = 1;
            this.butSave.IdleCornerRadius = 20;
            this.butSave.IdleFillColor = System.Drawing.Color.White;
            this.butSave.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSave.Location = new System.Drawing.Point(479, 373);
            this.butSave.Margin = new System.Windows.Forms.Padding(5);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(117, 56);
            this.butSave.TabIndex = 23;
            this.butSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butSave.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "DOB: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 23);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // butSearch
            // 
            this.butSearch.ActiveBorderThickness = 1;
            this.butSearch.ActiveCornerRadius = 20;
            this.butSearch.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSearch.ActiveForecolor = System.Drawing.Color.White;
            this.butSearch.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSearch.BackColor = System.Drawing.Color.White;
            this.butSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSearch.BackgroundImage")));
            this.butSearch.ButtonText = "Search";
            this.butSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSearch.IdleBorderThickness = 1;
            this.butSearch.IdleCornerRadius = 20;
            this.butSearch.IdleFillColor = System.Drawing.Color.White;
            this.butSearch.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSearch.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butSearch.Location = new System.Drawing.Point(352, 373);
            this.butSearch.Margin = new System.Windows.Forms.Padding(5);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(117, 56);
            this.butSearch.TabIndex = 25;
            this.butSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butSearch.Visible = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // Staff_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 443);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butAddform);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxRole);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCNIC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Name = "Staff_Add";
            this.Text = "School Management System";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbxName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbxLastName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbxCNIC, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbxPhone, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tbxAddress, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.cbxStatus, 0);
            this.Controls.SetChildIndex(this.cbxGender, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cbxRole, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.butAddform, 0);
            this.Controls.SetChildIndex(this.butSave, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.butSearch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCNIC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxGender;
        private ns1.BunifuThinButton2 butAddform;
        private ns1.BunifuThinButton2 butSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ns1.BunifuThinButton2 butSearch;
    }
}