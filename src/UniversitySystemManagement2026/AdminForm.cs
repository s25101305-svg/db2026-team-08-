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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet1);

        }

        private void userBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet1);

        }

        private void userBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet1);

        }

        private void userBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet1);

        }

        private void userBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet1);

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.universityDataSet.department);
            // TODO: This line of code loads data into the 'universityDataSet.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.universityDataSet.course);
            // TODO: This line of code loads data into the 'universityDataSet1.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.universityDataSet1.user);

        }
    }
}
