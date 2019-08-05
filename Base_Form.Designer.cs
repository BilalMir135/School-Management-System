namespace School_Management_System
{
    partial class Base_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.butClose = new ns1.BunifuFlatButton();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 5);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 5);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(567, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 370);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 370);
            this.panel4.TabIndex = 3;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.butClose);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(5, 5);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(562, 39);
            this.panelControls.TabIndex = 6;
            // 
            // butClose
            // 
            this.butClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butClose.BackColor = System.Drawing.Color.White;
            this.butClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butClose.BorderRadius = 0;
            this.butClose.ButtonText = "X";
            this.butClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClose.DisabledColor = System.Drawing.Color.Gray;
            this.butClose.Dock = System.Windows.Forms.DockStyle.Right;
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
            this.butClose.Location = new System.Drawing.Point(515, 0);
            this.butClose.Name = "butClose";
            this.butClose.Normalcolor = System.Drawing.Color.White;
            this.butClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butClose.OnHoverTextColor = System.Drawing.Color.White;
            this.butClose.selected = false;
            this.butClose.Size = new System.Drawing.Size(47, 39);
            this.butClose.TabIndex = 4;
            this.butClose.Text = "X";
            this.butClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butClose.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.butClose.TextFont = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // Base_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 380);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Base_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelControls;
        private ns1.BunifuFlatButton butClose;
    }
}
