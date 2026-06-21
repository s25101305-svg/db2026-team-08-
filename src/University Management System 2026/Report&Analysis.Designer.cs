namespace University_Management_System_2026
{
    partial class Report_Analysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Analysis));
            this.chartAnalytics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.universityDataSet1 = new University_Management_System_2026.UniversityDataSet();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalytics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartAnalytics
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAnalytics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAnalytics.Legends.Add(legend1);
            this.chartAnalytics.Location = new System.Drawing.Point(384, 121);
            this.chartAnalytics.Name = "chartAnalytics";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAnalytics.Series.Add(series1);
            this.chartAnalytics.Size = new System.Drawing.Size(641, 189);
            this.chartAnalytics.TabIndex = 0;
            this.chartAnalytics.Text = "chart1";
            this.chartAnalytics.Click += new System.EventHandler(this.chartAnalytics_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Enrollment";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // universityDataSet1
            // 
            this.universityDataSet1.DataSetName = "UniversityDataSet";
            this.universityDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(384, 467);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(641, 239);
            this.dgvReport.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 46);
            this.button4.TabIndex = 5;
            this.button4.Text = "Student Report";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(31, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 46);
            this.button5.TabIndex = 6;
            this.button5.Text = "Course Report";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(31, 164);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(208, 46);
            this.button6.TabIndex = 7;
            this.button6.Text = "Enrollment Report";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(947, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 40);
            this.button7.TabIndex = 14;
            this.button7.Text = "CLOSE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 69);
            this.label1.TabIndex = 9;
            this.label1.Text = "REPORT";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(512, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 100);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(486, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 100);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 69);
            this.label2.TabIndex = 9;
            this.label2.Text = "ANALYTICS";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Location = new System.Drawing.Point(77, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 250);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(60, 430);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(302, 260);
            this.panel4.TabIndex = 13;
            // 
            // Report_Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 770);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.chartAnalytics);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report_Analysis";
            this.Text = "Report & Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalytics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalytics;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private UniversityDataSet universityDataSet1;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}