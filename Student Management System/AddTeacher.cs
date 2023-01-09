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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            addTeacherDataContext context = new addTeacherDataContext();

            addTeacher obj = new addTeacher();

            obj.id = txtID.Text;
            obj.firstName = txtFirstName.Text;
            obj.lastName = txtLastName.Text;
            obj.password = txtPassword.Text;
            obj.fathersName = txtFathersName.Text;
            obj.caste = txtCaste.Text;
            obj.religion = txtReligion.Text;
            obj.gender = txtGender.Text;
            obj.dob = txtdob.Text;
            obj.phoneNumber = txtPhoneNumber.Text;
            obj.salary = txtSalary.Text;
            obj.placeOfBirth = txtPlaceOfBirth.Text;
            obj.cnic = txtCNIC.Text;
            obj.nationality = txtNationality.Text;
            obj.address = txtAddress.Text;

            context.addTeachers.InsertOnSubmit(obj);
            context.SubmitChanges();

            MessageBox.Show("Records Added Successfully ...!");


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
