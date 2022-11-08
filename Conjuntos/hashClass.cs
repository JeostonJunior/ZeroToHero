using System;
using System.Collections.Generic;

namespace Conjuntos
{
    public class HashClass<T>
    {
        HashSet<T> set { get; set; } = new HashSet<T>();
        public void AddValue(T value)
        {
            set.Add(value);
        }
        public void First()
        {
            Console.WriteLine($"Initial occurrence: {set.First()}");
        }
        public void Print()
        {
            Console.Write($"All ocurrences: ");

            foreach (var hash in set)
            {
                Console.Write($"{hash} ");
            }
        }
    }
}