using UsingAbstract.Entities.Enums;

namespace UsingAbstract.Entities
{
    public abstract class Shape
    {
        public Color Color { get; protected set; }

        public Shape (Color color)
        {
            Color = color;
        }
        public abstract double Area ();
    }
}
