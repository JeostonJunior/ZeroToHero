using Company.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Company
{
    internal class Program
    {
        static void Main (string[] args)
        {
            List<Employee> employes = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int employeeNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < employeeNumber; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced (y/n): ");
                string isOutsourced = Console.ReadLine();
                if (isOutsourced.Equals("y"))
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee outsourcedEmployee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employes.Add(outsourcedEmployee);
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee employee = new Employee(name, hours, valuePerHour);
                    employes.Add(employee);
                }
            }

            Console.WriteLine("\nPAYMENT:");
            foreach (var employee in employes)
            {
                Console.WriteLine($"{employee.Name} - ${employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
