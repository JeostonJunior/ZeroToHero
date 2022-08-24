using System.Globalization;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle;

            rectangle = new Rectangle();

            rectangle.Width = 3.00;
            rectangle.Height = 4.00;

            rectangle.ViewArea();
            rectangle.ViewPerimeter();
            rectangle.ViewDiagonal();
        }
    }
}