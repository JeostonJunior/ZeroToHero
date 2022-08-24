using System;
using System.Globalization;
namespace Student
{
    public class Student
    {
        public string Name;
        public double TestNote1, TestNote2, TestNote3;

        public void SetNotes()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Insert Student note One:");
            TestNote1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Insert Student note Two:");
            TestNote2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Insert Student note Three:");
            TestNote3 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public void FinalNotes()
        {
            double finalNotes;
            finalNotes = TestNote1 + TestNote2 + TestNote3;
            Console.WriteLine($"The Final Note: {finalNotes}");

            if (finalNotes >= 60.00)
            {
                Console.WriteLine($"APPROVED");
            }
            else
            {
                Console.WriteLine($"DISAPPROVED");
                Console.WriteLine($"You need {60 - finalNotes} points");
            }
        }
    }
}