using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

    namespace CoachingMangementSystem
    {
        public partial class TeacherInfo : Form
        {
            private DB db;
        private string teacherId;
        
            public TeacherInfo(string teacherId)
            {
                InitializeComponent();
            this.db = new DB();
            this.teacherId = teacherId;
            loadTeacherInformation();

        }

        private void loadTeacherInformation()
        {
            try
            {
                string sql = "SELECT teacher_name FROM Teachers " +
                            "WHERE teacher_id = '" + this.teacherId + "'";


                DataTable dt = this.db.ExecuteQuery(sql);

                if (dt.Rows.Count > 0)
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void loadTeacherSchedule()
        {
            try
            {
                string sql = @"SELECT course_name, section, class_time, teacher_id FROM Classes WHERE teacher_id  = '" + this.teacherId + "'";

                DataTable dt = this.db.ExecuteQuery(sql);

                t_data.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
            {
            try
            {
                string sec_q = @"SELECT section FROM classes WHERE teacher_id=" + this.teacherId + "'";
            }
            catch
            {
                MessageBox.Show("Information not found");
            }
            }

            private void schedule_btn_Click(object sender, EventArgs e)
            {
            loadTeacherInformation();
            loadTeacherSchedule();

            }

        private void Sub_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sec_q = @"SELECT course_name FROM classes WHERE teacher_id=" + this.teacherId + "'";
            }
            catch
            {
                MessageBox.Show("Information not found");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            TeacherDashBoard tb = new TeacherDashBoard(teacherId);
            tb.Show();
            this.Hide();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string search = "SELECT section, course_name FROM classes WHERE teacher_id = '" + teacherId + "'";

            if (!string.IsNullOrWhiteSpace(t_course.Text))
            {
                search += " AND course_name = '" + t_course.Text + "'";
            }

            if (!string.IsNullOrWhiteSpace(t_sec.Text))
            {
                search += " AND section = '" + t_sec.Text + "'";
            }

            DataTable dt = db.ExecuteQuery(search);
            t_data.DataSource = dt;
        }

        private void t_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
