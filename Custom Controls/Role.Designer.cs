namespace School_Management_System.Custom_Controls
{
    partial class Role
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Role));
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.gvRecord = new System.Windows.Forms.DataGridView();
            this.butView = new ns1.BunifuThinButton2();
            this.butDelete = new ns1.BunifuThinButton2();
            this.butEdit = new ns1.BunifuThinButton2();
            this.butAdd = new ns1.BunifuThinButton2();
            this.gbxSearch.SuspendLayout();
            this.gbxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Location = new System.Drawing.Point(516, 381);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(160, 56);
            this.gbxSearch.TabIndex = 13;
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
            // gbxDetails
            // 
            this.gbxDetails.Controls.Add(this.gvRecord);
            this.gbxDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxDetails.Location = new System.Drawing.Point(0, 0);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(832, 357);
            this.gbxDetails.TabIndex = 7;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvRecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRecord.GridColor = System.Drawing.Color.DarkGray;
            this.gvRecord.Location = new System.Drawing.Point(3, 16);
            this.gvRecord.Name = "gvRecord";
            this.gvRecord.ReadOnly = true;
            this.gvRecord.RowHeadersVisible = false;
            this.gvRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRecord.Size = new System.Drawing.Size(826, 338);
            this.gvRecord.TabIndex = 0;
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
            this.butView.Location = new System.Drawing.Point(391, 381);
            this.butView.Margin = new System.Windows.Forms.Padding(5);
            this.butView.Name = "butView";
            this.butView.Size = new System.Drawing.Size(117, 56);
            this.butView.TabIndex = 8;
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
            this.butDelete.Location = new System.Drawing.Point(264, 381);
            this.butDelete.Margin = new System.Windows.Forms.Padding(5);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(117, 56);
            this.butDelete.TabIndex = 10;
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
            this.butEdit.Location = new System.Drawing.Point(137, 381);
            this.butEdit.Margin = new System.Windows.Forms.Padding(5);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(117, 56);
            this.butEdit.TabIndex = 11;
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
            this.butAdd.Location = new System.Drawing.Point(10, 381);
            this.butAdd.Margin = new System.Windows.Forms.Padding(5);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(117, 56);
            this.butAdd.TabIndex = 12;
            this.butAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.butView);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.gbxDetails);
            this.Name = "Role";
            this.Size = new System.Drawing.Size(832, 491);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private ns1.BunifuThinButton2 butView;
        private ns1.BunifuThinButton2 butDelete;
        private ns1.BunifuThinButton2 butEdit;
        private ns1.BunifuThinButton2 butAdd;
        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.DataGridView gvRecord;
    }
}
