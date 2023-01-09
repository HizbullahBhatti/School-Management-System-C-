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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchStudent obj = new SearchStudent();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchTeacher obj = new SearchTeacher();
            obj.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchEmployee obj = new SearchEmployee();
            obj.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dashboard obj = new dashboard();
            obj.Show();
            this.Hide();
        }
    }
}
