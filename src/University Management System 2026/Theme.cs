using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace University_Management_System_2026
{
    public static class Theme
    {
        // Dark Navy Palette
        public static readonly Color BackDark = Color.FromArgb(15, 23, 42);       // #0F172A
        public static readonly Color CardDark = Color.FromArgb(30, 41, 59);       // #1E293B
        public static readonly Color AccentBlue = Color.FromArgb(59, 130, 246);   // #3B82F6
        public static readonly Color AccentBlueHover = Color.FromArgb(37, 99, 235); // #2563EB
        public static readonly Color TextPrimary = Color.FromArgb(248, 250, 252); // #F8FAFC
        public static readonly Color TextMuted = Color.FromArgb(148, 163, 184);   // #94A3B8
        public static readonly Color InputBg = Color.FromArgb(51, 65, 85);        // #334155
        public static readonly Color InputBorder = Color.FromArgb(71, 85, 105);   // #475569
        public static readonly Color AccentAmber = Color.FromArgb(245, 158, 11);  // #F59E0B
        public static readonly Color RedDelete = Color.FromArgb(239, 68, 68);     // #EF4444
        public static readonly Color RedDeleteHover = Color.FromArgb(220, 38, 38); // #DC2626

        // Modern Fonts
        public static readonly Font TitleFont = new Font("Segoe UI", 18F, FontStyle.Bold);
        public static readonly Font SubtitleFont = new Font("Segoe UI", 11F, FontStyle.Regular);
        public static readonly Font LabelFont = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        public static readonly Font ValueFont = new Font("Segoe UI", 11F, FontStyle.Regular);
        public static readonly Font ButtonFont = new Font("Segoe UI", 10F, FontStyle.Bold);
        public static readonly Font HeaderFont = new Font("Segoe UI", 14F, FontStyle.Bold);

        public static void ApplyButtonTheme(Button btn, bool isPrimary = true)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = ButtonFont;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            
            if (isPrimary)
            {
                btn.BackColor = AccentBlue;
                btn.ForeColor = TextPrimary;
                btn.FlatAppearance.MouseOverBackColor = AccentBlueHover;
                btn.FlatAppearance.MouseDownBackColor = AccentBlueHover;
            }
            else
            {
                btn.BackColor = CardDark;
                btn.ForeColor = TextPrimary;
                btn.FlatAppearance.MouseOverBackColor = InputBg;
                btn.FlatAppearance.MouseDownBackColor = InputBg;
            }
        }
        
        public static void ApplySidebarButtonTheme(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = ButtonFont;
            btn.ForeColor = TextMuted;
            btn.BackColor = Color.Transparent;
            btn.FlatAppearance.BorderSize = 0;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(20, 0, 0, 0);
            btn.Cursor = Cursors.Hand;
            
            btn.MouseEnter += (s, e) => {
                btn.ForeColor = TextPrimary;
                btn.BackColor = InputBg;
            };
            btn.MouseLeave += (s, e) => {
                btn.ForeColor = TextMuted;
                btn.BackColor = Color.Transparent;
            };
        }

        public static void ApplyTextBoxTheme(TextBox txt)
        {
            txt.BackColor = InputBg;
            txt.ForeColor = TextPrimary;
            txt.Font = ValueFont;
            txt.BorderStyle = BorderStyle.FixedSingle;
        }

        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = CardDark;
            dgv.ForeColor = TextPrimary;
            dgv.GridColor = InputBorder;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            
            // Header Styles
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = BackDark;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextPrimary;
            dgv.ColumnHeadersDefaultCellStyle.Font = LabelFont;
            dgv.ColumnHeadersHeight = 35;
            
            // Row Styles
            dgv.RowsDefaultCellStyle.BackColor = CardDark;
            dgv.RowsDefaultCellStyle.ForeColor = TextPrimary;
            dgv.RowsDefaultCellStyle.SelectionBackColor = AccentBlue;
            dgv.RowsDefaultCellStyle.SelectionForeColor = TextPrimary;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = InputBg;
            
            // Selection / General
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToResizeRows = false;
        }

        public static void StyleChart(Chart chart)
        {
            chart.BackColor = CardDark;
            chart.BorderlineColor = Color.Transparent;

            // Background & Border for areas
            foreach (var area in chart.ChartAreas)
            {
                area.BackColor = CardDark;
                area.AxisX.LabelStyle.ForeColor = TextMuted;
                area.AxisY.LabelStyle.ForeColor = TextMuted;
                area.AxisX.LineColor = InputBorder;
                area.AxisY.LineColor = InputBorder;
                area.AxisX.MajorGrid.LineColor = InputBg;
                area.AxisY.MajorGrid.LineColor = InputBg;
            }

            // Legend style
            foreach (var legend in chart.Legends)
            {
                legend.BackColor = CardDark;
                legend.ForeColor = TextPrimary;
                legend.Font = SubtitleFont;
            }

            // Series colors
            foreach (var series in chart.Series)
            {
                series.Color = AccentBlue;
                series.Font = SubtitleFont;
                series.LabelForeColor = TextPrimary;
            }
        }

        public static void ApplyFormTheme(Form frm)
        {
            frm.BackColor = BackDark;
            frm.ForeColor = TextPrimary;
            frm.Font = ValueFont;
            frm.StartPosition = FormStartPosition.CenterScreen;
            
            ApplyControlsTheme(frm.Controls);
        }

        private static void ApplyControlsTheme(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Button btn)
                {
                    string txt = btn.Text.ToLower();
                    if (txt.Contains("delete") || txt.Contains("remove"))
                    {
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Font = ButtonFont;
                        btn.ForeColor = TextPrimary;
                        btn.BackColor = RedDelete;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.FlatAppearance.MouseOverBackColor = RedDeleteHover;
                        btn.FlatAppearance.MouseDownBackColor = RedDeleteHover;
                        btn.Cursor = Cursors.Hand;
                    }
                    else if (txt.Contains("clear") || txt.Contains("cancel") || txt.Contains("back") || txt.Contains("close") || txt.Contains("reset"))
                    {
                        ApplyButtonTheme(btn, isPrimary: false);
                    }
                    else
                    {
                        ApplyButtonTheme(btn, isPrimary: true);
                    }
                }
                else if (ctrl is TextBox txtBox)
                {
                    ApplyTextBoxTheme(txtBox);
                }
                else if (ctrl is ComboBox combo)
                {
                    combo.BackColor = InputBg;
                    combo.ForeColor = TextPrimary;
                    combo.FlatStyle = FlatStyle.Flat;
                    combo.Font = ValueFont;
                }
                else if (ctrl is Label lbl)
                {
                    if (lbl.Font.Size > 13)
                    {
                        lbl.Font = HeaderFont;
                        lbl.ForeColor = TextPrimary;
                    }
                    else
                    {
                        lbl.Font = ValueFont;
                        lbl.ForeColor = TextPrimary;
                    }
                }
                else if (ctrl is DataGridView dgv)
                {
                    StyleDataGridView(dgv);
                }
                else if (ctrl is Chart chartCtrl)
                {
                    StyleChart(chartCtrl);
                }
                else if (ctrl is Panel pnl)
                {
                    pnl.BackColor = CardDark;
                    pnl.BorderStyle = BorderStyle.None;
                    ApplyControlsTheme(pnl.Controls);
                }
                else if (ctrl is GroupBox grp)
                {
                    grp.BackColor = CardDark;
                    grp.ForeColor = TextPrimary;
                    grp.Font = LabelFont;
                    ApplyControlsTheme(grp.Controls);
                }
                else if (ctrl.HasChildren)
                {
                    ApplyControlsTheme(ctrl.Controls);
                }
            }
        }
    }
}
