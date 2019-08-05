namespace School_Management_System
{
    partial class Role_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Role_Add));
            this.butSave = new ns1.BunifuThinButton2();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.butSave.Location = new System.Drawing.Point(337, 250);
            this.butSave.Margin = new System.Windows.Forms.Padding(5);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(117, 56);
            this.butSave.TabIndex = 18;
            this.butSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butSave.Click += new System.EventHandler(this.butAddform_Click);
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.cbxStatus.Location = new System.Drawing.Point(139, 142);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(206, 24);
            this.cbxStatus.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Status:";
            // 
            // tbxRole
            // 
            this.tbxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRole.Location = new System.Drawing.Point(134, 88);
            this.tbxRole.Name = "tbxRole";
            this.tbxRole.Size = new System.Drawing.Size(211, 23);
            this.tbxRole.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Role: ";
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
            this.butSearch.Location = new System.Drawing.Point(210, 250);
            this.butSearch.Margin = new System.Windows.Forms.Padding(5);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(117, 56);
            this.butSearch.TabIndex = 19;
            this.butSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butSearch.Visible = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // Role_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 335);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxRole);
            this.Controls.Add(this.label1);
            this.Name = "Role_Add";
            this.Text = "School Management System";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbxRole, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbxStatus, 0);
            this.Controls.SetChildIndex(this.butSave, 0);
            this.Controls.SetChildIndex(this.butSearch, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuThinButton2 butSave;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRole;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuThinButton2 butSearch;
    }
}