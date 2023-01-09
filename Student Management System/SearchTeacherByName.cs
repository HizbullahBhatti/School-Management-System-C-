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
    public partial class SearchTeacherByName : Form
    {
        public SearchTeacherByName()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearchTeacherByName.Text;
            addTeacherDataContext context = new addTeacherDataContext();


            var query = from records in context.addTeachers
                        where records.firstName == name
                        select records;
            this.dataGridView.DataSource = query;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            addTeacherDataContext student = new addTeacherDataContext();

            var record = student.addTeachers.Single(st => st.firstName == this.teacherName);

            student.addTeachers.DeleteOnSubmit(record);
            student.SubmitChanges();
            updateGridView();

            MessageBox.Show("Records are Deleted");
        }
        string teacherName;
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            teacherName = this.dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
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
