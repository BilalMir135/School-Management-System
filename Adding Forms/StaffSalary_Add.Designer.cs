namespace School_Management_System.Adding_Forms
{
    partial class StaffSalary_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffSalary_Add));
            this.butSave = new ns1.BunifuThinButton2();
            this.cbxTeacher = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCharges = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxBonus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.butSearch = new ns1.BunifuThinButton2();
            this.SuspendLayout();
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
            this.butSave.Location = new System.Drawing.Point(470, 342);
            this.butSave.Margin = new System.Windows.Forms.Padding(5);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(117, 56);
            this.butSave.TabIndex = 34;
            this.butSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // cbxTeacher
            // 
            this.cbxTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTeacher.FormattingEnabled = true;
            this.cbxTeacher.Location = new System.Drawing.Point(219, 70);
            this.cbxTeacher.Name = "cbxTeacher";
            this.cbxTeacher.Size = new System.Drawing.Size(211, 24);
            this.cbxTeacher.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Name:";
            // 
            // tbxCharges
            // 
            this.tbxCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCharges.Location = new System.Drawing.Point(219, 271);
            this.tbxCharges.Name = "tbxCharges";
            this.tbxCharges.Size = new System.Drawing.Size(211, 23);
            this.tbxCharges.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Charges: ";
            // 
            // tbxBonus
            // 
            this.tbxBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBonus.Location = new System.Drawing.Point(219, 231);
            this.tbxBonus.Name = "tbxBonus";
            this.tbxBonus.Size = new System.Drawing.Size(211, 23);
            this.tbxBonus.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bonus: ";
            // 
            // tbxSalary
            // 
            this.tbxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSalary.Location = new System.Drawing.Point(219, 191);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(211, 23);
            this.tbxSalary.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Salary: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Status: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Role: ";
            // 
            // cbxRole
            // 
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(219, 111);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(211, 24);
            this.cbxRole.TabIndex = 33;
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(219, 151);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(211, 24);
            this.cbxStatus.TabIndex = 33;
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
            this.butSearch.Location = new System.Drawing.Point(343, 342);
            this.butSearch.Margin = new System.Windows.Forms.Padding(5);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(117, 56);
            this.butSearch.TabIndex = 35;
            this.butSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butSearch.Visible = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // StaffSalary_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 431);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.cbxRole);
            this.Controls.Add(this.cbxTeacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCharges);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxBonus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "StaffSalary_Add";
            this.Text = "School Management System";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbxSalary, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbxBonus, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tbxCharges, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbxTeacher, 0);
            this.Controls.SetChildIndex(this.cbxRole, 0);
            this.Controls.SetChildIndex(this.cbxStatus, 0);
            this.Controls.SetChildIndex(this.butSave, 0);
            this.Controls.SetChildIndex(this.butSearch, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuThinButton2 butSave;
        private System.Windows.Forms.ComboBox cbxTeacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCharges;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxBonus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.ComboBox cbxStatus;
        private ns1.BunifuThinButton2 butSearch;
    }
}