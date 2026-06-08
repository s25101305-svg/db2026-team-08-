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
            this.tableAdapterManager.UpdateAll(this.universityDataSet);

        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet.takes' table. You can move, or remove it, as needed.
            this.takesTableAdapter.Fill(this.universityDataSet.takes);
            // TODO: This line of code loads data into the 'universityDataSet.teaches' table. You can move, or remove it, as needed.
            this.teachesTableAdapter.Fill(this.universityDataSet.teaches);
            // TODO: This line of code loads data into the 'universityDataSet.instructor' table. You can move, or remove it, as needed.
            this.instructorTableAdapter.Fill(this.universityDataSet.instructor);

        }

        private void btnClick1(object sender, EventArgs e)
        {
            this.Validate();
            this.takesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet);
            MessageBox.Show("Grades saved successfully!");  
        }
    }
}
