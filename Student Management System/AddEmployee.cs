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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            addEmployeeDataContext context = new addEmployeeDataContext();

            addEmployee obj = new addEmployee();

            obj.id = txtID.Text;
            obj.firstName = txtFullName.Text;
            obj.lastName = txtFullName.Text;
            obj.fathersName = txtFathersName.Text;
            obj.caste = txtCaste.Text;
            obj.religion = txtReligion.Text;
            obj.gender = txtGender.Text;
            obj.dob = txtdob.Text;
            obj.work = txtWork.Text;
            obj.grade = txtGrade.Text;
            obj.phoneNumber = txtPhoneNumber.Text;
            obj.salary = txtSalary.Text;
            obj.placeOfBirth = txtPlaceOfBirth.Text;
            obj.cnic = txtCNIC.Text;
            obj.nationality = txtNationality.Text;
            obj.address = txtAddress.Text;

            context.addEmployees.InsertOnSubmit(obj);
            context.SubmitChanges();

            MessageBox.Show("Employee Records Added Successfully ....!");


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
