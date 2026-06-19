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
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
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
    }
}
