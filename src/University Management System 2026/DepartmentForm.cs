using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace University_Management_System_2026
{
    public partial class DepartmentForm : Form
    {
        string conStr = @"Data Source=.\sqlexpress;
                      Initial Catalog=University;
                      Integrated Security=True";

        public DepartmentForm()
        {
            InitializeComponent();
            Theme.ApplyFormTheme(this);
            // wire up button click handlers (Designer only wired LOAD)
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button4.Click += new EventHandler(this.button4_Click);
            this.button5.Click += new EventHandler(this.button5_Click);
        }

        private void departmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet1);

        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet1.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.universityDataSet1.department);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // LOAD departments into grid
            SqlConnection con = new SqlConnection(conStr);

            string query = "SELECT * FROM department";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            departmentDataGridView.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ADD with duplicate-check and error handling
            if (string.IsNullOrWhiteSpace(dept_nameTextBox.Text))
            {
                MessageBox.Show("Please enter a department name.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                using (SqlCommand cmd = new SqlCommand(
                    "IF NOT EXISTS (SELECT 1 FROM department WHERE dept_name = @dept) " +
                    "INSERT INTO department(dept_name, building, budget) VALUES(@dept,@building,@budget)", con))
                {
                    cmd.Parameters.AddWithValue("@dept", dept_nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@building", buildingTextBox.Text);
                    cmd.Parameters.AddWithValue("@budget", budgetTextBox.Text);

                    con.Open();
                    int affected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (affected > 0)
                    {
                        MessageBox.Show("Department added.");
                        dept_nameTextBox.Clear();
                        buildingTextBox.Clear();
                        budgetTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Department already exists.");
                    }
                }

                // reload
                button1_Click(sender, e);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // UPDATE with error handling
            if (string.IsNullOrWhiteSpace(dept_nameTextBox.Text))
            {
                MessageBox.Show("Please enter the department name to update.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE department SET building=@building, budget=@budget WHERE dept_name=@dept", con))
                {
                    cmd.Parameters.AddWithValue("@dept", dept_nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@building", buildingTextBox.Text);
                    cmd.Parameters.AddWithValue("@budget", budgetTextBox.Text);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Rows Updated: " + rows);
                }

                button1_Click(sender, e);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // DELETE with confirmation and error handling
            if (string.IsNullOrWhiteSpace(dept_nameTextBox.Text))
            {
                MessageBox.Show("Please enter the department name to delete.");
                return;
            }

            var ok = MessageBox.Show("Delete department '" + dept_nameTextBox.Text + "'?", "Confirm", MessageBoxButtons.YesNo);
            if (ok != DialogResult.Yes) return;

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM department WHERE dept_name=@dept", con))
                {
                    cmd.Parameters.AddWithValue("@dept", dept_nameTextBox.Text);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Rows Deleted: " + rows);
                }

                button1_Click(sender, e);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
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
    }
}
