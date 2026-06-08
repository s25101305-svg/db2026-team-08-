using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            this.departmentTableAdapter.Fill(this.universityDataSet.department);
            this.courseTableAdapter.Fill(this.universityDataSet.course);
            this.userTableAdapter.Fill(this.universityDataSet1.user);

            using (var db = new UniversityEntities())
            {
                // =========================
                // CHART 1 - COURSE ENROLLMENTS
                // =========================
                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.ChartAreas.Clear();

                ChartArea area1 = new ChartArea("Area1");
                area1.AxisX.MajorGrid.Enabled = false;
                area1.AxisY.MajorGrid.LineColor = Color.LightGray;
                area1.AxisX.LabelStyle.Angle = -45;
                area1.AxisX.Interval = 1;

                chart1.ChartAreas.Add(area1);
                chart1.Titles.Add("Course Enrollment Analysis");

                var enrollByCourse = db.takes
                    .GroupBy(t => t.course_id)
                    .Select(g => new
                    {
                        Course = g.Key,
                        Count = g.Count()
                    })
                    .OrderByDescending(x => x.Count)
                    .Take(10)
                    .ToList();

                Series series1 = new Series("Enrollments");
                series1.ChartType = SeriesChartType.Column;
                series1.Color = Color.FromArgb(52, 152, 219);
                series1.IsValueShownAsLabel = true;
                series1.ToolTip = "#VALX : #VAL";

                foreach (var item in enrollByCourse)
                {
                    series1.Points.AddXY(item.Course, item.Count);
                }

                chart1.Series.Add(series1);


                // =========================
                // CHART 2 - STUDENTS PER DEPARTMENT
                // =========================
                chart2.Series.Clear();
                chart2.Titles.Clear();
                chart2.ChartAreas.Clear();

                ChartArea area2 = new ChartArea("Area2");
                area2.AxisX.MajorGrid.LineColor = Color.LightGray;
                area2.AxisY.MajorGrid.Enabled = false;

                chart2.ChartAreas.Add(area2);
                chart2.Titles.Add("Department Population");

                var studentsByDept = db.students
                    .GroupBy(s => s.dept_name)
                    .Select(g => new
                    {
                        Dept = g.Key,
                        Count = g.Count()
                    })
                    .OrderByDescending(x => x.Count)
                    .ToList();

                Series series2 = new Series("Students");
                series2.ChartType = SeriesChartType.Bar;
                series2.Color = Color.FromArgb(46, 204, 113);
                series2.IsValueShownAsLabel = true;
                series2.ToolTip = "#VALX : #VAL";

                foreach (var item in studentsByDept)
                {
                    series2.Points.AddXY(item.Dept, item.Count);
                }

                chart2.Series.Add(series2);


                // =========================
                // CHART 3 - GRADE DISTRIBUTION
                // =========================
                chart3.Series.Clear();
                chart3.Titles.Clear();
                chart3.ChartAreas.Clear();

                ChartArea area3 = new ChartArea("Area3");
                chart3.ChartAreas.Add(area3);

                chart3.Titles.Add("Academic Performance Distribution");

                var gradeDist = db.takes
                    .Where(t => t.grade != null)
                    .GroupBy(t => t.grade)
                    .Select(g => new
                    {
                        Grade = g.Key,
                        Count = g.Count()
                    })
                    .OrderByDescending(x => x.Count)
                    .ToList();

                Series series3 = new Series("Grades");
                series3.ChartType = SeriesChartType.Doughnut;
                series3.IsValueShownAsLabel = true;
                series3.Label = "#VALX\n#PERCENT{P0}";
                series3.ToolTip = "#VALX : #VAL";

                foreach (var item in gradeDist)
                {
                    series3.Points.AddXY(item.Grade, item.Count);
                }

                chart3.Series.Add(series3);

                // Doughnut hole size
                series3["DoughnutRadius"] = "60";

                // Better colors
                chart3.Palette = ChartColorPalette.BrightPastel;


                // =========================
                // COMMON STYLING
                // =========================
                chart1.BackColor = Color.WhiteSmoke;
                chart2.BackColor = Color.WhiteSmoke;
                chart3.BackColor = Color.WhiteSmoke;

                chart1.Legends[0].Enabled = false;
                chart2.Legends[0].Enabled = false;

                chart3.Legends[0].Docking = Docking.Right;

                chart1.BorderlineColor = Color.LightGray;
                chart2.BorderlineColor = Color.LightGray;
                chart3.BorderlineColor = Color.LightGray;
            }
        }

        

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
