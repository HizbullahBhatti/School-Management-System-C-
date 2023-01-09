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
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }
        public string rollNumber;
        private void SearchStudent_Click(object sender, EventArgs e)
        {
            rollNumber = this.txtStudent.Text;
            addStudentDataContext context = new addStudentDataContext();
            

            var query = from record in context.addStudents select record;

            foreach (var item in query)
            {
                if (item.roll_number == rollNumber)
                {
                    txtRollNumber.Text = item.roll_number;
                    txtFirstName.Text = item.first_name;
                    txtLastName.Text = item.lastname;
                    txtPassword.Text = item.password;
                    txtFathersName.Text = item.fathers_name;
                    txtCaste.Text = item.caste;
                    txtReligion.Text = item.religion;
                    txtGuardiansNo.Text = item.guardians_no;
                    txtClass.Text = item.StudentClass;
                    txtPlaceOfBirth.Text = item.place_of_birth;
                    txtGuardianCNIC.Text = item.guardians_CNIC;
                    txtNationality.Text = item.nationality;
                    txtAddress.Text = item.address;
                }

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            addStudentDataContext context = new addStudentDataContext();

            addStudent updateRecord = new addStudent();

            updateRecord = context.addStudents.Single(records => records.roll_number == rollNumber);

            updateRecord.first_name = txtFirstName.Text;
            updateRecord.lastname = txtLastName.Text;
            updateRecord.fathers_name = txtFathersName.Text;
            updateRecord.password = txtPassword.Text;
            updateRecord.caste = txtCaste.Text;
            updateRecord.religion = txtReligion.Text;
            updateRecord.guardians_no = txtGuardiansNo.Text;
            updateRecord.StudentClass = txtClass.Text;
            updateRecord.place_of_birth = txtPlaceOfBirth.Text;
            updateRecord.guardians_CNIC = txtGuardianCNIC.Text;
            updateRecord.nationality = txtNationality.Text;
            updateRecord.address = txtAddress.Text;

            context.SubmitChanges();

        }
    }
}
