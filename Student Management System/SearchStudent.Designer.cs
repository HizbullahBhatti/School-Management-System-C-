
namespace Student_Management_System
{
    partial class SearchStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearchByRollNumber = new System.Windows.Forms.Button();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.btnSearchbyClass = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchByRollNumber
            // 
            this.btnSearchByRollNumber.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearchByRollNumber.BackgroundImage = global::Student_Management_System.Properties.Resources.searchstudentbyRollNumber;
            this.btnSearchByRollNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchByRollNumber.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchByRollNumber.FlatAppearance.BorderSize = 0;
            this.btnSearchByRollNumber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnSearchByRollNumber.Location = new System.Drawing.Point(178, 194);
            this.btnSearchByRollNumber.Name = "btnSearchByRollNumber";
            this.btnSearchByRollNumber.Size = new System.Drawing.Size(118, 107);
            this.btnSearchByRollNumber.TabIndex = 0;
            this.btnSearchByRollNumber.UseVisualStyleBackColor = false;
            this.btnSearchByRollNumber.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearchByName.BackgroundImage = global::Student_Management_System.Properties.Resources.searchStudentByName;
            this.btnSearchByName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchByName.FlatAppearance.BorderSize = 0;
            this.btnSearchByName.Location = new System.Drawing.Point(400, 194);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(118, 107);
            this.btnSearchByName.TabIndex = 1;
            this.btnSearchByName.UseVisualStyleBackColor = false;
            this.btnSearchByName.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearchbyClass
            // 
            this.btnSearchbyClass.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearchbyClass.BackgroundImage = global::Student_Management_System.Properties.Resources.searchstudentclass;
            this.btnSearchbyClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchbyClass.FlatAppearance.BorderSize = 0;
            this.btnSearchbyClass.Location = new System.Drawing.Point(612, 194);
            this.btnSearchbyClass.Name = "btnSearchbyClass";
            this.btnSearchbyClass.Size = new System.Drawing.Size(118, 107);
            this.btnSearchbyClass.TabIndex = 2;
            this.btnSearchbyClass.UseVisualStyleBackColor = false;
            this.btnSearchbyClass.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLogOut.BackgroundImage = global::Student_Management_System.Properties.Resources.logout;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.Location = new System.Drawing.Point(79, 403);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(115, 43);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Management_System.Properties.Resources.Untitled_SSX1;
            this.pictureBox1.Location = new System.Drawing.Point(79, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = global::Student_Management_System.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(659, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search by\r\nRoll Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search by\r\n   Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(631, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 38);
            this.label4.TabIndex = 10;
            this.label4.Text = "Search by \r\n    Class";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(715, 410);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 36);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Management_System.Properties.Resources.dashboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 503);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnSearchbyClass);
            this.Controls.Add(this.btnSearchByName);
            this.Controls.Add(this.btnSearchByRollNumber);
            this.Name = "SearchStudent";
            this.Text = "Search Student";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchByRollNumber;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.Button btnSearchbyClass;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
    }
}