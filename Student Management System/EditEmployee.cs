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
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchByRollNumberEmployee = txtEmployee.Text;

            addEmployeeDataContext context = new addEmployeeDataContext();


            var query = from record in context.addEmployees select record;

            foreach (var item in query)
            {
                if (item.id == searchByRollNumberEmployee)
                {
                    this.txtID.Text = item.id;
                    txtFullName.Text = item.firstName + " " + item.lastName;
                    txtFathersName.Text = item.fathersName;
                    txtCaste.Text = item.caste;
                    txtReligion.Text = item.religion;
                    txtPhone.Text = item.phoneNumber;
                    txtSalary.Text = item.salary;
                    txtWork.Text = item.work;
                    txtGrade.Text = item.grade;
                    txtPlaceOfBirth.Text = item.placeOfBirth;
                    txtCNIC.Text = item.cnic;
                    txtNationality.Text = item.nationality;
                    txtAddress.Text = item.address;
                    
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string searchID = txtEmployee.Text;
            addEmployeeDataContext context = new addEmployeeDataContext();

            addEmployee updateRecord = new addEmployee();

            updateRecord = context.addEmployees.Single(records => records.id == searchID);

            updateRecord.firstName = txtFullName.Text;
            updateRecord.lastName = txtFullName.Text;
            updateRecord.fathersName = txtFathersName.Text;
            updateRecord.caste = txtCaste.Text;
            updateRecord.religion = txtReligion.Text;
           
            updateRecord.phoneNumber = txtPhone.Text;
            updateRecord.salary= txtSalary.Text;
            updateRecord.work = txtWork.Text;
            updateRecord.grade = txtGrade.Text;
            updateRecord.placeOfBirth = txtPlaceOfBirth.Text;
            updateRecord.cnic = txtCNIC.Text;
            updateRecord.nationality = txtNationality.Text;
            updateRecord.address = txtAddress.Text;

            context.SubmitChanges();
        }
    }
}
