namespace School_Management_System.Custom_Controls
{
    partial class Subjects
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.gvRecord = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.butView = new ns1.BunifuThinButton2();
            this.butDelete = new ns1.BunifuThinButton2();
            this.butEdit = new ns1.BunifuThinButton2();
            this.butAdd = new ns1.BunifuThinButton2();
            this.gbxResultSearch = new System.Windows.Forms.GroupBox();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.butSearch = new ns1.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SNOGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CredithoursGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecord)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.gbxResultSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDetails
            // 
            this.gbxDetails.Controls.Add(this.gvRecord);
            this.gbxDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxDetails.Location = new System.Drawing.Point(0, 0);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(885, 266);
            this.gbxDetails.TabIndex = 22;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "Details";
            // 
            // gvRecord
            // 
            this.gvRecord.AllowUserToAddRows = false;
            this.gvRecord.AllowUserToDeleteRows = false;
            this.gvRecord.AllowUserToResizeColumns = false;
            this.gvRecord.AllowUserToResizeRows = false;
            this.gvRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvRecord.BackgroundColor = System.Drawing.Color.White;
            this.gvRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNOGV,
            this.SubjectNameGV,
            this.CredithoursGV,
            this.TeacherGV});
            this.gvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRecord.GridColor = System.Drawing.Color.DarkGray;
            this.gvRecord.Location = new System.Drawing.Point(3, 16);
            this.gvRecord.Name = "gvRecord";
            this.gvRecord.ReadOnly = true;
            this.gvRecord.RowHeadersVisible = false;
            this.gvRecord.Size = new System.Drawing.Size(879, 247);
            this.gvRecord.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbxSearch);
            this.panel1.Controls.Add(this.butView);
            this.panel1.Controls.Add(this.butDelete);
            this.panel1.Controls.Add(this.butEdit);
            this.panel1.Controls.Add(this.butAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 105);
            this.panel1.TabIndex = 32;
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Location = new System.Drawing.Point(538, 26);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(160, 56);
            this.gbxSearch.TabIndex = 30;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(6, 23);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(148, 20);
            this.tbxSearch.TabIndex = 5;
            // 
            // butView
            // 
            this.butView.ActiveBorderThickness = 1;
            this.butView.ActiveCornerRadius = 20;
            this.butView.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butView.ActiveForecolor = System.Drawing.Color.White;
            this.butView.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butView.BackColor = System.Drawing.Color.White;
            this.butView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butView.BackgroundImage")));
            this.butView.ButtonText = "View";
            this.butView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butView.IdleBorderThickness = 1;
            this.butView.IdleCornerRadius = 20;
            this.butView.IdleFillColor = System.Drawing.Color.White;
            this.butView.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butView.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butView.Location = new System.Drawing.Point(413, 26);
            this.butView.Margin = new System.Windows.Forms.Padding(5);
            this.butView.Name = "butView";
            this.butView.Size = new System.Drawing.Size(117, 56);
            this.butView.TabIndex = 26;
            this.butView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butView.Click += new System.EventHandler(this.butView_Click);
            // 
            // butDelete
            // 
            this.butDelete.ActiveBorderThickness = 1;
            this.butDelete.ActiveCornerRadius = 20;
            this.butDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butDelete.ActiveForecolor = System.Drawing.Color.White;
            this.butDelete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butDelete.BackColor = System.Drawing.Color.White;
            this.butDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butDelete.BackgroundImage")));
            this.butDelete.ButtonText = "Delete";
            this.butDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butDelete.IdleBorderThickness = 1;
            this.butDelete.IdleCornerRadius = 20;
            this.butDelete.IdleFillColor = System.Drawing.Color.White;
            this.butDelete.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butDelete.Location = new System.Drawing.Point(286, 26);
            this.butDelete.Margin = new System.Windows.Forms.Padding(5);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(117, 56);
            this.butDelete.TabIndex = 27;
            this.butDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butEdit
            // 
            this.butEdit.ActiveBorderThickness = 1;
            this.butEdit.ActiveCornerRadius = 20;
            this.butEdit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butEdit.ActiveForecolor = System.Drawing.Color.White;
            this.butEdit.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butEdit.BackColor = System.Drawing.Color.White;
            this.butEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butEdit.BackgroundImage")));
            this.butEdit.ButtonText = "Edit";
            this.butEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butEdit.IdleBorderThickness = 1;
            this.butEdit.IdleCornerRadius = 20;
            this.butEdit.IdleFillColor = System.Drawing.Color.White;
            this.butEdit.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butEdit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butEdit.Location = new System.Drawing.Point(159, 26);
            this.butEdit.Margin = new System.Windows.Forms.Padding(5);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(117, 56);
            this.butEdit.TabIndex = 28;
            this.butEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butAdd
            // 
            this.butAdd.ActiveBorderThickness = 1;
            this.butAdd.ActiveCornerRadius = 20;
            this.butAdd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butAdd.ActiveForecolor = System.Drawing.Color.White;
            this.butAdd.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butAdd.BackColor = System.Drawing.Color.White;
            this.butAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butAdd.BackgroundImage")));
            this.butAdd.ButtonText = "Add";
            this.butAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butAdd.IdleBorderThickness = 1;
            this.butAdd.IdleCornerRadius = 20;
            this.butAdd.IdleFillColor = System.Drawing.Color.White;
            this.butAdd.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butAdd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butAdd.Location = new System.Drawing.Point(32, 26);
            this.butAdd.Margin = new System.Windows.Forms.Padding(5);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(117, 56);
            this.butAdd.TabIndex = 29;
            this.butAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // gbxResultSearch
            // 
            this.gbxResultSearch.Controls.Add(this.cbxClass);
            this.gbxResultSearch.Controls.Add(this.butSearch);
            this.gbxResultSearch.Controls.Add(this.label2);
            this.gbxResultSearch.Controls.Add(this.cbxSection);
            this.gbxResultSearch.Controls.Add(this.label1);
            this.gbxResultSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbxResultSearch.Location = new System.Drawing.Point(581, 266);
            this.gbxResultSearch.Name = "gbxResultSearch";
            this.gbxResultSearch.Size = new System.Drawing.Size(304, 141);
            this.gbxResultSearch.TabIndex = 33;
            this.gbxResultSearch.TabStop = false;
            this.gbxResultSearch.Text = "Search";
            // 
            // cbxClass
            // 
            this.cbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(106, 19);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(137, 24);
            this.cbxClass.TabIndex = 26;
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
            this.butSearch.Location = new System.Drawing.Point(122, 79);
            this.butSearch.Margin = new System.Windows.Forms.Padding(5);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(91, 40);
            this.butSearch.TabIndex = 27;
            this.butSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Class:";
            // 
            // cbxSection
            // 
            this.cbxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSection.FormattingEnabled = true;
            this.cbxSection.Location = new System.Drawing.Point(106, 49);
            this.cbxSection.Name = "cbxSection";
            this.cbxSection.Size = new System.Drawing.Size(137, 24);
            this.cbxSection.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Section:";
            // 
            // SNOGV
            // 
            this.SNOGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SNOGV.HeaderText = "SNO";
            this.SNOGV.Name = "SNOGV";
            this.SNOGV.ReadOnly = true;
            this.SNOGV.Width = 55;
            // 
            // SubjectNameGV
            // 
            this.SubjectNameGV.HeaderText = "Subject Name";
            this.SubjectNameGV.Name = "SubjectNameGV";
            this.SubjectNameGV.ReadOnly = true;
            // 
            // CredithoursGV
            // 
            this.CredithoursGV.HeaderText = "Credit Hours";
            this.CredithoursGV.Name = "CredithoursGV";
            this.CredithoursGV.ReadOnly = true;
            // 
            // TeacherGV
            // 
            this.TeacherGV.HeaderText = "Teacher";
            this.TeacherGV.Name = "TeacherGV";
            this.TeacherGV.ReadOnly = true;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbxResultSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxDetails);
            this.Name = "Subjects";
            this.Size = new System.Drawing.Size(885, 512);
            this.gbxDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRecord)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxResultSearch.ResumeLayout(false);
            this.gbxResultSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.DataGridView gvRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private ns1.BunifuThinButton2 butView;
        private ns1.BunifuThinButton2 butDelete;
        private ns1.BunifuThinButton2 butEdit;
        private ns1.BunifuThinButton2 butAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNOGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CredithoursGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherGV;
        private System.Windows.Forms.GroupBox gbxResultSearch;
        private System.Windows.Forms.ComboBox cbxClass;
        private ns1.BunifuThinButton2 butSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSection;
        private System.Windows.Forms.Label label1;
    }
}
