namespace School_Management_System.Adding_Forms
{
    partial class ClassTimming_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassTimming_Add));
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.butSave = new ns1.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTeacher = new System.Windows.Forms.ComboBox();
            this.butSearch = new ns1.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // cbxDay
            // 
            this.cbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbxDay.Location = new System.Drawing.Point(172, 198);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(211, 24);
            this.cbxDay.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Day:";
            // 
            // tbxSubject
            // 
            this.tbxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSubject.Location = new System.Drawing.Point(172, 82);
            this.tbxSubject.Name = "tbxSubject";
            this.tbxSubject.Size = new System.Drawing.Size(211, 23);
            this.tbxSubject.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Subject: ";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = " ";
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(172, 140);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.ShowUpDown = true;
            this.dtpFrom.Size = new System.Drawing.Size(211, 23);
            this.dtpFrom.TabIndex = 22;
            this.dtpFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFrom_KeyDown);
            this.dtpFrom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpFrom_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "From: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "To: ";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = " ";
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(172, 169);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.ShowUpDown = true;
            this.dtpTo.Size = new System.Drawing.Size(211, 23);
            this.dtpTo.TabIndex = 22;
            this.dtpTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFrom_KeyDown);
            this.dtpTo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpFrom_MouseDown);
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
            this.butSave.Location = new System.Drawing.Point(423, 300);
            this.butSave.Margin = new System.Windows.Forms.Padding(5);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(117, 56);
            this.butSave.TabIndex = 23;
            this.butSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butSave.Click += new System.EventHandler(this.butAddform_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Teacher: ";
            // 
            // cbxTeacher
            // 
            this.cbxTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTeacher.FormattingEnabled = true;
            this.cbxTeacher.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbxTeacher.Location = new System.Drawing.Point(172, 110);
            this.cbxTeacher.Name = "cbxTeacher";
            this.cbxTeacher.Size = new System.Drawing.Size(211, 24);
            this.cbxTeacher.TabIndex = 21;
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
            this.butSearch.Location = new System.Drawing.Point(296, 300);
            this.butSearch.Margin = new System.Windows.Forms.Padding(5);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(117, 56);
            this.butSearch.TabIndex = 24;
            this.butSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butSearch.Visible = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // ClassTimming_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 380);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.cbxTeacher);
            this.Controls.Add(this.cbxDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ClassTimming_Add";
            this.Text = "School Management System";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbxSubject, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbxDay, 0);
            this.Controls.SetChildIndex(this.cbxTeacher, 0);
            this.Controls.SetChildIndex(this.dtpFrom, 0);
            this.Controls.SetChildIndex(this.dtpTo, 0);
            this.Controls.SetChildIndex(this.butSave, 0);
            this.Controls.SetChildIndex(this.butSearch, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private ns1.BunifuThinButton2 butSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTeacher;
        private ns1.BunifuThinButton2 butSearch;
    }
}