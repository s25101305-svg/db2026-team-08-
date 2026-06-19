using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System_2026
{
    public partial class LoginForm : Form
    {
        

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UniversityEntities db = new UniversityEntities();
            // check if user exists (use Username field, not ID)
            var user = db.users.Where(u => u.Username == usernameTextBox.Text && u.Password ==
            passwordTextBox.Text).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("invalid username or password!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            // hide login form
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            this.Hide();
            // open form based on role
            // make role comparison case-insensitive and safe for nulls
            switch ((user.role ?? "").ToLower())
            {
                // administrator
                case "administrator":
                    var adminForm = new AdminForm();
                    adminForm.ShowDialog();
                    break;
                // instructor
                case "instructor":
                    var facultyForm = new InstructorForm();
                    facultyForm.ShowDialog();
                    break;
                // student
                case "student":
                    var studentForm = new StudentForm();
                    studentForm.ShowDialog();
                    break;
            }
            // show login form
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
    

