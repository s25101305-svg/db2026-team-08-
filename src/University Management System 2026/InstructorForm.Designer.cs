namespace University_Management_System_2026
{
    partial class InstructorForm
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label dept_nameLabel;
            System.Windows.Forms.Label salaryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorForm));
            this.universityDataSet1 = new University_Management_System_2026.UniversityDataSet1();
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorTableAdapter = new University_Management_System_2026.UniversityDataSet1TableAdapters.instructorTableAdapter();
            this.tableAdapterManager = new University_Management_System_2026.UniversityDataSet1TableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dept_nameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.instructorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            dept_nameLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(11, 41);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(34, 20);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(11, 77);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(60, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name:";
            // 
            // dept_nameLabel
            // 
            dept_nameLabel.AutoSize = true;
            dept_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dept_nameLabel.Location = new System.Drawing.Point(10, 117);
            dept_nameLabel.Name = "dept_nameLabel";
            dept_nameLabel.Size = new System.Drawing.Size(102, 20);
            dept_nameLabel.TabIndex = 5;
            dept_nameLabel.Text = "dept name:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salaryLabel.Location = new System.Drawing.Point(11, 153);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(66, 20);
            salaryLabel.TabIndex = 7;
            salaryLabel.Text = "salary:";
            // 
            // universityDataSet1
            // 
            this.universityDataSet1.DataSetName = "UniversityDataSet1";
            this.universityDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instructorBindingSource
            // 
            this.instructorBindingSource.DataMember = "instructor";
            this.instructorBindingSource.DataSource = this.universityDataSet1;
            // 
            // instructorTableAdapter
            // 
            this.instructorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.advisorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classroomTableAdapter = null;
            this.tableAdapterManager.courseTableAdapter = null;
            this.tableAdapterManager.departmentTableAdapter = null;
            this.tableAdapterManager.instructorTableAdapter = this.instructorTableAdapter;
            this.tableAdapterManager.prereqTableAdapter = null;
            this.tableAdapterManager.sectionTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.takesTableAdapter = null;
            this.tableAdapterManager.teachesTableAdapter = null;
            this.tableAdapterManager.time_slotTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = University_Management_System_2026.UniversityDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instructorBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.Location = new System.Drawing.Point(147, 36);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(128, 27);
            this.iDTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instructorBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(147, 72);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(128, 27);
            this.nameTextBox.TabIndex = 4;
            // 
            // dept_nameTextBox
            // 
            this.dept_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instructorBindingSource, "dept_name", true));
            this.dept_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept_nameTextBox.Location = new System.Drawing.Point(146, 112);
            this.dept_nameTextBox.Name = "dept_nameTextBox";
            this.dept_nameTextBox.Size = new System.Drawing.Size(129, 27);
            this.dept_nameTextBox.TabIndex = 6;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instructorBindingSource, "salary", true));
            this.salaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryTextBox.Location = new System.Drawing.Point(147, 148);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(128, 27);
            this.salaryTextBox.TabIndex = 8;
            // 
            // instructorDataGridView
            // 
            this.instructorDataGridView.AutoGenerateColumns = false;
            this.instructorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instructorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.instructorDataGridView.DataSource = this.instructorBindingSource;
            this.instructorDataGridView.Location = new System.Drawing.Point(327, 143);
            this.instructorDataGridView.Name = "instructorDataGridView";
            this.instructorDataGridView.RowHeadersWidth = 51;
            this.instructorDataGridView.RowTemplate.Height = 24;
            this.instructorDataGridView.Size = new System.Drawing.Size(555, 301);
            this.instructorDataGridView.TabIndex = 8;
            this.instructorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.instructorDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dept_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "dept_name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "salary";
            this.dataGridViewTextBoxColumn4.HeaderText = "salary";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(522, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 37);
            this.button3.TabIndex = 12;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(618, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 37);
            this.button4.TabIndex = 13;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(714, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 37);
            this.button5.TabIndex = 14;
            this.button5.Text = "BACK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.salaryTextBox);
            this.panel1.Controls.Add(salaryLabel);
            this.panel1.Controls.Add(this.dept_nameTextBox);
            this.panel1.Controls.Add(dept_nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.iDTextBox);
            this.panel1.Controls.Add(iDLabel);
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 198);
            this.panel1.TabIndex = 15;
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.instructorDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstructorForm";
            this.Text = "InstructorForm";
            this.Load += new System.EventHandler(this.InstructorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UniversityDataSet1 universityDataSet1;
        private System.Windows.Forms.BindingSource instructorBindingSource;
        private UniversityDataSet1TableAdapters.instructorTableAdapter instructorTableAdapter;
        private UniversityDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox dept_nameTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.DataGridView instructorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
    }
}