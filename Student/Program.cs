using System.Globalization;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Name = "Alex Green";
            student.SetNotes();
            student.FinalNotes();
        }
    }
}