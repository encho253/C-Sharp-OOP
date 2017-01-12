namespace _01.Shapes
{
    using System;

    public class Rectangle : Shape, IShape
    {
        public Rectangle(double width,double height)
            :base(width,height)
        {
        }

        public override double CalculateSurface()
        {
            return Width * Height;
        }
    }
}