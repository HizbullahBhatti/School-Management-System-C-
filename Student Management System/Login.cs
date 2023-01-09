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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginDataContext context = new loginDataContext();

            string username = this.textBox1.Text;
            string password = this.textBox2.Text;

            var query = from detail in context.logins select detail;

            foreach (var value in query)
            {

                if ((value.username.Equals(username)) && (value.password.Equals(password)))
                {
                    this.lblStatus.Text = "Logged In Succesfully";

                    dashboard obj = new dashboard();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    this.lblStatus.Text = "Username & Password is Incorrect";
                }
            }
        }
    }
}
