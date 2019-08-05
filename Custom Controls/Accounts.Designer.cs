namespace School_Management_System.Custom_Controls
{
    partial class Accounts
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butStaffSalary = new ns1.BunifuFlatButton();
            this.butFeeStructure = new ns1.BunifuFlatButton();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.tableLayoutPanel1);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(885, 63);
            this.panelButtons.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.butStaffSalary, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.butFeeStructure, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(885, 63);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // butStaffSalary
            // 
            this.butStaffSalary.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butStaffSalary.BackColor = System.Drawing.Color.White;
            this.butStaffSalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butStaffSalary.BorderRadius = 0;
            this.butStaffSalary.ButtonText = "Staff Salary";
            this.butStaffSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butStaffSalary.DisabledColor = System.Drawing.Color.Gray;
            this.butStaffSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butStaffSalary.Iconcolor = System.Drawing.Color.Transparent;
            this.butStaffSalary.Iconimage = null;
            this.butStaffSalary.Iconimage_right = null;
            this.butStaffSalary.Iconimage_right_Selected = null;
            this.butStaffSalary.Iconimage_Selected = null;
            this.butStaffSalary.IconMarginLeft = 0;
            this.butStaffSalary.IconMarginRight = 0;
            this.butStaffSalary.IconRightVisible = true;
            this.butStaffSalary.IconRightZoom = 0D;
            this.butStaffSalary.IconVisible = true;
            this.butStaffSalary.IconZoom = 90D;
            this.butStaffSalary.IsTab = true;
            this.butStaffSalary.Location = new System.Drawing.Point(445, 3);
            this.butStaffSalary.Name = "butStaffSalary";
            this.butStaffSalary.Normalcolor = System.Drawing.Color.White;
            this.butStaffSalary.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butStaffSalary.OnHoverTextColor = System.Drawing.Color.White;
            this.butStaffSalary.selected = false;
            this.butStaffSalary.Size = new System.Drawing.Size(437, 57);
            this.butStaffSalary.TabIndex = 4;
            this.butStaffSalary.Text = "Staff Salary";
            this.butStaffSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butStaffSalary.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butStaffSalary.TextFont = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStaffSalary.Click += new System.EventHandler(this.butStaffSalary_Click);
            // 
            // butFeeStructure
            // 
            this.butFeeStructure.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butFeeStructure.BackColor = System.Drawing.Color.White;
            this.butFeeStructure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butFeeStructure.BorderRadius = 0;
            this.butFeeStructure.ButtonText = "Fee Structure";
            this.butFeeStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butFeeStructure.DisabledColor = System.Drawing.Color.Gray;
            this.butFeeStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butFeeStructure.ForeColor = System.Drawing.Color.Black;
            this.butFeeStructure.Iconcolor = System.Drawing.Color.Transparent;
            this.butFeeStructure.Iconimage = null;
            this.butFeeStructure.Iconimage_right = null;
            this.butFeeStructure.Iconimage_right_Selected = null;
            this.butFeeStructure.Iconimage_Selected = null;
            this.butFeeStructure.IconMarginLeft = 0;
            this.butFeeStructure.IconMarginRight = 0;
            this.butFeeStructure.IconRightVisible = true;
            this.butFeeStructure.IconRightZoom = 0D;
            this.butFeeStructure.IconVisible = true;
            this.butFeeStructure.IconZoom = 90D;
            this.butFeeStructure.IsTab = true;
            this.butFeeStructure.Location = new System.Drawing.Point(3, 3);
            this.butFeeStructure.Name = "butFeeStructure";
            this.butFeeStructure.Normalcolor = System.Drawing.Color.White;
            this.butFeeStructure.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butFeeStructure.OnHoverTextColor = System.Drawing.Color.White;
            this.butFeeStructure.selected = false;
            this.butFeeStructure.Size = new System.Drawing.Size(436, 57);
            this.butFeeStructure.TabIndex = 3;
            this.butFeeStructure.Text = "Fee Structure";
            this.butFeeStructure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butFeeStructure.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butFeeStructure.TextFont = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFeeStructure.Click += new System.EventHandler(this.butFeeStructure_Click);
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 63);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(885, 449);
            this.panelBody.TabIndex = 2;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelButtons);
            this.Name = "Accounts";
            this.Size = new System.Drawing.Size(885, 512);
            this.panelButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ns1.BunifuFlatButton butStaffSalary;
        private ns1.BunifuFlatButton butFeeStructure;
        private System.Windows.Forms.Panel panelBody;
    }
}
