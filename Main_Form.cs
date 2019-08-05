using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_Management_System.Custom_Controls;

namespace School_Management_System
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMaximize_MouseHover(object sender, EventArgs e)
        {
            pbxMaximize.Image = Properties.Resources.hover_maximize;
        }

        private void pbxMaximize_MouseLeave(object sender, EventArgs e)
        {
            pbxMaximize.Image = Properties.Resources.maximize;
        }

        private void butMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbxMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void panel_loading(UserControl sender)
        {
            panelBody.Controls.Clear();
            sender.Dock = DockStyle.Fill;
            panelBody.Controls.Add(sender);
        }
        private void butStudent_Click(object sender, EventArgs e)
        {
            Admission obj = new Admission();
            panel_loading(obj);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
           Home_Screen obj = new Home_Screen();
           panel_loading(obj);
        }

        private void butFaculty_Click(object sender, EventArgs e)
        {
            Faculty obj = new Faculty();
            panel_loading(obj);
        }

        #region Screen Moving
        int x, y;
        bool isMove = false;
        private void panelDesign_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y; isMove = true;
        }

        private void panelDesign_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMove && e.Button == MouseButtons.Left)
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }
        private void panelDesign_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }
        #endregion

        private void butAccounts_Click(object sender, EventArgs e)
        {
            Accounts obj = new Accounts();
            panel_loading(obj);
        }
        private void butlogout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.login = true;
            // this.Close();
            this.Hide();
            LogIn_Form form = new LogIn_Form();
            form.Show();
        }

        private void butSetting_Click(object sender, EventArgs e)
        {
            Settings obj = new Settings();
            panel_loading(obj);
        }

        private void butClassTiming_Click(object sender, EventArgs e)
        {
            ClassTimming obj = new ClassTimming();
            panel_loading(obj);
        }

        private void butResults_Click(object sender, EventArgs e)
        {
            Results obj = new Results();
            panel_loading(obj);
        }

        private void butSubjects_Click(object sender, EventArgs e)
        {
            Subjects obj = new Subjects();
            panel_loading(obj);
        }

        private void butClasses_Click(object sender, EventArgs e)
        {
            Classes obj = new Classes();
            panel_loading(obj);
        }
    }
}
