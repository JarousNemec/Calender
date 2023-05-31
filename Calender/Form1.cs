using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calender
{
    public partial class Form1 : Form
    {
        private DateTime _actualDate;
        private CalenderDrawingSettings _settings;

        public Form1()
        {
            InitializeComponent();
            _actualDate = DateTime.Today;
        }

        private void _btnBackward_Click(object sender, EventArgs e)
        {
            if (_actualDate.Month > 1)
                _actualDate = new DateTime(_actualDate.Year, _actualDate.Month - 1, 1);
            else
                _actualDate = new DateTime(_actualDate.Year - 1, 12, 1);
            _pnlDisplay.Invalidate();
        }

        private void _btnForward_Click(object sender, EventArgs e)
        {
            if (_actualDate.Month < 12)
                _actualDate = new DateTime(_actualDate.Year, _actualDate.Month + 1, 1);
            else
                _actualDate = new DateTime(_actualDate.Year + 1, 1, 1);
            _pnlDisplay.Invalidate();
        }

        private void _pnlDisplay_Paint(object sender, PaintEventArgs e)
        {
            DisplayCalender(e.Graphics);
        }

        private void DisplayCalender(Graphics g)
        {
            _lblActualDate.Text = $@"{_actualDate.Month}.{_actualDate.Year}";
            _settings = CalculateSettings();
            DrawCalenderGrid(g);
            DrawNumbers(g);
            MarkTodayCell(g);
        }

        private CalenderDrawingSettings CalculateSettings()
        {
            int weeks = DateTime.DaysInMonth(_actualDate.Year, _actualDate.Month) % 7 > 0
                ? DateTime.DaysInMonth(_actualDate.Year, _actualDate.Month) / 7 + 1
                : DateTime.DaysInMonth(_actualDate.Year, _actualDate.Month) / 7;
            int cellW = _pnlDisplay.Width / 7;
            int cellH = _pnlDisplay.Height / weeks;
            return new CalenderDrawingSettings(weeks, cellH, cellW);
        }

        private void MarkTodayCell(Graphics g)
        {
            if (_actualDate.Month != DateTime.Now.Month || _actualDate.Year != DateTime.Now.Year) return;
            var x = (_actualDate.Day % 7 - 1) * _settings.CellW;
            var y = _actualDate.Day / 7 * _settings.CellH;
            g.DrawRectangle(Pens.Red, x, y, _settings.CellW, _settings.CellH);
        }

        private void DrawNumbers(Graphics g)
        {
            int day = 1;
            var startPos = new PointF(_settings.CellW / 2, _settings.CellH / 2);
            for (int i = 0; i < _settings.Weeks; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    g.DrawString(day.ToString(), new Font(FontFamily.GenericSansSerif, 14), Brushes.Black,
                        startPos.X + j * _settings.CellW - 14, startPos.Y + i * _settings.CellH - 14);
                    day++;
                    if (day > DateTime.DaysInMonth(_actualDate.Year, _actualDate.Month)) return;
                }
            }
        }

        private void DrawCalenderGrid(Graphics g)
        {
            g.Clear(Color.White);
            g.Flush();
            for (int i = 0; i <= 7; i++)
            {
                g.DrawLine(Pens.Black, i * _settings.CellW, 0, i * _settings.CellW, _settings.CellH * 7);
            }

            for (int i = 0; i <= _settings.Weeks; i++)
            {
                g.DrawLine(Pens.Black, 0, i * _settings.CellH, _pnlDisplay.Width, i * _settings.CellH);
            }
        }


        private void _pnlDisplay_Resize(object sender, EventArgs e)
        {
            _pnlDisplay.Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            _pnlDisplay.Invalidate();
        }

        private void _pnlDisplay_AutoSizeChanged(object sender, EventArgs e)
        {
            _pnlDisplay.Invalidate();
        }

        private void _pnlDisplay_ParentChanged(object sender, EventArgs e)
        {
            _pnlDisplay.Invalidate();
        }

        private void _pnlDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X / _settings.CellW + 1;
            int y = e.Y / _settings.CellH;
            int day = y * 7 + x;
            int month = _actualDate.Month;
            int year = _actualDate.Year;
            
            if (DateTime.DaysInMonth(year, month) < day)
            {
                day -= DateTime.DaysInMonth(year, month);
                if (month >= 12)
                {
                    month = 1;
                    year++;
                }
                else
                {
                    month++;
                }
            }
            
            var plan = new DayPlanForm();
            plan.LoadDate(new DateTime(year, month, day));
            plan.Show();
        }
    }
}