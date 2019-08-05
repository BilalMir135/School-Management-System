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
    public partial class Subjects : UserControl
    {
        public Subjects()
        {
            InitializeComponent();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Adding_Forms.Subject_Add obj = new Adding_Forms.Subject_Add("Add");
            obj.ShowDialog();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            Adding_Forms.Subject_Add obj = new Adding_Forms.Subject_Add("Update");
            obj.ShowDialog();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            Adding_Forms.Subject_Add obj = new Adding_Forms.Subject_Add("Delete");
            obj.ShowDialog();
        }

        private void butView_Click(object sender, EventArgs e)
        {
            Adding_Forms.Subject_Add obj = new Adding_Forms.Subject_Add("Search");
            obj.ShowDialog();
        }
    }
}
