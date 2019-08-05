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
    public partial class Results : UserControl
    {
        public Results()
        {
            InitializeComponent();
        }
        Result_class obj;
        private void panel_loading(UserControl sender)
        {
            panelBody.Controls.Clear();
            sender.Dock = DockStyle.Fill;
            panelBody.Controls.Add(sender);
        }
        private void butClassI_Click(object sender, EventArgs e)
        {
            obj = new Result_class();
            panel_loading(obj);
        }

    }
}
