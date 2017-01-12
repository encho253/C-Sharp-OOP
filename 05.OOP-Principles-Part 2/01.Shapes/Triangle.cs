namespace _01.Shapes
{
    using System;

    public class Triangle : Shape, IShape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return ((Width * Height) / 2);
        }
    }
}