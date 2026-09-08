using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoachingMangementSystem
{
    public partial class TeacherProfile : Form
    {
        private DB db;
        private string teacherId;

        public TeacherProfile(string teacherId)
        {
            InitializeComponent();
            this.db = new DB();
            this.teacherId = teacherId;




            loadTeacherName();
            loadInfo();
        }

        //private void loadInfo()
        //{
        //    try
        //    {
        //        string info_q = @"SELECT course_name, section, class_time From Classes WHERE teacher_id='" + teacherId + "'";
        //        student_studentData.DataSource = info_q;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //}
        private void loadInfo()
        {
            try
            {
                string info_q = "SELECT course_name, section, class_time " +
                                "FROM Classes " +
                                "WHERE teacher_id = '" + this.teacherId + "'";

                DataTable dt = db.ExecuteQuery(info_q);

                student_studentData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void loadTeacherName()
        {
            try
            {
                string nq = "SELECT teacher_name FROM Teachers " +
                            "WHERE teacher_id = '" + this.teacherId + "'";

                DataTable dt = this.db.ExecuteQuery(nq);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string classQ = @"SELECT * FROM CLASSES WHERE Teacher_id = '" + this.teacherId + "'";
            DataTable dt = db.ExecuteQuery(classQ);
            student_studentData.DataSource = dt;

        }

        private void return_btn_Click(object sender, EventArgs e)
        {

            TeacherDashBoard td = new TeacherDashBoard(teacherId);
            td.Show();
            this.Hide();
        }

        private void student_addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(student_id.Text) ||
                    string.IsNullOrEmpty(student_grade.Text))
                {
                    MessageBox.Show("Please fill Student ID and Grade");
                    return;
                }

                string grade = "UPDATE Marks SET grade = '" +
                               student_grade.Text + "' " +
                               "WHERE student_id = '" + student_id.Text + "' " +
                               "AND teacher_id = '" + teacherId + "'";

                int count = db.ExecuteDMLQuery(grade);

                if (count > 0)
                {
                    MessageBox.Show("Grade updated successfully");
                    loadInfo();
                }
                else
                {
                    MessageBox.Show("No grade record found for this student");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void student_studentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

