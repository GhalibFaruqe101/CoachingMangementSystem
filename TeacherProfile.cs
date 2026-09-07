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
            string classQ = @"SELECT * FROM CLASSES WHERE TeacherId = '"+ teacherId+"'";
            DataTable dt = db.ExecuteQuery(classQ);
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            
            TeacherDashBoard td = new TeacherDashBoard(teacherId);
            td.Show();
            this.Hide();
        }
    }
    }

