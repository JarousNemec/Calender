using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calender
{
    public partial class DayPlanForm : Form
    {
        public DayPlanForm()
        {
            InitializeComponent();
        }

        public void LoadDate(string date)
        {
            _lblDate.Text = date;
        }
        private void _pnlPlan_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var lineH = _pnlPlan.Height / 24;
            for (int i = 0; i < 24; i++)
            {
                g.DrawLine(Pens.Black, 0,i*lineH, _pnlPlan.Width, i*lineH);
                g.DrawString((i+1).ToString()+":00", new Font(FontFamily.GenericSansSerif, 12),Brushes.Black, 5, i*lineH+2);
            }
        }
    }
}