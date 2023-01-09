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
    public partial class SearchStudentByName : Form
    {
        public SearchStudentByName()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearchByName.Text;
            addStudentDataContext context = new addStudentDataContext();

   
            var query = from records in context.addStudents
                        where records.first_name == name
                        select records;
            this.dataGridView.DataSource = query;

        }
        public void updateGridView()
        {
            addStudentDataContext context = new addStudentDataContext();
            var query = from records in context.addStudents
                        select records;
            this.dataGridView.DataSource = query;
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            

            addStudentDataContext student = new addStudentDataContext();

            var record = student.addStudents.Single(st => st.first_name == name);

            student.addStudents.DeleteOnSubmit(record);
            student.SubmitChanges();

            updateGridView();

            
        }

        string name;

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name = this.dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

            

        }

        private void SearchStudentByName_Load(object sender, EventArgs e)
        {

        }
    }
}
