namespace Company.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public int Hours { get; protected set; }
        public double ValuePerHour { get; protected set; }

        public Employee (string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment ()
        {
            return Hours * ValuePerHour;
        }
    }
}
