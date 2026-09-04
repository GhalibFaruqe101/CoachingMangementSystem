using System;
using System.Data;
using System.Windows.Forms;

namespace CoachingMangementSystem
{
    public partial class DashboardForm : UserControl
    {
        public DashboardForm()
        {
            InitializeComponent();

            displayTotalES();
            displayTotalTT();
            displayEnrolledStudentToday();
        }

        public void displayTotalES()
        {
            try
            {
                total_ES.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting Database: " + ex.Message);
            }
        }

        public void displayTotalTT()
        {
            try
            {
                total_TT.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting Database: " + ex.Message);
            }
        }

        public void displayEnrolledStudentToday()
        {
            try
            {
                // Mock - no database
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting Database: " + ex.Message);
            }
        }

        public void displayTotalGS() { }
        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void student_addBtn_Click(object sender, EventArgs e) { }
        private void Add_Stu_btn_Click(object sender, EventArgs e) { }
        private void DashboardForm_Load(object sender, EventArgs e) { }
    }
}