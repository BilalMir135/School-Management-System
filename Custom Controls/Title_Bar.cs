using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Custom_Controls
{
    public partial class Title_Bar : UserControl
    {
        Form container;
        public Title_Bar()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }
        public string Title { get { return label1.Text; } set { label1.Text = value; } }
        public Form MainForm { get { return container; } set { container = value;} }
        private void butClose_Click(object sender, EventArgs e)
        {
            MainForm.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MainForm.WindowState = FormWindowState.Minimized;
        }

        bool isMove = false;
        int x, y;
        private void Title_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            x = e.X;
            y = e.Y;
        }
        private void Title_Bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove && e.Button == MouseButtons.Left)
            {
                MainForm.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }
        private void Title_Bar_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }
    }
}
