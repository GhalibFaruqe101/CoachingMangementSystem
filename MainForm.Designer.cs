using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CoachingMangementSystem
{
    partial class MainForm: Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.AddTeacher_btn = new System.Windows.Forms.Button();
            this.AddStudent_btn = new System.Windows.Forms.Button();
            this.L_ad = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addStudentForm1 = new CoachingMangementSystem.AddStudentForm();
            this.addTeachersForm1 = new CoachingMangementSystem.AddTeachersForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 30);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1440, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "School Management System | Main Form";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.AddTeacher_btn);
            this.panel2.Controls.Add(this.AddStudent_btn);
            this.panel2.Controls.Add(this.L_ad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 708);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.White;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.Black;
            this.logout_btn.Location = new System.Drawing.Point(28, 646);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(223, 49);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // AddTeacher_btn
            // 
            this.AddTeacher_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTeacher_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddTeacher_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddTeacher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeacher_btn.ForeColor = System.Drawing.Color.White;
            this.AddTeacher_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTeacher_btn.Location = new System.Drawing.Point(16, 327);
            this.AddTeacher_btn.Margin = new System.Windows.Forms.Padding(4);
            this.AddTeacher_btn.Name = "AddTeacher_btn";
            this.AddTeacher_btn.Size = new System.Drawing.Size(267, 49);
            this.AddTeacher_btn.TabIndex = 4;
            this.AddTeacher_btn.Text = "Teachers";
            this.AddTeacher_btn.UseVisualStyleBackColor = true;
            this.AddTeacher_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // AddStudent_btn
            // 
            this.AddStudent_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudent_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddStudent_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddStudent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudent_btn.ForeColor = System.Drawing.Color.White;
            this.AddStudent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddStudent_btn.Location = new System.Drawing.Point(16, 271);
            this.AddStudent_btn.Margin = new System.Windows.Forms.Padding(4);
            this.AddStudent_btn.Name = "AddStudent_btn";
            this.AddStudent_btn.Size = new System.Drawing.Size(267, 49);
            this.AddStudent_btn.TabIndex = 3;
            this.AddStudent_btn.Text = "Students";
            this.AddStudent_btn.UseVisualStyleBackColor = true;
            this.AddStudent_btn.Click += new System.EventHandler(this.AddStudent_btn_Click);
            // 
            // L_ad
            // 
            this.L_ad.AutoSize = true;
            this.L_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ad.ForeColor = System.Drawing.Color.White;
            this.L_ad.Location = new System.Drawing.Point(63, 175);
            this.L_ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_ad.Name = "L_ad";
            this.L_ad.Size = new System.Drawing.Size(161, 25);
            this.L_ad.TabIndex = 1;
            this.L_ad.Text = "Welcome, Admin";
            this.L_ad.Click += new System.EventHandler(this.L_ad_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addStudentForm1);
            this.panel3.Controls.Add(this.addTeachersForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1167, 708);
            this.panel3.TabIndex = 2;
            // 
            // addStudentForm1
            // 
            this.addStudentForm1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addStudentForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStudentForm1.Location = new System.Drawing.Point(0, 0);
            this.addStudentForm1.Margin = new System.Windows.Forms.Padding(5);
            this.addStudentForm1.Name = "addStudentForm1";
            this.addStudentForm1.Size = new System.Drawing.Size(1167, 708);
            this.addStudentForm1.TabIndex = 1;
            this.addStudentForm1.Load += new System.EventHandler(this.addStudentForm1_Load);
            // 
            // addTeachersForm1
            // 
            this.addTeachersForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTeachersForm1.Location = new System.Drawing.Point(0, 0);
            this.addTeachersForm1.Margin = new System.Windows.Forms.Padding(5);
            this.addTeachersForm1.Name = "addTeachersForm1";
            this.addTeachersForm1.Size = new System.Drawing.Size(1167, 708);
            this.addTeachersForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 738);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddTeacher_btn;
        private System.Windows.Forms.Button AddStudent_btn;
        private System.Windows.Forms.Label L_ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private AddTeachersForm addTeachersForm1;
        private AddStudentForm addStudentForm1;
        private Button logout_btn;
    }
}