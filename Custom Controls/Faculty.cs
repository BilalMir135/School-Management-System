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
    public partial class Faculty : UserControl
    {
        public Faculty()
        {
            InitializeComponent();
        }

        private void butRoles_Click(object sender, EventArgs e)
        {
            butStaff.Textcolor = Color.FromArgb(229, 27, 35);
            butRoles.Textcolor = Color.White;
            Role obj = new Role();
            obj.Dock = DockStyle.Fill;
            panelBody.Controls.Clear();
            panelBody.Controls.Add(obj);
        }

        private void butStaff_Click(object sender, EventArgs e)
        {
            butRoles.Textcolor = Color.FromArgb(229, 27, 35);
            butStaff.Textcolor = Color.White;
            Staff obj = new Staff();
            obj.Dock = DockStyle.Fill;
            panelBody.Controls.Clear();
            panelBody.Controls.Add(obj);
        }
    }
}
