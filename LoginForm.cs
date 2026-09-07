//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data;
//using System.Data.SqlClient;



//namespace SchoolMangementSystem
//{
//    public partial class LoginForm : Form
//    {
//        public LoginForm()
//        {
//            InitializeComponent();

//            AddDefaultUsers();
//        }

//        private void AddDefaultUsers()
//        {
//            DataStore.Users.Add(
//                new Admin("A-1", "Admin", "admin", "1234"));
//        }

//        private void loginBtn_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (string.IsNullOrEmpty(this.username.Text) ||
//                    string.IsNullOrEmpty(this.password.Text))
//                {
//                    MessageBox.Show("Please fill all fields");
//                    return;
//                }

//                Person foundUser = null;

//                foreach (Person p in DataStore.Users)
//                {
//                    if (p.Username == this.username.Text &&
//                        p.Password == this.password.Text)
//                    {
//                        foundUser = p;
//                        break;
//                    }
//                }

//                if (foundUser == null)
//                {
//                    MessageBox.Show("Invalid Username or Password");
//                    return;
//                }

//                //MessageBox.Show("Login Successful");

//                if (foundUser is Admin)
//                {
//                    DashboardForm DF = new DashboardForm();
//                    DF.Show();
//                    this.Hide();
//                }
//                else if (foundUser is Student)
//                {
//                    MessageBox.Show("Student Login Successful!");
//                }
//                else if (foundUser is Teacher)
//                {
//                    MessageBox.Show("Teacher Login Successful!");
//                }

//                this.Hide();
//            }
//            catch (Exception exc)
//            {
//                MessageBox.Show(
//                    "An error has occurred.\n" + exc.Message);
//            }
//        }

//        private void showPass_CheckedChanged(object sender, EventArgs e)
//        {
//            this.password.PasswordChar =
//                this.showPass.Checked ? '\0' : '*';
//        }

//        private void label1_Click(object sender, EventArgs e) { Application.Exit(); }
//    }
//}



//using SchoolMangementSystem.SchoolMangementSystem;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CoachingMangementSystem
{
    public partial class LoginForm : Form
    {
        private DB db;

        public LoginForm()
        {
            InitializeComponent();

            this.db = new DB();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation first
                if (string.IsNullOrEmpty(username.Text) ||
                    string.IsNullOrEmpty(password.Text))
                {
                    MessageBox.Show(
                        "Please fill all blank fields",
                        "Error Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                // Check username and password
                string sql = "SELECT * FROM Users " +
                             "WHERE username = '" + username.Text.Trim() + "' " +
                             "AND password = '" + password.Text.Trim() + "'";

                DataTable table = this.db.ExecuteQuery(sql);

                // User found
                if (table.Rows.Count == 1)
                {
                    string role = table.Rows[0]["role"].ToString();

                    MessageBox.Show(
                        "Login Successfully!",
                        "Information Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Admin
                    if (role == "Admin")
                    {
                        MainForm mform = new MainForm();

                        mform.Show();
                        this.Hide();
                    }

                    // Teacher
                    else if (role == "Teacher")
                    {
                        TeacherDashBoard tb = new TeacherDashBoard(username.Text);
                        tb.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show(
                        "Incorrect ID or Password",
                        "Error Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error connecting Database: " + ex.Message,
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = showPass.Checked ? '\0' : '*';
        }
    }
}
