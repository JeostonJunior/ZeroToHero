using UsingAbstract.Entities.Enums;

namespace UsingAbstract.Entities
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle (Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }
        public sealed override double Area ()
        {
            return Width * Height;
        }
    }
}
