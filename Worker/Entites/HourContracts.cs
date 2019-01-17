using System;

namespace Worker.Entites
{
    class HourContracts
    {
        public DateTime Date { get; set; }
        public double valuePerHour { get; set; }
        public int  Hours { get; set; }

        public HourContracts ()
        {

        }

        public HourContracts(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            this.valuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * valuePerHour;
        }
    }
}
