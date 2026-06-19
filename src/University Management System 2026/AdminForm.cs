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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InstructorForm inf = new InstructorForm();
            inf.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DepartmentForm df = new DepartmentForm();
            df.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CourseForm frm = new CourseForm();
            frm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnrollmentForm frm = new EnrollmentForm();
            frm.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Logout: close the admin form so the hidden LoginForm (caller) can re-show itself.
            this.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Open Scheduling form
            var sf = new SchedulingForm();
            sf.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Open Report and Analytics form - prefer Report_Analysis if available, otherwise fall back
            // to ReportAndAnalyticsForm. Show an error if both fail to open.
            var rep = Application.OpenForms.OfType<Report_Analysis>().FirstOrDefault();
            if (rep != null)
            {
                rep.Show();
                rep.BringToFront();
                return;
            }

            var raf = Application.OpenForms.OfType<Report_Analysis>().FirstOrDefault();
            if (raf != null)
            {
                raf.Show();
                raf.BringToFront();
                return;
            }

            try
            {
                var newRep = new Report_Analysis();
                newRep.Show();
                return;
            }
            catch (Exception ex)
            {
                try
                {
                    var newRaf = new Report_Analysis();
                    newRaf.Show();
                    return;
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("Unable to open report form: " + ex.Message + " / " + ex2.Message);
                }
            }
        }
    }
}
