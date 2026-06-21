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
    public partial class CourseForm : Form
    {
        string conStr = @"Data Source=.\sqlexpress;
                      Initial Catalog=University;
                      Integrated Security=True";

        public CourseForm()
        {
            InitializeComponent();
            Theme.ApplyFormTheme(this);
            // Designer wires button click events; only wire handlers not set in Designer
            this.courseDataGridView.CellClick += courseDataGridView_CellClick;
            this.course_idTextBox.TextChanged += (s, e) => UpdateButtonsState();
            UpdateButtonsState();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet1);

        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet1.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.universityDataSet1.course);
            LoadCourses();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    var da = new SqlDataAdapter("SELECT * FROM course ORDER BY course_id", con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    // bind via BindingSource so Designer bindings remain consistent
                    this.courseBindingSource.DataSource = dt;
                    this.courseDataGridView.DataSource = this.courseBindingSource;
                    this.courseBindingSource.ResetBindings(false);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("DB error while loading: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ADD
            var id = (course_idTextBox.Text ?? "").Trim();
            var title = (titleTextBox.Text ?? "").Trim();
            var dept = (dept_nameTextBox.Text ?? "").Trim();
            var credits = (creditsTextBox.Text ?? "").Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Enter course id.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    using (SqlCommand check = new SqlCommand("SELECT COUNT(1) FROM course WHERE course_id=@id", con))
                    {
                        check.Parameters.AddWithValue("@id", id);
                        int exists = Convert.ToInt32(check.ExecuteScalar());
                        if (exists > 0)
                        {
                            MessageBox.Show("Course already exists.");
                            return;
                        }
                    }

                    using (SqlCommand insert = new SqlCommand(
                        "INSERT INTO course(course_id, title, dept_name, credits) VALUES(@id,@title,@dept,@credits)", con))
                    {
                        insert.Parameters.AddWithValue("@id", id);
                        insert.Parameters.AddWithValue("@title", title);
                        insert.Parameters.AddWithValue("@dept", dept);
                        insert.Parameters.AddWithValue("@credits", credits);
                        int affected = insert.ExecuteNonQuery();
                        MessageBox.Show(affected > 0 ? "Course added." : "Insert failed.");
                    }

                    con.Close();
                }

                // clear inputs and refresh
                course_idTextBox.Clear();
                titleTextBox.Clear();
                dept_nameTextBox.Clear();
                creditsTextBox.Clear();
                UpdateButtonsState();
                button1_Click(sender, e);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("DB error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // UPDATE
            var id = (course_idTextBox.Text ?? "").Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Enter course id to update.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE course SET title=@title, dept_name=@dept, credits=@credits WHERE course_id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@title", (titleTextBox.Text ?? "").Trim());
                    cmd.Parameters.AddWithValue("@dept", (dept_nameTextBox.Text ?? "").Trim());
                    cmd.Parameters.AddWithValue("@credits", (creditsTextBox.Text ?? "").Trim());

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rows == 0)
                        MessageBox.Show("No course found to update.");
                    else
                        MessageBox.Show("Rows Updated: " + rows);
                }

                // clear inputs and refresh
                course_idTextBox.Clear();
                titleTextBox.Clear();
                dept_nameTextBox.Clear();
                creditsTextBox.Clear();
                UpdateButtonsState();
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
            var id = (course_idTextBox.Text ?? "").Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Enter course id to delete.");
                return;
            }

            var ok = MessageBox.Show("Delete course '" + id + "'?", "Confirm", MessageBoxButtons.YesNo);
            if (ok != DialogResult.Yes) return;

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM course WHERE course_id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rows == 0)
                        MessageBox.Show("No course found to delete.");
                    else
                        MessageBox.Show("Rows Deleted: " + rows);
                }

                // clear inputs and refresh
                course_idTextBox.Clear();
                titleTextBox.Clear();
                dept_nameTextBox.Clear();
                creditsTextBox.Clear();
                UpdateButtonsState();
                button1_Click(sender, e);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("DB error: " + ex.Message);
            }
        }

        private void courseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = courseDataGridView.Rows[e.RowIndex];
            course_idTextBox.Text = row.Cells[0].Value?.ToString() ?? "";
            titleTextBox.Text = row.Cells[1].Value?.ToString() ?? "";
            dept_nameTextBox.Text = row.Cells[2].Value?.ToString() ?? "";
            creditsTextBox.Text = row.Cells[3].Value?.ToString() ?? "";
            UpdateButtonsState();
        }

        private void UpdateButtonsState()
        {
            var hasId = !string.IsNullOrWhiteSpace(course_idTextBox.Text);
            // enable update/delete only when an id is present
            this.button3.Enabled = hasId;
            this.button4.Enabled = hasId;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // BACK
            var admin = Application.OpenForms.OfType<AdminForm>().FirstOrDefault();
            if (admin != null) { admin.Show(); admin.BringToFront(); }
            else { new AdminForm().Show(); }
            this.Close();
        }


    }
}
