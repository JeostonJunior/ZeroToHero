using System;
using System.Globalization;

namespace Rectangle
{
    public class Rectangle
    {
        public double Height;
        public double Width;
        public double RectangleArea()
        {
            double RectangleArea;
            RectangleArea = Height * Width;

            return RectangleArea;
        }
        public void ViewArea()
        {
            Console.WriteLine($"The area of the rectangle is {RectangleArea().ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public double RectanglePerimeter()
        {
            double RectanglePerimeter;
            RectanglePerimeter = (Width + Height) * 2;
            return RectanglePerimeter;
        }
        public void ViewPerimeter()
        {
            Console.WriteLine($"The Perimeter of the rectangle is {RectanglePerimeter().ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public double RectangleDiagonal()
        {
            double RectangleDiagonal;
            RectangleDiagonal = Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
            return RectangleDiagonal;
        }
        public void ViewDiagonal()
        {
            Console.WriteLine($"The Diagonal of the rectangle is {RectangleDiagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}