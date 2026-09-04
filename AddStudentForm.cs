
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;


namespace CoachingMangementSystem
{

    public partial class AddStudentForm : UserControl
    {
        private DB db;
        public AddStudentForm()
        {
            InitializeComponent();
            this.db = new DB();


            LoadStudent();
        }

        private void LoadStudent()
        {
            try
            {
                string sql = "SELECT * FROM Students";

                DataTable table = this.db.ExecuteQuery(sql);

                student_studentData.DataSource = table;
                //int count = this.db.ExecuteDMLQuery(sql);
                //if (count == 1)
                //{
                //    MessageBox.Show("Student added successfully");

                //    LoadStudent();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                Student student;

                if (DataStore.SearchStudent(
                    this.student_id.Text.Trim(),
                    out student))
                {
                    MessageBox.Show("Student ID already exists");
                    return;
                }

                Student newStudent = new Student(
                    this.student_id.Text.Trim(),
                    this.student_name.Text.Trim(),
                    this.student_id.Text.Trim(),
                    "1234",
                    this.student_gender.Text,
                    this.student_address.Text.Trim(),
                    this.student_grade.Text,
                    this.student_section.Text
                );

                DataStore.AddStudent(newStudent);

                MessageBox.Show("Student added successfully");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }











        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.student_id.Text) ||
                string.IsNullOrEmpty(this.student_name.Text) ||
                string.IsNullOrEmpty(this.student_gender.Text) ||
                string.IsNullOrEmpty(this.student_address.Text) ||
                string.IsNullOrEmpty(this.student_grade.Text) ||
                string.IsNullOrEmpty(this.student_section.Text))
            {
                return false;
            }

            return true;
        }

        public void displayStudentData()
        {
            student_studentData.DataSource = null;
            student_studentData.DataSource = DataStore.Students;
        }

        public void clearFields()
        {
            this.student_id.Text = "";
            this.student_name.Text = "";
            this.student_gender.SelectedIndex = -1;
            this.student_address.Text = "";
            this.student_grade.SelectedIndex = -1;
            this.student_section.SelectedIndex = -1;
        }

        private void student_deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(student_id.Text))
                {
                    MessageBox.Show("Please select a student first");
                    return;
                }

                DialogResult check = MessageBox.Show(
                    "Are you sure you want to delete this student?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (check == DialogResult.No)
                    return;

                Student student;

                if (DataStore.SearchStudent(student_id.Text, out student))
                {
                    DataStore.Students.Remove(student);
                    DataStore.Users.Remove(student);

                    MessageBox.Show("Student deleted successfully");

                    displayStudentData();
                    clearFields();
                }
                else
                {
                    MessageBox.Show("Student not found");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void student_updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                Student student;

                if (!DataStore.SearchStudent(student_id.Text, out student))
                {
                    MessageBox.Show("Student not found");
                    return;
                }

                student.Name = student_name.Text.Trim();
                student.Gender = student_gender.Text;
                student.Address = student_address.Text.Trim();
                student.ClassName = student_grade.Text;
                student.Section = student_section.Text;

                MessageBox.Show("Student updated successfully");

                displayStudentData();
                clearFields();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e) {
            addStudentBtn_Click(sender, e);
            {
                int count = this.db.ExecuteDMLQuery("INSERT INTO Students (Id, Name, Gender, Address, Class) VALUES ('" + student_id.Text + "', '" + student_name.Text + "', '" + student_gender.Text + "', '" + student_address.Text + "', '" + student_grade.Text + "')");
                if (count == 1)
                {
                    MessageBox.Show("Student added successfully");
                    LoadStudent();

                }
                else
                {
                    MessageBox.Show("Failed to add student");

                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e) { }
        private void student_studentData_CellClick(object sender, DataGridViewCellEventArgs e) { }

        private void student_studentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                    return;

                Student student =
                    (Student)student_studentData.Rows[e.RowIndex].DataBoundItem;

                student_id.Text = student.Id;
                student_name.Text = student.Name;
                student_gender.Text = student.Gender;
                student_address.Text = student.Address;
                student_grade.Text = student.ClassName;
                student_section.Text = student.Section;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void student_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(searchtxt.Text))
                {
                    MessageBox.Show("Please enter Student ID");
                    return;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void student_grade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void student_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void student_clearBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void student_image_Click(object sender, EventArgs e)
        {

        }

        private void student_section_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void student_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void student_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void student_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }

}