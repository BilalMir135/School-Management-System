using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Adding_Forms
{
    public partial class ClassTimming_Add : Base_Form
    {
        public ClassTimming_Add(string operation)
        {
            InitializeComponent();
            butSave.ButtonText = operation;
            if (operation == "Delete")
                butSearch.Visible = true;
        }
        public void add() { }
        public void update() { }
        public void delete() { }
        public void search() { }
        public override void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAddform_Click(object sender, EventArgs e)
        {          
            if (butSave.ButtonText == "Add")
            {
                add();
                Custom_Message_Box message = new Custom_Message_Box("Class timming is added into the record", "Record Added", "Information");
                message.ShowDialog();
            }
            else if (butSave.ButtonText == "Update")
            {
                update();
                Custom_Message_Box message = new Custom_Message_Box("Class timming is updated into the record", "Record Updated", "Information");
                message.ShowDialog();
            }
            else if (butSave.ButtonText == "Delete")
            {
                delete();
                Custom_Message_Box message = new Custom_Message_Box("Class timming is deleted from the record", "Record Deleted", "Information");
                message.ShowDialog();
            }
            else
            {
                search();
            }
        }

        private void datetimeformat(object sender, string format)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            dtp.CustomFormat = format;         //HH:mm 24hr formate
        }

        private void dtpFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                datetimeformat(sender, " ");
            }
        }

        private void dtpFrom_MouseDown(object sender, MouseEventArgs e)
        {
            datetimeformat(sender, "HH:mm");
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}
