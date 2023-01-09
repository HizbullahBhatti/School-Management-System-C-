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
    public partial class SearchTeacherBySubject : Form
    {
        public SearchTeacherBySubject()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string subject = txtSearchTeacherBySubject.Text;
            addTeacherDataContext context = new addTeacherDataContext();

   
            var query = from records in context.addTeachers
                        where records.subject == subject
                        select records;
            this.dataGridView.DataSource = query;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            addTeacherDataContext student = new addTeacherDataContext();

            var record = student.addTeachers.Single(st => st.subject == this.subject);

            student.addTeachers.DeleteOnSubmit(record);
            student.SubmitChanges();
            updateGridView();

            MessageBox.Show("Records are Deleted");
        }
        string subject;
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            subject = this.dataGridView.Rows[e.RowIndex].Cells[16].Value.ToString();
        }

        public void updateGridView()
        {
            addEmployeeDataContext context = new addEmployeeDataContext();
            var query = from records in context.addEmployees
                        select records;
            this.dataGridView.DataSource = query;
        }
    }
}
