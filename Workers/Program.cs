using System;
using System.Globalization;
using Workers.Entities;
using Workers.Entities.Enums;

namespace Workers
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Worker worker;

            Console.WriteLine("Enter department's name:");
            string departmentName = Console.ReadLine();

            Console.WriteLine("Enter the Worker Data:");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());

            Console.Write("Base Salary: ");
            double workerSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament workerDepartment = new Departament(departmentName);

            worker = new Worker(workerName, workerLevel, workerSalary, workerDepartment);

            Console.Write("How many contracts to this worker? ");
            int workerContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < workerContracts; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                string[] data = Console.ReadLine().Split('/');
                DateTime date = new DateTime(int.Parse(data[2]), int.Parse(data[1]), int.Parse(data[0]));
                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hour = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(date, valueHour, hour);
                worker.HourContracts.Add(hourContract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] incomeDate = Console.ReadLine().Split('/');

            double income = worker.Income(int.Parse(incomeDate[1]), int.Parse(incomeDate[0]));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Departament.Name}");
            Console.WriteLine($"Income for {incomeDate[0]}/{incomeDate[1]}: {income}");
        }
    }
}
