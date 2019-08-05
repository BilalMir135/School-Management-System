using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Base_Form : Form
    {
        public Base_Form()
        {
            InitializeComponent();
        }

        public virtual void butClose_Click(object sender, EventArgs e)
        {

        }

        int x;
        int y;
        bool isMove = false;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            isMove = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
             if (isMove && e.Button == MouseButtons.Left)
             {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
             }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }
    }
}
