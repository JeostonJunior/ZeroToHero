namespace Struct
{
    public struct Point
    {
        public double X, Y;

        // public Point(double x, double y)
        // {
        //     X = x;
        //     Y = y;
        // }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
}