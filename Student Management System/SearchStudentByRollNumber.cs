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
    public partial class SearchStudentByRollNumber : Form
    {
        public SearchStudentByRollNumber()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string rollNumber = txtSearchRollNumber.Text;
            addStudentDataContext context = new addStudentDataContext();

            addStudent obj = new addStudent();

            var query = from records in context.addStudents
                        where records.roll_number == rollNumber
                        select records;
            this.dataGridView.DataSource = query;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addStudentDataContext student = new addStudentDataContext();

            var record = student.addStudents.Single(st => st.roll_number == id);

            student.addStudents.DeleteOnSubmit(record);
            student.SubmitChanges();
            updateGridView();


            MessageBox.Show("Records are Deleted");
        }
        string id;
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = this.dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        public void updateGridView()
        {
            addStudentDataContext context = new addStudentDataContext();
            var query = from records in context.addStudents
                        select records;
            this.dataGridView.DataSource = query;

        }
    }
}
