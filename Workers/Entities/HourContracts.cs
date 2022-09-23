using System;

namespace Workers.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hour { get; set; }
        public HourContract () { }
        public HourContract (DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }
        public double totalValue ()
        {
            return ValuePerHour * Hour;
        }
    }
}