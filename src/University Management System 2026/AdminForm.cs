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
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = Theme.BackDark;

            // Sidebar
            panel1.BackColor = Theme.CardDark;
            sidebarHeaderLabel.ForeColor = Theme.TextPrimary;
            sidebarSubLabel.ForeColor = Theme.TextMuted;

            // Sidebar navigation buttons
            Theme.ApplySidebarButtonTheme(button1); // Student
            Theme.ApplySidebarButtonTheme(button2); // Instructors
            Theme.ApplySidebarButtonTheme(button3); // Department
            Theme.ApplySidebarButtonTheme(button5); // Course
            Theme.ApplySidebarButtonTheme(button4); // Enrollment
            Theme.ApplySidebarButtonTheme(button7); // Scheduling
            Theme.ApplySidebarButtonTheme(button8); // Report & Analytics

            // Special red style for Logout button
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = Theme.ButtonFont;
            button6.ForeColor = Theme.TextPrimary;
            button6.BackColor = Theme.RedDelete;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Theme.RedDeleteHover;
            button6.FlatAppearance.MouseDownBackColor = Theme.RedDeleteHover;
            button6.Cursor = System.Windows.Forms.Cursors.Hand;

            // Header panel
            panel2.BackColor = Theme.CardDark;
            label1.ForeColor = Theme.TextPrimary;

            // Stats Cards
            StyleStatCard(card1, card1Title, card1Value);
            StyleStatCard(card2, card2Title, card2Value);
            StyleStatCard(card3, card3Title, card3Value);
            StyleStatCard(card4, card4Title, card4Value);

            // Welcome Panel
            welcomePanel.BackColor = Theme.CardDark;
            welcomeTitleLabel.ForeColor = Theme.TextPrimary;
            welcomeDescLabel.ForeColor = Theme.TextMuted;
        }

        private void StyleStatCard(Panel card, Label title, Label value)
        {
            card.BackColor = Theme.CardDark;
            title.ForeColor = Theme.TextMuted;
            value.ForeColor = Theme.TextPrimary;

            // Add a subtle border highlight on hover
            card.MouseEnter += (s, e) => {
                card.BackColor = Theme.InputBg;
            };
            card.MouseLeave += (s, e) => {
                card.BackColor = Theme.CardDark;
            };
            title.MouseEnter += (s, e) => {
                card.BackColor = Theme.InputBg;
            };
            title.MouseLeave += (s, e) => {
                card.BackColor = Theme.CardDark;
            };
            value.MouseEnter += (s, e) => {
                card.BackColor = Theme.InputBg;
            };
            value.MouseLeave += (s, e) => {
                card.BackColor = Theme.CardDark;
            };
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
