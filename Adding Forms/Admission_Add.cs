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
    public partial class Admission_Add : Base_Form
    {
        public Admission_Add(string operation)
        {
            InitializeComponent();
            butSave.ButtonText = operation;
            if (operation == "Delete" || operation == "Search")
                butBrowse.Visible = false;
            if (operation == "Delete")
                butSearch.Visible = true;
        }

        //int sno;
        //string enrollment;
        //string name, last_name, fathers_name, mothers_name, father_profession_mother_profession, nationality, address, gender, religion, _class, phone, Email, father_phone;

        private void butSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        //DateTime dob;
        //Image pic;

        public void add() { }
        public void update() { }
        public void delete() { }
        public void search() { }
        private void butBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                Image i = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = i;
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (butSave.ButtonText == "Add")
            {
                add();
                Custom_Message_Box message = new Custom_Message_Box("Record of new student is added", "Record Added", "Information");
                message.ShowDialog();
            }
            else if (butSave.ButtonText == "Update")
            {
                update();
                Custom_Message_Box message = new Custom_Message_Box("Record of student is updated", "Record Updated", "Information");
                message.ShowDialog();
            }
            else if (butSave.ButtonText == "Delete")
            {
                delete();
                Custom_Message_Box message = new Custom_Message_Box("Record of student is deleted", "Record Deleted", "Information");
                message.ShowDialog();
            } 
            else
            {
                search();
            }  
        }

        public override void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
