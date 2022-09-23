using System.Collections.Generic;
using System.Globalization;
using Workers.Entities.Enums;

namespace Workers.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> HourContracts { get; set; } = new List<HourContract>();

        public Worker ()
        {
        }
        public Worker (string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }
        public void AddContract (HourContract contract)
        {
            HourContracts.Add(contract);
        }
        public void RemoveContract (HourContract contract)
        {
            HourContracts.Remove(contract);
        }
        public double Income (int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in HourContracts)
            {
                if (contract.Date.Month.Equals(month) && contract.Date.Year.Equals(year))
                {

                    sum += contract.totalValue();
                }
            }
            return sum;

        }
        public override string ToString ()
        {
            return $"Name: {Name} | Level: {Level} | BaseSalary: {BaseSalary}";
        }
    }
}