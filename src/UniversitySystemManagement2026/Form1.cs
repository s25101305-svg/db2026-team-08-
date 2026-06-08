using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniversitySystemManagement2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet);

        }

        private void studentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet.takes' table. You can move, or remove it, as needed.
            this.takesTableAdapter.Fill(this.universityDataSet.takes);
            // TODO: This line of code loads data into the 'universityDataSet.takes' table. You can move, or remove it, as needed.
            this.takesTableAdapter.Fill(this.universityDataSet.takes);
            // TODO: This line of code loads data into the 'universityDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.universityDataSet.student);

            this.takesTableAdapter.Fill(this.universityDataSet.takes);
            this.studentTableAdapter.Fill(this.universityDataSet.student);

            // course options
            using (var db = new UniversityEntities())
            {
                cmbBox0.DataSource = db.courses.ToList();
                cmbBox0.DisplayMember = "course_id";
                cmbBox0.ValueMember = "course_id";
            }

            // sec_id options
            cmbBox1.DataSource = null;
            cmbBox1.Items.Clear();
            cmbBox1.Items.Add("1");
            cmbBox1.Items.Add("2");

            // semester options
            cmbBox2.DataSource = null;
            cmbBox2.Items.Clear();
            cmbBox2.Items.Add("Fall");
            cmbBox2.Items.Add("Spring");
            cmbBox2.Items.Add("Summer");

            // year options
            cmbBox3.DataSource = null;
            cmbBox3.Items.Clear();
            cmbBox3.Items.Add("2017");
            cmbBox3.Items.Add("2018");
            cmbBox3.Items.Add("2019");
        }

        private void enrBtn_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityEntities())
            {
                var enroll = new take()
                {
                    ID = iDTextBox.Text,
                    course_id = cmbBox0.Text,
                    sec_id = cmbBox1.Text,
                    semester = cmbBox2.Text,
                    year = int.Parse(cmbBox3.Text),
                    grade = null
                };
                db.takes.Add(enroll);
                db.SaveChanges();
                MessageBox.Show("Enrolled successfully!");
            }
        }

        private void drpBtn_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityEntities())
            {
                var selected = takesDataGridView.CurrentRow;
                if (selected == null) return;

                var course = selected.Cells[1].Value.ToString();    
                var enroll = db.takes
                               .Where(t => t.ID == iDTextBox.Text &&
                                           t.course_id == course)
                               .FirstOrDefault();
                if (enroll != null)
                {
                    db.takes.Remove(enroll);
                    db.SaveChanges();
                    MessageBox.Show("Dropped successfully!");
                }
            }
        }
    }
}
