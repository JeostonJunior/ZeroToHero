using System.Globalization;

namespace Employee
{
    public class Employee
    {
        public string Name;
        public double Wage;
        public double Tax;

        public double NetSalary()
        {
            double netSalary;
            netSalary = Wage - Tax;
            return netSalary;
        }

        public double WageIncrement(double porcentage)
        {
            double wageIncrement;
            wageIncrement = Wage * (porcentage / 100);
            Wage += wageIncrement;
            return Wage;
        }

        public void ViewEmployee()
        {
            Console.WriteLine($"Employee Name: {Name} | NetSalary: {NetSalary().ToString("F2", CultureInfo.InvariantCulture)}");
        }


    }
}