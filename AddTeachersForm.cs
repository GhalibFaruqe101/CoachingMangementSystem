using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
//using CoachingMangementSystem.CoachingMangementSystem;

namespace CoachingMangementSystem
{
    public partial class AddTeachersForm : UserControl
    {
        private DB db;
        
        public AddTeachersForm()
        {

            InitializeComponent();
            this.db=new DB();

            loadData();
        }
        private void loadData()
        {
            try
            {
                string sql = "SELECT * FROM Teachers";
                DataTable table = this.db.ExecuteQuery(sql);
                teacher_gridData.DataSource = table;
                int count = this.db.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("Teacher added successfully");
                }

            }
            catch(Exception ex  )
            {
                MessageBox.Show("Error: " + ex.Message); 
            }
        }

        public void teacherDisplayData()
        {
            AddTeachersData addTD = new AddTeachersData();

            teacher_gridData.DataSource = addTD.teacherData();
        }

        private void teacher_addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(teacher_id.Text) ||
                    string.IsNullOrEmpty(teacher_name.Text) ||
                    string.IsNullOrEmpty(teacher_gender.Text) ||
                    string.IsNullOrEmpty(teacher_address.Text) ||
                    string.IsNullOrEmpty(teacher_sub.Text))
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                Teacher teacher;

                if (DataStore.SearchTeacher(
                    teacher_id.Text.Trim(),
                    out teacher))
                {
                    MessageBox.Show("Teacher ID already exists");
                    return;
                }

                Teacher newTeacher = new Teacher(
                    teacher_id.Text.Trim(),
                    teacher_name.Text.Trim(),
                    teacher_id.Text.Trim(),
                    "1234",
                    teacher_gender.Text,
                    teacher_address.Text.Trim(),
                    teacher_sub.Text
                );

                DataStore.AddTeacher(newTeacher);

                MessageBox.Show("Teacher added successfully");

                displayTeacherData();
                clearFields();
            }
            catch (Exception exc)
            {
                MessageBox.Show(
                    "An error has occurred.\n" + exc.Message);
            }
        }

        public void clearFields()
        {
            teacher_id.Text = "";
            teacher_name.Text = "";
            teacher_gender.SelectedIndex = -1;
            teacher_address.Text = "";
            teacher_status.SelectedIndex = -1;
            teacher_image.Image = null;
            imagePath = "";
        }

        private string imagePath;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg; *.png)|*.jpg;*.png";

            if(open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName;

                teacher_image.ImageLocation = imagePath;
            }
        }

        private void teacher_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void teacher_updateBtn_Click(object sender, EventArgs e)
        {
            if (teacher_id.Text == ""
                || teacher_name.Text == ""
                || teacher_gender.Text == ""
                || teacher_address.Text == ""
                || teacher_status.Text == ""
                || teacher_image.Image == null
                || imagePath == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Updated");
                    
                
            }
        }

        private void teacher_gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex != -1)
            {
                DataGridViewRow row = teacher_gridData.Rows[e.RowIndex];
                teacher_id.Text = row.Cells[1].Value.ToString();
                teacher_name.Text = row.Cells[2].Value.ToString();
                teacher_gender.Text = row.Cells[3].Value.ToString();
                teacher_address.Text = row.Cells[4].Value.ToString();

                imagePath = row.Cells[5].Value.ToString();

                string imageData = row.Cells[5].Value.ToString();

                if(imageData != null && imageData.Length > 0)
                {
                    teacher_image.Image = Image.FromFile(imageData);
                }
                else
                {
                    teacher_image.Image = null;
                }

                teacher_status.Text = row.Cells[6].Value.ToString();
                
            }

        }

        private void teacher_deleteBtn_Click(object sender, EventArgs e)
        {
            if(teacher_id.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(true) // connect.State != ConnectionState.Open
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Delete Teacher ID: " 
                        + teacher_id.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if(check == DialogResult.Yes)
                    {
                        try
                        {
                            DateTime today = DateTime.Today;

                            string deleteData = "UPDATE teachers SET date_delete = @dateDelete " +
                                "WHERE teacher_id = @teacherID";

                            teacherDisplayData();

                            MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error  connecting Database: " + ex, "Error Message"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void displayTeacherData() { }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {

        }

        private void teacher_gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            string search = @"SELECT * FROM Teachers WHERE teacher_name LIKE '%" + searchtxt.Text + "%'";
            DataTable dt = db.ExecuteQuery(search);
            teacher_gridData.DataSource = dt;
        }
    }
}
