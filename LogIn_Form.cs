using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class LogIn_Form : Form
    {      
        public LogIn_Form()
        {                        
            if (!Properties.Settings.Default.login)
             {
                Thread t = new Thread(new ThreadStart(startform));
                t.Start();
                Thread.Sleep(5000);
                InitializeComponent();
                t.Abort();
             }
             else
             {
                InitializeComponent();
                tbxUserName.Text = Properties.Settings.Default.UserName;
             }
        }          
        

        public void startform()
        {
            Application.Run(new Splash_Screen());
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void tbxPassword_OnValueChanged(object sender, EventArgs e)
        {
            tbxPassword.isPassword = true;
        }

        #region Move Form
        bool isMove = false;
        int x, y;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            x = e.X;
            y = e.Y;
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
        #endregion

        private void tbxUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            if(tbxUserName.Text!=Properties.Settings.Default.UserName)
            {
                Custom_Message_Box messagebox = new Custom_Message_Box("Please enter correct user name", "Invalid User Name", "Error");
                messagebox.ShowDialog();
                tbxUserName.Focus();
            }
            else if(tbxPassword.Text!=Properties.Settings.Default.Password)
            {
                Custom_Message_Box messagebox = new Custom_Message_Box("Please enter correct password", "Invalid Password", "Error");
                messagebox.ShowDialog();
                tbxPassword.Focus();
            }
            else
            {
                Main_Form form = new Main_Form();
                this.Hide();
                form.Show();
            }
            
        }
    }
}
