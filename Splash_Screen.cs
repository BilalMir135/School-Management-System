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
    public partial class Splash_Screen : Form
    {
        int valuep = 0;
        public Splash_Screen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            valuep += 2;
            bunifuProgressBar1.Value = valuep;
            if (bunifuProgressBar1.Value == 100)
                timer1.Stop();
        }
    }
}
