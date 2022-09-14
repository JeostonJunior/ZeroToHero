using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioLista
{
    public class Employees
    {
        public int Id { get; private set; }

        public string Name { get; set; }

        public double Salary { get; private set; }

        public Employees(){ }
        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double porcentage)
        {
            Salary += (Salary * porcentage) / 100.0;
        }
    }
}
