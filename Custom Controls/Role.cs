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
    public partial class Role : UserControl
    {
        public Role()
        {
            InitializeComponent();
            gvRecord.DataSource = data();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Role_Add obj = new Role_Add("Add");
            obj.ShowDialog();
        }
        private DataTable data()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SNO", typeof(System.Int32));
            dt.Columns.Add("Role", typeof(System.String));
            dt.Columns.Add("Status", typeof(System.String));
            dt.Rows.Add(1, "Teacher", "Active");
            dt.Rows.Add(2, "Codinator", "Active");
            dt.Rows.Add(3, "Sub-Teacher", "In-active");
            dt.Rows.Add(4, "Principle", "Active");
            dt.Rows.Add(5, "Accountant", "Active");
            dt.Rows.Add(6, "Prade Instructor", "Active");
            return dt;
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            Role_Add obj = new Role_Add("Update");
            obj.ShowDialog();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            Role_Add obj = new Role_Add("Delete");
            obj.ShowDialog();
        }

        private void butView_Click(object sender, EventArgs e)
        {
            Role_Add obj = new Role_Add("Search");
            obj.ShowDialog();
        }
    }
}
