
namespace Student_Management_System
{
    partial class SearchTeacher
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
            this.btnSearchByTeacherSubject = new System.Windows.Forms.Button();
            this.btnSearchByTeacherName = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchByTeacherSubject
            // 
            this.btnSearchByTeacherSubject.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearchByTeacherSubject.BackgroundImage = global::Student_Management_System.Properties.Resources.searchteachersubject;
            this.btnSearchByTeacherSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchByTeacherSubject.FlatAppearance.BorderSize = 0;
            this.btnSearchByTeacherSubject.Location = new System.Drawing.Point(262, 194);
            this.btnSearchByTeacherSubject.Name = "btnSearchByTeacherSubject";
            this.btnSearchByTeacherSubject.Size = new System.Drawing.Size(118, 107);
            this.btnSearchByTeacherSubject.TabIndex = 1;
            this.btnSearchByTeacherSubject.UseVisualStyleBackColor = false;
            this.btnSearchByTeacherSubject.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearchByTeacherName
            // 
            this.btnSearchByTeacherName.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearchByTeacherName.BackgroundImage = global::Student_Management_System.Properties.Resources.searchteachername;
            this.btnSearchByTeacherName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchByTeacherName.FlatAppearance.BorderSize = 0;
            this.btnSearchByTeacherName.Location = new System.Drawing.Point(509, 194);
            this.btnSearchByTeacherName.Name = "btnSearchByTeacherName";
            this.btnSearchByTeacherName.Size = new System.Drawing.Size(118, 107);
            this.btnSearchByTeacherName.TabIndex = 2;
            this.btnSearchByTeacherName.UseVisualStyleBackColor = false;
            this.btnSearchByTeacherName.Click += new System.EventHandler(this.button3_Click);
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
            this.label1.Size = new System.Drawing.Size(264, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search Teacher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search by\r\n  Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 38);
            this.label4.TabIndex = 10;
            this.label4.Text = "Search by \r\n  Name";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(736, 389);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 36);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SearchTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Management_System.Properties.Resources.dashboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 503);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnSearchByTeacherName);
            this.Controls.Add(this.btnSearchByTeacherSubject);
            this.Name = "SearchTeacher";
            this.Text = "Search Teacher";
            this.Load += new System.EventHandler(this.SearchTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchByTeacherSubject;
        private System.Windows.Forms.Button btnSearchByTeacherName;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
    }
}