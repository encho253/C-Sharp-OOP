namespace _01.Shapes
{
    public class Square : Shape, IShape
    {
        public Square(double height)
            :base(height)
        {
        }

        public override double CalculateSurface()
        {
            return Height * Height;
        }
    }
}