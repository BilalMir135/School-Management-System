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
    public partial class Result_Add : Base_Form
    {
        public Result_Add(string operation)
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

        private void butSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (butSave.ButtonText == "Add")
            {
                add();
                Custom_Message_Box message = new Custom_Message_Box("Result has added into the record", "Record Added", "Information");
                message.ShowDialog();
            }
            else if (butSave.ButtonText == "Update")
            {
                update();
                Custom_Message_Box message = new Custom_Message_Box("Result has updated into the record", "Record Updated", "Information");
                message.ShowDialog();
            }
            else if (butSave.ButtonText == "Delete")
            {
                delete();
                Custom_Message_Box message = new Custom_Message_Box("Result has deleted from the record", "Record Deleted", "Information");
                message.ShowDialog();
            }
            else
            {
                search();
            }
        }
    }
}
