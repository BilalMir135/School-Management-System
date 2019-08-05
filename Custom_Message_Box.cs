using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Custom_Message_Box : Form
    {
        public Custom_Message_Box(string message, string title, string icon)
        {
            InitializeComponent();

            textBox1.Text = message;
            title_Bar1.Title = title;
            if (icon == "Error")
            {
                pictureBox1.Image = Properties.Resources.Error;
            }
            else if (icon == "Information")
            {
                pictureBox1.Image = Properties.Resources.Information;
            }
            else if (icon == "Warning")
            {
                pictureBox1.Image = Properties.Resources.Warning;
            }
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
