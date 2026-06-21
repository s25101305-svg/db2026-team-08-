using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace University_Management_System_2026
{
    public partial class StudentForm : Form
    {
        string conStr = @"Data Source=.\sqlexpress;
                      Initial Catalog=University;
                      Integrated Security=True";

        public StudentForm()
        {
            InitializeComponent();
            Theme.ApplyFormTheme(this);
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet1);

        }

        private void studentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet1);

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet1.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.universityDataSet1.student);

        }

        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query = "SELECT * FROM Student";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            da.SelectCommand.Parameters.AddWithValue(
                "@id",
                iDTextBox.Text
            );

            DataTable dt = new DataTable();

            da.Fill(dt);

            studentDataGridView.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // safe insert with foreign-key and duplicate checks
            var id = (iDTextBox.Text ?? "").Trim();
            var name = (nameTextBox.Text ?? "").Trim();
            var dept = (dept_nameTextBox.Text ?? "").Trim();
            var cred = (tot_credTextBox.Text ?? "").Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(dept))
            {
                MessageBox.Show("Please enter ID, name and department.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    // ensure department exists to satisfy FK
                    using (SqlCommand checkDept = new SqlCommand("SELECT COUNT(1) FROM department WHERE dept_name = @dept", con))
                    {
                        checkDept.Parameters.AddWithValue("@dept", dept);
                        int d = Convert.ToInt32(checkDept.ExecuteScalar());
                        if (d == 0)
                        {
                            MessageBox.Show("Department '" + dept + "' does not exist. Add the department first or choose an existing one.");
                            return;
                        }
                    }

                    // ensure student id not already present
                    using (SqlCommand checkStu = new SqlCommand("SELECT COUNT(1) FROM Student WHERE ID = @id", con))
                    {
                        checkStu.Parameters.AddWithValue("@id", id);
                        int s = Convert.ToInt32(checkStu.ExecuteScalar());
                        if (s > 0)
                        {
                            MessageBox.Show("A student with this ID already exists.");
                            return;
                        }
                    }

                    string query = "INSERT INTO Student(ID, name, dept_name, tot_cred) VALUES(@id, @name, @dept, @cred)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@dept", dept);
                        cmd.Parameters.AddWithValue("@cred", cred);
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Student Added Successfully!" : "Insert failed.");
                    }

                    con.Close();
                }

                iDTextBox.Clear();
                nameTextBox.Clear();
                dept_nameTextBox.Clear();
                tot_credTextBox.Clear();

                button1_Click(sender, e);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("DB error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query =
                "UPDATE Student " +
                "SET name=@name, dept_name=@dept, tot_cred=@cred " +
                "WHERE ID=@id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", iDTextBox.Text);
            cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
            cmd.Parameters.AddWithValue("@dept", dept_nameTextBox.Text);
            cmd.Parameters.AddWithValue("@cred", tot_credTextBox.Text);

            con.Open();

            int rows = cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Rows Updated: " + rows);

            button1_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query =
                "DELETE FROM Student " +
                "WHERE ID=@id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", iDTextBox.Text);

            con.Open();

            int rows = cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Rows Deleted: " + rows);

            button1_Click(sender, e);

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
