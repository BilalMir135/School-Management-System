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
    public partial class Staff_Add : Base_Form
    {
        public Staff_Add(string operation)
        {
            InitializeComponent();
            butSave.ButtonText = operation;
            if (operation == "Delete" || operation == "Search")
                butAddform.Visible = false;
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (butSave.ButtonText == "Add")
            {
                add();
                Custom_Message_Box message = new Custom_Message_Box("New member's record has added", "Record Added", "Information");
                message.ShowDialog();
            }
            else if (butSave.ButtonText == "Update")
            {
                update();
                Custom_Message_Box message = new Custom_Message_Box("Member record has updated", "Record Updated", "Information");
                message.ShowDialog();
            }
            else if (butSave.ButtonText == "Delete")
            {
                delete();
                Custom_Message_Box message = new Custom_Message_Box("Member record has deleted", "Record Deleted", "Information");
                message.ShowDialog();
            }
            else
            {
                search();
            }
        }

        private void butAddform_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                Image i = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = i;
            }
            
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            search();
        }
    }
    
}
