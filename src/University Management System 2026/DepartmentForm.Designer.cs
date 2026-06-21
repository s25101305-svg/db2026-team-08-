namespace University_Management_System_2026
{
    partial class DepartmentForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dept_nameLabel;
            System.Windows.Forms.Label buildingLabel;
            System.Windows.Forms.Label budgetLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            this.universityDataSet1 = new University_Management_System_2026.UniversityDataSet1();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new University_Management_System_2026.UniversityDataSet1TableAdapters.departmentTableAdapter();
            this.tableAdapterManager = new University_Management_System_2026.UniversityDataSet1TableAdapters.TableAdapterManager();
            this.departmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_nameTextBox = new System.Windows.Forms.TextBox();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            dept_nameLabel = new System.Windows.Forms.Label();
            buildingLabel = new System.Windows.Forms.Label();
            budgetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dept_nameLabel
            // 
            dept_nameLabel.AutoSize = true;
            dept_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dept_nameLabel.Location = new System.Drawing.Point(11, 26);
            dept_nameLabel.Name = "dept_nameLabel";
            dept_nameLabel.Size = new System.Drawing.Size(84, 16);
            dept_nameLabel.TabIndex = 1;
            dept_nameLabel.Text = "dept name:";
            // 
            // buildingLabel
            // 
            buildingLabel.AutoSize = true;
            buildingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buildingLabel.Location = new System.Drawing.Point(11, 54);
            buildingLabel.Name = "buildingLabel";
            buildingLabel.Size = new System.Drawing.Size(66, 16);
            buildingLabel.TabIndex = 3;
            buildingLabel.Text = "building:";
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            budgetLabel.Location = new System.Drawing.Point(11, 82);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new System.Drawing.Size(59, 16);
            budgetLabel.TabIndex = 5;
            budgetLabel.Text = "budget:";
            // 
            // universityDataSet1
            // 
            this.universityDataSet1.DataSetName = "UniversityDataSet1";
            this.universityDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.universityDataSet1;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.advisorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classroomTableAdapter = null;
            this.tableAdapterManager.courseTableAdapter = null;
            this.tableAdapterManager.departmentTableAdapter = this.departmentTableAdapter;
            this.tableAdapterManager.instructorTableAdapter = null;
            this.tableAdapterManager.prereqTableAdapter = null;
            this.tableAdapterManager.sectionTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.takesTableAdapter = null;
            this.tableAdapterManager.teachesTableAdapter = null;
            this.tableAdapterManager.time_slotTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = University_Management_System_2026.UniversityDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // departmentDataGridView
            // 
            this.departmentDataGridView.AutoGenerateColumns = false;
            this.departmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.departmentDataGridView.DataSource = this.departmentBindingSource;
            this.departmentDataGridView.Location = new System.Drawing.Point(266, 116);
            this.departmentDataGridView.Name = "departmentDataGridView";
            this.departmentDataGridView.RowHeadersWidth = 51;
            this.departmentDataGridView.RowTemplate.Height = 24;
            this.departmentDataGridView.Size = new System.Drawing.Size(580, 261);
            this.departmentDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dept_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "dept_name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "building";
            this.dataGridViewTextBoxColumn2.HeaderText = "building";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "budget";
            this.dataGridViewTextBoxColumn3.HeaderText = "budget";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dept_nameTextBox
            // 
            this.dept_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "dept_name", true));
            this.dept_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept_nameTextBox.Location = new System.Drawing.Point(109, 23);
            this.dept_nameTextBox.Name = "dept_nameTextBox";
            this.dept_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.dept_nameTextBox.TabIndex = 2;
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "building", true));
            this.buildingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingTextBox.Location = new System.Drawing.Point(109, 51);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(100, 22);
            this.buildingTextBox.TabIndex = 4;
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "budget", true));
            this.budgetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetTextBox.Location = new System.Drawing.Point(109, 79);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(100, 22);
            this.budgetTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(550, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 37);
            this.button4.TabIndex = 14;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(645, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 37);
            this.button5.TabIndex = 15;
            this.button5.Text = "BACK";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.budgetTextBox);
            this.panel1.Controls.Add(budgetLabel);
            this.panel1.Controls.Add(this.buildingTextBox);
            this.panel1.Controls.Add(buildingLabel);
            this.panel1.Controls.Add(this.dept_nameTextBox);
            this.panel1.Controls.Add(dept_nameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 125);
            this.panel1.TabIndex = 16;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.departmentDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UniversityDataSet1 universityDataSet1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private UniversityDataSet1TableAdapters.departmentTableAdapter departmentTableAdapter;
        private UniversityDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView departmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox dept_nameTextBox;
        private System.Windows.Forms.TextBox buildingTextBox;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
    }
}