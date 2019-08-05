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
    public partial class Accounts : UserControl
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void butFeeStructure_Click(object sender, EventArgs e)
        {
            butStaffSalary.Textcolor = Color.FromArgb(229, 27, 35);
            butFeeStructure.Textcolor = Color.White;
            FeeStructure obj = new FeeStructure();
            obj.Dock = DockStyle.Fill;
            panelBody.Controls.Clear();
            panelBody.Controls.Add(obj);
        }

        private void butStaffSalary_Click(object sender, EventArgs e)
        {
            butFeeStructure.Textcolor = Color.FromArgb(229, 27, 35);
            butStaffSalary.Textcolor = Color.White;
            StaffSalary obj = new StaffSalary();
            obj.Dock = DockStyle.Fill;
            panelBody.Controls.Clear();
            panelBody.Controls.Add(obj);
        }
    }
}
