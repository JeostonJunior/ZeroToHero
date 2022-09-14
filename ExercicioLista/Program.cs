using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>();

            Console.WriteLine($"How many employees will be registered?");
            int numberOfEmployees = int.Parse(Console.ReadLine());
            int iterator = 0;

            while (numberOfEmployees > iterator)
            {
                Console.WriteLine($"ID:");                
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine($"NAME:");                
                string name = Console.ReadLine();

                Console.WriteLine($"SALARY:");                
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employees(id, name, salary));
                iterator++;
            }

            Console.WriteLine($"Enter the employee id that will have salary increase:");
            int searchEmployee = int.Parse(Console.ReadLine());
            Employees idEmployee =  employees.Find(x => x.Id == searchEmployee);

            if(idEmployee != null){
                Console.WriteLine($"Enter the Percentage:");
                double percentage = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                idEmployee.increaseSalary(percentage);                
            }else{
                Console.WriteLine($"This id does not exist!");
            }
            
            foreach (Employees employee in employees)
            {
                Console.WriteLine($"{employee.Id}| {employee.Name} | {employee.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
