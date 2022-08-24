using System.Globalization;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Name = "John";
            employee.Wage = 6000.00;
            employee.Tax = 1000.00;

            employee.ViewEmployee();

            employee.WageIncrement(-10.0);
            employee.ViewEmployee();

        }
    }
}