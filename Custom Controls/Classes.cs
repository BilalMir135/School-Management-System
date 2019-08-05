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
    public partial class Classes : UserControl
    {
        public Classes()
        {
            InitializeComponent();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Adding_Forms.Class_Add add = new Adding_Forms.Class_Add("Add");
            add.ShowDialog();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            Adding_Forms.Class_Add add = new Adding_Forms.Class_Add("Update");
            add.ShowDialog();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            Adding_Forms.Class_Add add = new Adding_Forms.Class_Add("Delete");
            add.ShowDialog();
        }

        private void butView_Click(object sender, EventArgs e)
        {
            Adding_Forms.Class_Add add = new Adding_Forms.Class_Add("Search");
            add.ShowDialog();
        }
    }
}
