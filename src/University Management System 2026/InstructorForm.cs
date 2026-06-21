using System;
using System.Data.SqlClient;
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
    public partial class InstructorForm : Form
    {
        string conStr =
      @"Data Source=.\sqlexpress;
          Initial Catalog=University;
          Integrated Security=True";
        public InstructorForm()
        {
            InitializeComponent();
            Theme.ApplyFormTheme(this);
            // wire click handlers for buttons that were not wired in Designer
            this.button3.Click += button3_Click; // UPDATE
            this.button4.Click += button4_Click; // DELETE
        }

        private void instructorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.instructorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet1);

        }

        private void instructorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.instructorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet1);

        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet1.instructor' table. You can move, or remove it, as needed.
            this.instructorTableAdapter.Fill(this.universityDataSet1.instructor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // LOAD button: reload instructor data
            this.instructorTableAdapter.Fill(this.universityDataSet1.instructor);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // BACK button: go back to AdminForm
            var admin = Application.OpenForms.OfType<AdminForm>().FirstOrDefault();
            if (admin != null)
            {
                admin.Show();
                admin.BringToFront();
            }
            else
            {
                var af = new AdminForm();
                af.Show();
            }
            this.Close();
        }

        private void instructorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ADD
            var id = (iDTextBox.Text ?? "").Trim();
            var name = (nameTextBox.Text ?? "").Trim();
            var dept = (dept_nameTextBox.Text ?? "").Trim();
            var salaryText = (salaryTextBox.Text ?? "").Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name)) { MessageBox.Show("Enter ID and name."); return; }
            if (!decimal.TryParse(salaryText, out decimal salary)) { MessageBox.Show("Invalid salary."); return; }

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    using (SqlCommand check = new SqlCommand("SELECT COUNT(1) FROM instructor WHERE ID = @id", con))
                    {
                        check.Parameters.AddWithValue("@id", id);
                        int exists = Convert.ToInt32(check.ExecuteScalar());
                        if (exists > 0)
                        {
                            MessageBox.Show("An instructor with that ID already exists.");
                            return;
                        }
                    }

                    using (SqlCommand insert = new SqlCommand("INSERT INTO instructor(ID, name, dept_name, salary) VALUES(@id,@name,@dept,@salary)", con))
                    {
                        insert.Parameters.AddWithValue("@id", id);
                        insert.Parameters.AddWithValue("@name", name);
                        insert.Parameters.AddWithValue("@dept", dept);
                        insert.Parameters.AddWithValue("@salary", salary);
                        int r = insert.ExecuteNonQuery();
                        MessageBox.Show(r > 0 ? "Instructor added." : "Insert failed.");
                    }
                    con.Close();
                }

                this.instructorTableAdapter.Fill(this.universityDataSet1.instructor);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("DB error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // UPDATE
            var id = (iDTextBox.Text ?? "").Trim();
            var name = (nameTextBox.Text ?? "").Trim();
            var dept = (dept_nameTextBox.Text ?? "").Trim();
            var salaryText = (salaryTextBox.Text ?? "").Trim();

            if (string.IsNullOrEmpty(id)) { MessageBox.Show("Enter ID to update."); return; }
            if (!decimal.TryParse(salaryText, out decimal salary)) { MessageBox.Show("Invalid salary."); return; }

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                using (SqlCommand cmd = new SqlCommand("UPDATE instructor SET name=@name, dept_name=@dept, salary=@salary WHERE ID=@id", con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@dept", dept);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(rows > 0 ? "Instructor updated." : "No instructor found to update.");
                }

                this.instructorTableAdapter.Fill(this.universityDataSet1.instructor);
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
            if (string.IsNullOrEmpty(id)) { MessageBox.Show("Enter ID to delete."); return; }

            if (MessageBox.Show("Delete instructor '" + id + "'?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM instructor WHERE ID=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(rows > 0 ? "Instructor deleted." : "No instructor found to delete.");
                }

                this.instructorTableAdapter.Fill(this.universityDataSet1.instructor);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("DB error: " + ex.Message);
            }
        }
    }
}
