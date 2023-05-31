namespace Calender
{
    public class CalenderDrawingSettings
    {
        public CalenderDrawingSettings(int weeks, int cellH, int cellW)
        {
            Weeks = weeks;
            CellH = cellH;
            CellW = cellW;
        }

        public int Weeks { get; set; }
        public int CellH { get; set; }
        public int CellW { get; set; }
    }
}