namespace University_Management_System_2026
{
    partial class SchedulingForm
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
            System.Windows.Forms.Label time_slot_idLabel;
            System.Windows.Forms.Label dayLabel;
            System.Windows.Forms.Label start_hrLabel;
            System.Windows.Forms.Label start_minLabel;
            System.Windows.Forms.Label end_hrLabel;
            System.Windows.Forms.Label end_minLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulingForm));
            this.universityDataSet1 = new University_Management_System_2026.UniversityDataSet1();
            this.time_slotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.time_slotTableAdapter = new University_Management_System_2026.UniversityDataSet1TableAdapters.time_slotTableAdapter();
            this.tableAdapterManager = new University_Management_System_2026.UniversityDataSet1TableAdapters.TableAdapterManager();
            this.time_slot_idTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.start_hrTextBox = new System.Windows.Forms.TextBox();
            this.start_minTextBox = new System.Windows.Forms.TextBox();
            this.end_hrTextBox = new System.Windows.Forms.TextBox();
            this.end_minTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.time_slotDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            time_slot_idLabel = new System.Windows.Forms.Label();
            dayLabel = new System.Windows.Forms.Label();
            start_hrLabel = new System.Windows.Forms.Label();
            start_minLabel = new System.Windows.Forms.Label();
            end_hrLabel = new System.Windows.Forms.Label();
            end_minLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_slotBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time_slotDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // time_slot_idLabel
            // 
            time_slot_idLabel.AutoSize = true;
            time_slot_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            time_slot_idLabel.Location = new System.Drawing.Point(6, 13);
            time_slot_idLabel.Name = "time_slot_idLabel";
            time_slot_idLabel.Size = new System.Drawing.Size(86, 16);
            time_slot_idLabel.TabIndex = 1;
            time_slot_idLabel.Text = "time slot id:";
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dayLabel.Location = new System.Drawing.Point(6, 41);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new System.Drawing.Size(37, 16);
            dayLabel.TabIndex = 3;
            dayLabel.Text = "day:";
            // 
            // start_hrLabel
            // 
            start_hrLabel.AutoSize = true;
            start_hrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            start_hrLabel.Location = new System.Drawing.Point(6, 69);
            start_hrLabel.Name = "start_hrLabel";
            start_hrLabel.Size = new System.Drawing.Size(58, 16);
            start_hrLabel.TabIndex = 5;
            start_hrLabel.Text = "start hr:";
            // 
            // start_minLabel
            // 
            start_minLabel.AutoSize = true;
            start_minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            start_minLabel.Location = new System.Drawing.Point(6, 97);
            start_minLabel.Name = "start_minLabel";
            start_minLabel.Size = new System.Drawing.Size(69, 16);
            start_minLabel.TabIndex = 7;
            start_minLabel.Text = "start min:";
            // 
            // end_hrLabel
            // 
            end_hrLabel.AutoSize = true;
            end_hrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            end_hrLabel.Location = new System.Drawing.Point(6, 125);
            end_hrLabel.Name = "end_hrLabel";
            end_hrLabel.Size = new System.Drawing.Size(54, 16);
            end_hrLabel.TabIndex = 9;
            end_hrLabel.Text = "end hr:";
            // 
            // end_minLabel
            // 
            end_minLabel.AutoSize = true;
            end_minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            end_minLabel.Location = new System.Drawing.Point(6, 153);
            end_minLabel.Name = "end_minLabel";
            end_minLabel.Size = new System.Drawing.Size(65, 16);
            end_minLabel.TabIndex = 11;
            end_minLabel.Text = "end min:";
            // 
            // universityDataSet1
            // 
            this.universityDataSet1.DataSetName = "UniversityDataSet1";
            this.universityDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // time_slotBindingSource
            // 
            this.time_slotBindingSource.DataMember = "time_slot";
            this.time_slotBindingSource.DataSource = this.universityDataSet1;
            // 
            // time_slotTableAdapter
            // 
            this.time_slotTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.advisorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classroomTableAdapter = null;
            this.tableAdapterManager.courseTableAdapter = null;
            this.tableAdapterManager.departmentTableAdapter = null;
            this.tableAdapterManager.instructorTableAdapter = null;
            this.tableAdapterManager.prereqTableAdapter = null;
            this.tableAdapterManager.sectionTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.takesTableAdapter = null;
            this.tableAdapterManager.teachesTableAdapter = null;
            this.tableAdapterManager.time_slotTableAdapter = this.time_slotTableAdapter;
            this.tableAdapterManager.UpdateOrder = University_Management_System_2026.UniversityDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // time_slot_idTextBox
            // 
            this.time_slot_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.time_slotBindingSource, "time_slot_id", true));
            this.time_slot_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_slot_idTextBox.Location = new System.Drawing.Point(107, 10);
            this.time_slot_idTextBox.Name = "time_slot_idTextBox";
            this.time_slot_idTextBox.Size = new System.Drawing.Size(117, 22);
            this.time_slot_idTextBox.TabIndex = 2;
            // 
            // dayTextBox
            // 
            this.dayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.time_slotBindingSource, "day", true));
            this.dayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTextBox.Location = new System.Drawing.Point(107, 38);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(117, 22);
            this.dayTextBox.TabIndex = 4;
            // 
            // start_hrTextBox
            // 
            this.start_hrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.time_slotBindingSource, "start_hr", true));
            this.start_hrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_hrTextBox.Location = new System.Drawing.Point(107, 66);
            this.start_hrTextBox.Name = "start_hrTextBox";
            this.start_hrTextBox.Size = new System.Drawing.Size(117, 22);
            this.start_hrTextBox.TabIndex = 6;
            // 
            // start_minTextBox
            // 
            this.start_minTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.time_slotBindingSource, "start_min", true));
            this.start_minTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_minTextBox.Location = new System.Drawing.Point(107, 94);
            this.start_minTextBox.Name = "start_minTextBox";
            this.start_minTextBox.Size = new System.Drawing.Size(117, 22);
            this.start_minTextBox.TabIndex = 8;
            // 
            // end_hrTextBox
            // 
            this.end_hrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.time_slotBindingSource, "end_hr", true));
            this.end_hrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_hrTextBox.Location = new System.Drawing.Point(107, 122);
            this.end_hrTextBox.Name = "end_hrTextBox";
            this.end_hrTextBox.Size = new System.Drawing.Size(117, 22);
            this.end_hrTextBox.TabIndex = 10;
            // 
            // end_minTextBox
            // 
            this.end_minTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.time_slotBindingSource, "end_min", true));
            this.end_minTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_minTextBox.Location = new System.Drawing.Point(107, 150);
            this.end_minTextBox.Name = "end_minTextBox";
            this.end_minTextBox.Size = new System.Drawing.Size(117, 22);
            this.end_minTextBox.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dayTextBox);
            this.panel1.Controls.Add(time_slot_idLabel);
            this.panel1.Controls.Add(this.end_minTextBox);
            this.panel1.Controls.Add(this.time_slot_idTextBox);
            this.panel1.Controls.Add(end_minLabel);
            this.panel1.Controls.Add(dayLabel);
            this.panel1.Controls.Add(this.end_hrTextBox);
            this.panel1.Controls.Add(end_hrLabel);
            this.panel1.Controls.Add(start_hrLabel);
            this.panel1.Controls.Add(this.start_minTextBox);
            this.panel1.Controls.Add(this.start_hrTextBox);
            this.panel1.Controls.Add(start_minLabel);
            this.panel1.Location = new System.Drawing.Point(25, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 187);
            this.panel1.TabIndex = 13;
            // 
            // time_slotDataGridView
            // 
            this.time_slotDataGridView.AutoGenerateColumns = false;
            this.time_slotDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.time_slotDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.time_slotDataGridView.DataSource = this.time_slotBindingSource;
            this.time_slotDataGridView.Location = new System.Drawing.Point(293, 109);
            this.time_slotDataGridView.Name = "time_slotDataGridView";
            this.time_slotDataGridView.RowHeadersWidth = 51;
            this.time_slotDataGridView.RowTemplate.Height = 24;
            this.time_slotDataGridView.Size = new System.Drawing.Size(811, 220);
            this.time_slotDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "time_slot_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "time_slot_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "day";
            this.dataGridViewTextBoxColumn2.HeaderText = "day";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "start_hr";
            this.dataGridViewTextBoxColumn3.HeaderText = "start_hr";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "start_min";
            this.dataGridViewTextBoxColumn4.HeaderText = "start_min";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "end_hr";
            this.dataGridViewTextBoxColumn5.HeaderText = "end_hr";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "end_min";
            this.dataGridViewTextBoxColumn6.HeaderText = "end_min";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 37);
            this.button2.TabIndex = 16;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 37);
            this.button3.TabIndex = 17;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(577, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 37);
            this.button4.TabIndex = 18;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(815, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 37);
            this.button5.TabIndex = 19;
            this.button5.Text = "CHECK CONFLICTS";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(998, 56);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 37);
            this.button6.TabIndex = 20;
            this.button6.Text = "REFERESH";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(676, 56);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 37);
            this.button7.TabIndex = 21;
            this.button7.Text = "BACK";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // SchedulingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 420);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.time_slotDataGridView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SchedulingForm";
            this.Text = "SchedulingForm";
            this.Load += new System.EventHandler(this.SchedulingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_slotBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time_slotDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UniversityDataSet1 universityDataSet1;
        private System.Windows.Forms.BindingSource time_slotBindingSource;
        private UniversityDataSet1TableAdapters.time_slotTableAdapter time_slotTableAdapter;
        private UniversityDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox time_slot_idTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox start_hrTextBox;
        private System.Windows.Forms.TextBox start_minTextBox;
        private System.Windows.Forms.TextBox end_hrTextBox;
        private System.Windows.Forms.TextBox end_minTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView time_slotDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}