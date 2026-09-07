
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachingMangementSystem
{
    public partial class TeacherDashBoard : Form

    {
        private DB db;
        private string teacherId;
       
        public TeacherDashBoard(string teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            this.db = new DB();
            loadTeacherName();
        }
        private void loadTeacherName()
        {
            try
            {
                string nq = "SELECT teacher_name FROM Teachers " +
                            "WHERE teacher_id = '" + this.teacherId + "'";

                DataTable dt = this.db.ExecuteQuery(nq);

                if (dt.Rows.Count > 0)
                {
                    T_name.Text = "Welcome, " +
                                  dt.Rows[0]["teacher_name"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dashboardForm1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardForm1_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            TeacherProfile tp = new TeacherProfile(this.teacherId);
            tp.Show();
            this.Hide();
        }

        private void T_name_Click(object sender, EventArgs e)
        {
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }

        private void AddStudent_btn_Click(object sender, EventArgs e)
        {
            TeacherInfo ti= new TeacherInfo(this.teacherId);
            ti.Show();
            this.Hide();
        }
    }
}
