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
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                student_studentData.DataSource = null;
                student_studentData.DataSource = DataStore.Students;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void student_studentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // If you don't need CellContentClick, you can leave this empty
        }

        private void student_studentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                    return;

                Student student = (Student)student_studentData.Rows[e.RowIndex].DataBoundItem;

                student_id.Text = student.Id;
                student_name.Text = student.Name;
                student_grade.Text = student.Gender;
                student_section.Text = student.Section;
                student_status.Text = student.ClassName;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

    }
    }

