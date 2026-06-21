    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Data;
    using System.Data.SqlClient;

    namespace University_Management_System_2026
    {
        public partial class SchedulingForm : Form
        {
            string conStr = @"Data Source=.\sqlexpress;
                          Initial Catalog=University;
                          Integrated Security=True";

            public SchedulingForm()
            {
                InitializeComponent();
                Theme.ApplyFormTheme(this);
                // wire event handlers
                this.button1.Click += button1_Click; // ADD
                this.button2.Click += button2_Click; // UPDATE
                this.button3.Click += button3_Click; // DELETE
                this.button4.Click += button4_Click; // CLEAR
                this.button5.Click += button5_Click; // CHECK CONFLICTS
                this.button6.Click += button6_Click; // REFRESH (already wired in Designer but safe)
                this.button7.Click += button7_Click; // BACK
                this.time_slotDataGridView.CellClick += time_slotDataGridView_CellClick;
            }

            private void time_slotBindingNavigatorSaveItem_Click(object sender, EventArgs e)
            {
                this.Validate();
                this.time_slotBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.universityDataSet1);

            }

            private void SchedulingForm_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'universityDataSet1.time_slot' table. You can move, or remove it, as needed.
                this.time_slotTableAdapter.Fill(this.universityDataSet1.time_slot);

            }

            private void LoadTimeSlots()
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        var da = new SqlDataAdapter("SELECT * FROM time_slot ORDER BY time_slot_id", con);
                        var dt = new DataTable();
                        da.Fill(dt);
                        this.time_slotBindingSource.DataSource = dt;
                        this.time_slotDataGridView.DataSource = this.time_slotBindingSource;
                        this.time_slotBindingSource.ResetBindings(false);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("DB error while loading time slots: " + ex.Message);
                }
            }

            private bool TryParseTime(string hrText, string minText, out int minutes)
            {
                minutes = 0;
                if (!int.TryParse(hrText, out int hr)) return false;
                if (!int.TryParse(minText, out int min)) return false;
                if (hr < 0 || hr > 23) return false;
                if (min < 0 || min > 59) return false;
                minutes = hr * 60 + min;
                return true;
            }

            private void button1_Click(object sender, EventArgs e)
            {
                // ADD
                var id = (time_slot_idTextBox.Text ?? "").Trim();
                var day = (dayTextBox.Text ?? "").Trim();
                var sHr = (start_hrTextBox.Text ?? "").Trim();
                var sMin = (start_minTextBox.Text ?? "").Trim();
                var eHr = (end_hrTextBox.Text ?? "").Trim();
                var eMin = (end_minTextBox.Text ?? "").Trim();

                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(day))
                {
                    MessageBox.Show("Please enter time_slot_id and day.");
                    return;
                }

                if (!TryParseTime(sHr, sMin, out int startMinutes) || !TryParseTime(eHr, eMin, out int endMinutes))
                {
                    MessageBox.Show("Invalid start/end time. Hours 0-23, minutes 0-59.");
                    return;
                }

                if (endMinutes <= startMinutes)
                {
                    MessageBox.Show("End time must be after start time.");
                    return;
                }

                try
                {
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        con.Open();
                        // Check existence using both id and day so same id can be used on different days
                        using (SqlCommand check = new SqlCommand("SELECT COUNT(1) FROM time_slot WHERE time_slot_id = @id AND day = @day", con))
                        {
                            check.Parameters.AddWithValue("@id", id);
                            check.Parameters.AddWithValue("@day", day);
                            int exists = Convert.ToInt32(check.ExecuteScalar());
                            if (exists > 0)
                            {
                                MessageBox.Show("A time slot with that ID already exists for the specified day.");
                                return;
                            }
                        }

                        // insert
                        using (SqlCommand insert = new SqlCommand("INSERT INTO time_slot(time_slot_id, day, start_hr, start_min, end_hr, end_min) VALUES(@id,@day,@shr,@smin,@ehr,@emin)", con))
                        {
                            insert.Parameters.AddWithValue("@id", id);
                            insert.Parameters.AddWithValue("@day", day);
                            insert.Parameters.AddWithValue("@shr", sHr);
                            insert.Parameters.AddWithValue("@smin", sMin);
                            insert.Parameters.AddWithValue("@ehr", eHr);
                            insert.Parameters.AddWithValue("@emin", eMin);
                            int r = insert.ExecuteNonQuery();
                            MessageBox.Show(r > 0 ? "Time slot added." : "Insert failed.");
                        }
                        con.Close();
                    }

                    LoadTimeSlots();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("DB error: " + ex.Message);
                }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                // UPDATE
                var id = (time_slot_idTextBox.Text ?? "").Trim();
                var day = (dayTextBox.Text ?? "").Trim();
                var sHr = (start_hrTextBox.Text ?? "").Trim();
                var sMin = (start_minTextBox.Text ?? "").Trim();
                var eHr = (end_hrTextBox.Text ?? "").Trim();
                var eMin = (end_minTextBox.Text ?? "").Trim();

                if (string.IsNullOrEmpty(id)) { MessageBox.Show("Enter time_slot_id to update."); return; }
                if (!TryParseTime(sHr, sMin, out int startMinutes) || !TryParseTime(eHr, eMin, out int endMinutes)) { MessageBox.Show("Invalid times."); return; }
                if (endMinutes <= startMinutes) { MessageBox.Show("End must be after start."); return; }

                try
                {
                    using (SqlConnection con = new SqlConnection(conStr))
                    using (SqlCommand cmd = new SqlCommand("UPDATE time_slot SET day=@day, start_hr=@shr, start_min=@smin, end_hr=@ehr, end_min=@emin WHERE time_slot_id=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@day", day);
                        cmd.Parameters.AddWithValue("@shr", sHr);
                        cmd.Parameters.AddWithValue("@smin", sMin);
                        cmd.Parameters.AddWithValue("@ehr", eHr);
                        cmd.Parameters.AddWithValue("@emin", eMin);
                        cmd.Parameters.AddWithValue("@id", id);
                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show(rows > 0 ? "Time slot updated." : "No time slot found to update.");
                    }

                    LoadTimeSlots();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("DB error: " + ex.Message);
                }
            }

            private void button3_Click(object sender, EventArgs e)
            {
                // DELETE
                var id = (time_slot_idTextBox.Text ?? "").Trim();
                if (string.IsNullOrEmpty(id)) { MessageBox.Show("Enter time_slot_id to delete."); return; }

                if (MessageBox.Show("Delete time slot '" + id + "'?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

                try
                {
                    using (SqlConnection con = new SqlConnection(conStr))
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM time_slot WHERE time_slot_id=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show(rows > 0 ? "Time slot deleted." : "No time slot found to delete.");
                    }

                    LoadTimeSlots();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("DB error: " + ex.Message);
                }
            }

            private void button4_Click(object sender, EventArgs e)
            {
                // CLEAR
                time_slot_idTextBox.Clear();
                dayTextBox.Clear();
                start_hrTextBox.Clear();
                start_minTextBox.Clear();
                end_hrTextBox.Clear();
                end_minTextBox.Clear();
            }

            private void button5_Click(object sender, EventArgs e)
            {
                // CHECK CONFLICTS - finds overlapping time slots on same day
                var day = (dayTextBox.Text ?? "").Trim();
                if (string.IsNullOrEmpty(day)) { MessageBox.Show("Enter day to check conflicts for."); return; }

                if (!TryParseTime(start_hrTextBox.Text, start_minTextBox.Text, out int newStart) || !TryParseTime(end_hrTextBox.Text, end_minTextBox.Text, out int newEnd))
                {
                    MessageBox.Show("Invalid time values.");
                    return;
                }

                if (newEnd <= newStart) { MessageBox.Show("End must be after start."); return; }

                try
                {
                    using (SqlConnection con = new SqlConnection(conStr))
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT time_slot_id, start_hr, start_min, end_hr, end_min FROM time_slot WHERE day = @day AND NOT ((end_hr*60 + end_min) <= @newStart OR (start_hr*60 + start_min) >= @newEnd)", con))
                    {
                        cmd.Parameters.AddWithValue("@day", day);
                        cmd.Parameters.AddWithValue("@newStart", newStart);
                        cmd.Parameters.AddWithValue("@newEnd", newEnd);
                        con.Open();
                        var dr = cmd.ExecuteReader();
                        var conflicts = new List<string>();
                        while (dr.Read())
                        {
                            var conflictId = dr[0].ToString();
                            var shr = dr[1].ToString();
                            var smin = dr[2].ToString();
                            var ehr = dr[3].ToString();
                            var emin = dr[4].ToString();
                            conflicts.Add($"{conflictId} ({shr}:{smin} - {ehr}:{emin})");
                        }
                        con.Close();

                        if (conflicts.Count == 0) MessageBox.Show("No conflicts found."); else MessageBox.Show("Conflicts:\n" + string.Join("\n", conflicts));
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("DB error: " + ex.Message);
                }
            }

            private void button6_Click(object sender, EventArgs e)
            {
                // REFRESH
                LoadTimeSlots();
            }

            private void button7_Click(object sender, EventArgs e)
            {
                // BACK - try to show existing AdminForm if present, otherwise open a new one,
                // then close this scheduling form.
                var admin = Application.OpenForms.OfType<AdminForm>().FirstOrDefault();
                if (admin != null)
                {
                    admin.Show();
                    admin.BringToFront();
                }
                else
                {
                    var af = new AdminForm();
                    af.Show();
                }

                this.Close();
            }

            private void time_slotDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex < 0) return;
                var row = time_slotDataGridView.Rows[e.RowIndex];
                time_slot_idTextBox.Text = row.Cells[0].Value?.ToString() ?? "";
                dayTextBox.Text = row.Cells[1].Value?.ToString() ?? "";
                start_hrTextBox.Text = row.Cells[2].Value?.ToString() ?? "";
                start_minTextBox.Text = row.Cells[3].Value?.ToString() ?? "";
                end_hrTextBox.Text = row.Cells[4].Value?.ToString() ?? "";
                end_minTextBox.Text = row.Cells[5].Value?.ToString() ?? "";
            }

            private void button1_Click_1(object sender, EventArgs e)
            {

            }
        }
    }
