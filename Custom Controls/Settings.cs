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
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        Custom_Message_Box message;
        private void butSaveUsername_Click(object sender, EventArgs e)
        {
            if (tbxOldUserName.Text == "")
            {
                message = new Custom_Message_Box("Please enter old user name", "Error", "Error");
                message.ShowDialog();
            }
            else if (tbxNewUserName.Text == "")
            {
                message = new Custom_Message_Box("Please enter new user name", "Error", "Error");
                message.ShowDialog();
            }
            else if (tbxOldUserName.Text != Properties.Settings.Default.UserName)
            {
                message = new Custom_Message_Box("The old user name you entered is wrong", "Invalid User Name", "Warning");
                message.ShowDialog();
                tbxOldUserName.Focus();
            }
            else
            {
                Properties.Settings.Default.UserName = tbxNewUserName.Text;
                Properties.Settings.Default.Save();
                message = new Custom_Message_Box("User name updated", "Update Successful", "Information");
                message.ShowDialog();
                tbxOldUserName.Clear();
                tbxNewUserName.Clear();
            }
        }

        private void butSavePassword_Click(object sender, EventArgs e)
        {
            if (tbxOldPassword.Text == "")
            {
                message = new Custom_Message_Box("Please enter old password", "Error", "Error");
                message.ShowDialog();
            }
            else if (tbxNewPassword.Text == "")
            {
                message = new Custom_Message_Box("Please enter new password", "Error", "Error");
                message.ShowDialog();
            }
            else if (tbxOldPassword.Text != Properties.Settings.Default.Password)
            {
                message = new Custom_Message_Box("The old password you entered is wrong", "Invalid Password", "Warning");
                message.ShowDialog();
                tbxOldPassword.Focus();
            }
            else
            {
                Properties.Settings.Default.Password = tbxNewPassword.Text;
                Properties.Settings.Default.Save();
                message = new Custom_Message_Box("Password updated", "Update Successful", "Information");
                message.ShowDialog();
                tbxOldPassword.Clear();
                tbxNewPassword.Clear();
            }
        }
    }
}
