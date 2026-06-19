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

namespace University_Management_System_2026
{
    public partial class EnrollmentForm : Form
    {
        string conStr = @"Data Source=.\sqlexpress;
                      Initial Catalog=University;
                      Integrated Security=True";

        public EnrollmentForm()
        {
            InitializeComponent();
            this.takesDataGridView.CellClick += takesDataGridView_CellClick;
        }

        private void takesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.takesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet1);

        }

        private void EnrollmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet1.takes' table. You can move, or remove it, as needed.
            this.takesTableAdapter.Fill(this.universityDataSet1.takes);

        }

        private void LoadEnrollments()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    var da = new SqlDataAdapter("SELECT * FROM takes ORDER BY ID", con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    this.takesBindingSource.DataSource = dt;
                    this.takesDataGridView.DataSource = this.takesBindingSource;
                    this.takesBindingSource.ResetBindings(false);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("DB error while loading takes: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadEnrollments();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ADD enrollment
            var id = (iDTextBox.Text ?? "").Trim();
            var course = (course_idTextBox.Text ?? "").Trim();
            var sec = (sec_idTextBox.Text ?? "").Trim();
            var sem = (semesterTextBox.Text ?? "").Trim();
            var year = (yearTextBox.Text ?? "").Trim();
            var grade = (gradeTextBox.Text ?? "").Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(course))
            {
                MessageBox.Show("Enter student ID and course ID.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    // ensure student exists
                    using (SqlCommand checkStudent = new SqlCommand("SELECT COUNT(1) FROM student WHERE ID=@id", con))
                    {
                        checkStudent.Parameters.AddWithValue("@id", id);
                        int studentExists = Convert.ToInt32(checkStudent.ExecuteScalar());
                        if (studentExists == 0)
                        {
                            MessageBox.Show("Student ID not found. Cannot enroll a non-existent student.");
                            return;
                        }
                    }

                    // ensure course exists
                    using (SqlCommand checkCourse = new SqlCommand("SELECT COUNT(1) FROM course WHERE course_id=@course", con))
                    {
                        checkCourse.Parameters.AddWithValue("@course", course);
                        int courseExists = Convert.ToInt32(checkCourse.ExecuteScalar());
                        if (courseExists == 0)
                        {
                            MessageBox.Show("Course ID not found. Please enter a valid course_id.");
                            return;
                        }
                    }
                    using (SqlCommand check = new SqlCommand("SELECT COUNT(1) FROM takes WHERE ID=@id AND course_id=@course AND sec_id=@sec AND semester=@sem AND year=@year", con))
                    {
                        check.Parameters.AddWithValue("@id", id);
                        check.Parameters.AddWithValue("@course", course);
                        check.Parameters.AddWithValue("@sec", sec);
                        check.Parameters.AddWithValue("@sem", sem);
                        check.Parameters.AddWithValue("@year", year);
                        int exists = Convert.ToInt32(check.ExecuteScalar());
                        if (exists > 0)
                        {
                            MessageBox.Show("Enrollment already exists.");
                            return;
                        }
                    }

                    using (SqlCommand insert = new SqlCommand("INSERT INTO takes(ID, course_id, sec_id, semester, year, grade) VALUES(@id,@course,@sec,@sem,@year,@grade)", con))
                    {
                        insert.Parameters.AddWithValue("@id", id);
                        insert.Parameters.AddWithValue("@course", course);
                        insert.Parameters.AddWithValue("@sec", sec);
                        insert.Parameters.AddWithValue("@sem", sem);
                        insert.Parameters.AddWithValue("@year", year);
                        insert.Parameters.AddWithValue("@grade", grade);
                        int r = insert.ExecuteNonQuery();
                        MessageBox.Show(r > 0 ? "Enrollment added." : "Insert failed.");
                    }

                    con.Close();
                }

                button1_Click(sender, e);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("DB error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // UPDATE grade (and other fields)
            var id = (iDTextBox.Text ?? "").Trim();
            var course = (course_idTextBox.Text ?? "").Trim();
            var sec = (sec_idTextBox.Text ?? "").Trim();
            var sem = (semesterTextBox.Text ?? "").Trim();
            var year = (yearTextBox.Text ?? "").Trim();
            var grade = (gradeTextBox.Text ?? "").Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(course))
            {
                MessageBox.Show("Enter student ID and course ID to update.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                using (SqlCommand cmd = new SqlCommand("UPDATE takes SET sec_id=@sec, semester=@sem, year=@year, grade=@grade WHERE ID=@id AND course_id=@course", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@course", course);
                    cmd.Parameters.AddWithValue("@sec", sec);
                    cmd.Parameters.AddWithValue("@sem", sem);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@grade", grade);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rows == 0) MessageBox.Show("No enrollment found to update."); else MessageBox.Show("Rows Updated: " + rows);
                }

                button1_Click(sender, e);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("DB error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // DELETE
            var id = (iDTextBox.Text ?? "").Trim();
            var course = (course_idTextBox.Text ?? "").Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(course))
            {
                MessageBox.Show("Enter student ID and course ID to delete.");
                return;
            }

            var ok = MessageBox.Show("Delete enrollment for student '" + id + "' and course '" + course + "'?", "Confirm", MessageBoxButtons.YesNo);
            if (ok != DialogResult.Yes) return;

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM takes WHERE ID=@id AND course_id=@course", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@course", course);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rows == 0) MessageBox.Show("No enrollment found to delete."); else MessageBox.Show("Rows Deleted: " + rows);
                }

                button1_Click(sender, e);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("DB error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // BACK
            var admin = Application.OpenForms.OfType<AdminForm>().FirstOrDefault();
            if (admin != null) { admin.Show(); admin.BringToFront(); } else { new AdminForm().Show(); }
            this.Close();
        }

        private void takesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = takesDataGridView.Rows[e.RowIndex];
            iDTextBox.Text = row.Cells[0].Value?.ToString() ?? "";
            course_idTextBox.Text = row.Cells[1].Value?.ToString() ?? "";
            sec_idTextBox.Text = row.Cells[2].Value?.ToString() ?? "";
            semesterTextBox.Text = row.Cells[3].Value?.ToString() ?? "";
            yearTextBox.Text = row.Cells[4].Value?.ToString() ?? "";
            gradeTextBox.Text = row.Cells[5].Value?.ToString() ?? "";
        }
    }
}
