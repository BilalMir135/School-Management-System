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
    public partial class Default_Setting : Base_Form
    {
        public Default_Setting()
        {
            InitializeComponent();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            Custom_Message_Box message;
            if (tbxUserName.Text == "")
            {
                message = new Custom_Message_Box("Please enter user name ", "Error", "Error");
                message.ShowDialog();
                tbxUserName.Focus();
            }
            else if (tbxPassword.Text == "")
            {
                message = new Custom_Message_Box("Please enter password ", "Error", "Error");
                message.ShowDialog();
                tbxPassword.Focus();
            }
            else
            {
                Properties.Settings.Default.UserName = tbxUserName.Text;
                Properties.Settings.Default.Password = tbxPassword.Text;
                Properties.Settings.Default.Default_Settings = true;
                Properties.Settings.Default.Save();
                message = new Custom_Message_Box("User Name and password is stored for your software", "Setting Complete", "Information");
                message.ShowDialog();
                this.Hide();
                LogIn_Form form = new LogIn_Form();
                form.Show();
            }              
        }
        public override void butClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
