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
    public partial class SearchEmployeeByWork : Form
    {
        public SearchEmployeeByWork()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string work = txtSearchEmployeeByWork.Text;
            addEmployeeDataContext context = new addEmployeeDataContext();


            var query = from records in context.addEmployees
                        where records.work == work
                        select records;
            this.dataGridView.DataSource = query;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            addEmployeeDataContext student = new addEmployeeDataContext();

            var record = student.addEmployees.Single(st => st.work == this.work);

            student.addEmployees.DeleteOnSubmit(record);
            student.SubmitChanges();
            updateGridView();

            MessageBox.Show("Records are Deleted");
        }
        string work;
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            work = this.dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
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
