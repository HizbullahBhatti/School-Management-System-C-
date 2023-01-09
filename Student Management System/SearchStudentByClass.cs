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
    public partial class SearchStudentByClass : Form
    {
        public SearchStudentByClass()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Studentclass = txtSearchByClass.Text;
            addStudentDataContext context = new addStudentDataContext();

   
            var query = from records in context.addStudents
                        where records.StudentClass == Studentclass
                        select records;
            this.dataGridView.DataSource = query;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            addStudentDataContext student = new addStudentDataContext();

            var record = student.addStudents.Single(st => st.StudentClass == this.StudentClass);

            student.addStudents.DeleteOnSubmit(record);
            student.SubmitChanges();
            updateGridView();

            MessageBox.Show("Records are Deleted");
        }
        string StudentClass;
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentClass = this.dataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
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
