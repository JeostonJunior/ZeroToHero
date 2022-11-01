using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics.Services
{
    public class PrintService<T>
    {
        public List<T> Numbers { get; set; } = new List<T>();
        public void AddValue (T value)
        {
            Numbers.Add(value);
        }
        public T First ()
        {
            return Numbers.First();
        }
        public void Print ()
        {
            Console.Write("[");
            Console.Write(string.Join(",", Numbers));
            Console.Write("]\n");
        }
    }
}
