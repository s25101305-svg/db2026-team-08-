using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystemManagement2026
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void usTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClick1(object sender, EventArgs e)
        {
            // validate input
            if (string.IsNullOrWhiteSpace(usTxtBox.Text) ||
                string.IsNullOrWhiteSpace(passTxtBox.Text))
            {
                MessageBox.Show("username and password is required!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // open database
            using (var db = new UniversityEntities())
            {
                // check if user exists
                var user = db.users 
                             .Where(u => u.Username == usTxtBox.Text &&
                                         u.Password == passTxtBox.Text)
                             .FirstOrDefault();

                if (user == null)
                {
                    MessageBox.Show("invalid username or password!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // hide login form
                this.Hide();

                // open form based on role
                switch (user.role)
                {
                    case "administrator":
                        var adminForm = new AdminForm();
                        adminForm.ShowDialog();
                        break;
                    case "instructor":
                        var facultyForm = new InstructorForm();
                        facultyForm.ShowDialog();
                        break;
                    case "student":
                        var studentForm = new Form1();
                        studentForm.ShowDialog();
                        break;
                }

                // show login form again after closing
                this.Show();
            }
        }
    }
    }

