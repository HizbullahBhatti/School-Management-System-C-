﻿using System;
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
    public partial class EditData : Form
    {
        public EditData()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btneditStudent_Click(object sender, EventArgs e)
        {
            EditStudent obj = new EditStudent();
            obj.Show();
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            EditTeacher obj = new EditTeacher();
            obj.Show();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            EditEmployee obj = new EditEmployee();
            obj.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dashboard obj = new dashboard();
            obj.Show();
        }
    }
}
