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
    public partial class Result_class : UserControl
    {
        public Result_class()
        {
            InitializeComponent();
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            Adding_Forms.Result_Add obj = new Adding_Forms.Result_Add("Add");
            obj.ShowDialog();
           
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            Adding_Forms.Result_Add obj = new Adding_Forms.Result_Add("Update");
            obj.ShowDialog();

        }

        private void butView_Click(object sender, EventArgs e)
        {
            Adding_Forms.Result_Add obj = new Adding_Forms.Result_Add("Search");
            obj.ShowDialog();

        }

        private void butDelete_Click_1(object sender, EventArgs e)
        {
            Adding_Forms.Result_Add obj = new Adding_Forms.Result_Add("Delete");
            obj.ShowDialog();

        }

        private void cbxOverallResut_OnChange(object sender, EventArgs e)
        {
            if (cbxSubject.Enabled)
                cbxSubject.Enabled = false;
            else
                cbxSubject.Enabled = true;
        }
    }
}
