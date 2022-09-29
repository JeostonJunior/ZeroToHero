using System;
using System.Collections.Generic;
using System.Globalization;
using UsingAbstract.Entities;
using UsingAbstract.Entities.Enums;

namespace UsingAbstract
{
    internal class Program
    {
        static void Main ()
        {
            List<Shape> listShapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int shapes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= shapes; i++)
            {
                Console.Write($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char circleOrRectangle = char.Parse(Console.ReadLine());
                if (circleOrRectangle.Equals('r'))
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listShapes.Add(new Rectangle(color, width, height));
                }
                else if (circleOrRectangle.Equals('c'))
                {
                    Console.Write("Color: (Black/Blue/Red)");
                    Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listShapes.Add(new Circle(color, radius));
                }
                else
                {
                    Console.WriteLine("Invalid Entry;");
                }
            }
            Console.WriteLine("SHAPES AREAS:");
            foreach (Shape shape in listShapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
