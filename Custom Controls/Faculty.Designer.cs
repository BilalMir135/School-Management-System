namespace School_Management_System.Custom_Controls
{
    partial class Faculty
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
            this.butRoles = new ns1.BunifuFlatButton();
            this.butStaff = new ns1.BunifuFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butRoles
            // 
            this.butRoles.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butRoles.BackColor = System.Drawing.Color.White;
            this.butRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butRoles.BorderRadius = 0;
            this.butRoles.ButtonText = "Roles";
            this.butRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRoles.DisabledColor = System.Drawing.Color.Gray;
            this.butRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butRoles.Iconcolor = System.Drawing.Color.Transparent;
            this.butRoles.Iconimage = null;
            this.butRoles.Iconimage_right = null;
            this.butRoles.Iconimage_right_Selected = null;
            this.butRoles.Iconimage_Selected = null;
            this.butRoles.IconMarginLeft = 0;
            this.butRoles.IconMarginRight = 0;
            this.butRoles.IconRightVisible = true;
            this.butRoles.IconRightZoom = 0D;
            this.butRoles.IconVisible = true;
            this.butRoles.IconZoom = 90D;
            this.butRoles.IsTab = true;
            this.butRoles.Location = new System.Drawing.Point(445, 3);
            this.butRoles.Name = "butRoles";
            this.butRoles.Normalcolor = System.Drawing.Color.White;
            this.butRoles.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butRoles.OnHoverTextColor = System.Drawing.Color.White;
            this.butRoles.selected = false;
            this.butRoles.Size = new System.Drawing.Size(437, 57);
            this.butRoles.TabIndex = 4;
            this.butRoles.Text = "Roles";
            this.butRoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butRoles.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butRoles.TextFont = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRoles.Click += new System.EventHandler(this.butRoles_Click);
            // 
            // butStaff
            // 
            this.butStaff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butStaff.BackColor = System.Drawing.Color.White;
            this.butStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butStaff.BorderRadius = 0;
            this.butStaff.ButtonText = "Staff";
            this.butStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butStaff.DisabledColor = System.Drawing.Color.Gray;
            this.butStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butStaff.ForeColor = System.Drawing.Color.Black;
            this.butStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.butStaff.Iconimage = null;
            this.butStaff.Iconimage_right = null;
            this.butStaff.Iconimage_right_Selected = null;
            this.butStaff.Iconimage_Selected = null;
            this.butStaff.IconMarginLeft = 0;
            this.butStaff.IconMarginRight = 0;
            this.butStaff.IconRightVisible = true;
            this.butStaff.IconRightZoom = 0D;
            this.butStaff.IconVisible = true;
            this.butStaff.IconZoom = 90D;
            this.butStaff.IsTab = true;
            this.butStaff.Location = new System.Drawing.Point(3, 3);
            this.butStaff.Name = "butStaff";
            this.butStaff.Normalcolor = System.Drawing.Color.White;
            this.butStaff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butStaff.OnHoverTextColor = System.Drawing.Color.White;
            this.butStaff.selected = false;
            this.butStaff.Size = new System.Drawing.Size(436, 57);
            this.butStaff.TabIndex = 3;
            this.butStaff.Text = "Staff";
            this.butStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butStaff.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butStaff.TextFont = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStaff.Click += new System.EventHandler(this.butStaff_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.butRoles, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.butStaff, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(885, 63);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 63);
            this.panel1.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 63);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(885, 449);
            this.panelBody.TabIndex = 1;
            // 
            // Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panel1);
            this.Name = "Faculty";
            this.Size = new System.Drawing.Size(885, 512);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ns1.BunifuFlatButton butRoles;
        private ns1.BunifuFlatButton butStaff;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBody;
    }
}
