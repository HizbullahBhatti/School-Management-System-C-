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
    public partial class EditTeacher : Form
    {
        public EditTeacher()
        {
            InitializeComponent();
        }
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string searchID = txtTeacher.Text;
            addTeacherDataContext context = new addTeacherDataContext();

            addTeacher updateRecord = new addTeacher();

            updateRecord = context.addTeachers.Single(records => records.id == searchID);

            updateRecord.firstName = txtFirstName.Text;
            updateRecord.lastName = txtLastName.Text;
            updateRecord.fathersName = txtFatherName.Text;
            updateRecord.password = txtPassword.Text;
            updateRecord.caste = txtCaste.Text;
            updateRecord.religion = txtReligion.Text;
            updateRecord.subject = txtSubject.Text;
            updateRecord.salary = txtSalary.Text;
            updateRecord.grade = txtGrade.Text;
            updateRecord.subjectKey = txtSubjectkey.Text;
            updateRecord.placeOfBirth = txtPlaceOfBirth.Text;
            updateRecord.cnic = txtCNIC.Text;
            updateRecord.nationality = txtNationality.Text;
            updateRecord.address = txtAddress.Text;

            context.SubmitChanges();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchID = txtTeacher.Text;

            addTeacherDataContext context = new addTeacherDataContext();


            var query = from record in context.addTeachers select record;

            foreach (var item in query)
            {
                if (item.id == searchID)
                {
                    this.txtId.Text = item.id;
                    txtFirstName.Text = item.firstName;
                    txtLastName.Text = item.lastName;
                    txtPassword.Text = item.password;
                    txtFatherName.Text = item.fathersName;
                    txtCaste.Text = item.caste;
                    txtReligion.Text = item.religion;
                    txtSubject.Text = item.subject;
                    txtPhone.Text = item.phoneNumber;
                    txtSalary.Text = item.salary;
                    txtGrade.Text = item.grade;
                    txtSubjectkey.Text = item.subjectKey;
                    txtPlaceOfBirth.Text = item.placeOfBirth;
                    txtCNIC.Text = item.cnic;
                    txtNationality.Text = item.nationality;
                    txtAddress.Text = item.address;
                }
            }
        }
    }
}