namespace _01.Shapes
{
    public abstract class Shape : IShape
    {
        public Shape(double height)
        {
            this.Height = height;
        }

        public Shape(double width,double height)
            : this(height)
        {
            this.Width = width;
        }

        public double Width { get; private set; }
        public double Height { get; private set; }

        public abstract double CalculateSurface();
    }
}