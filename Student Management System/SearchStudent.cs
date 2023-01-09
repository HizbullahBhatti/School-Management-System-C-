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
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchStudentByRollNumber obj = new SearchStudentByRollNumber();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchStudentByName obj = new SearchStudentByName();
            obj.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchStudentByClass obj = new SearchStudentByClass();
            obj.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Search obj = new Search();
            obj.Show();
            this.Hide();
        }
    }
}
