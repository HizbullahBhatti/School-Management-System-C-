using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            addStudentDataContext context = new addStudentDataContext();

            addStudent obj = new addStudent();

            obj.roll_number = txtRollNumber.Text;
            obj.first_name = txtFirstName.Text;
            obj.lastname = txtLastName.Text;
            obj.password = txtPassword.Text;
            obj.fathers_name = txtFathersName.Text;
            obj.caste = txtCaste.Text;
            obj.religion = txtReligion.Text;
            obj.gender = txtGender.Text;
            obj.dob = dob.Text;
            obj.guardians_no = txtGuardianNo.Text;
            obj.StudentClass = txtClass.Text;
            obj.place_of_birth = txtPlaceOfBirth.Text;
            obj.guardians_CNIC = txtGuardianCNIC.Text;
            obj.nationality = txtNationality.Text;
            obj.address = txtAddress.Text;

            context.addStudents.InsertOnSubmit(obj);
            context.SubmitChanges();

            MessageBox.Show("Record Submitted Successfully ... !");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
