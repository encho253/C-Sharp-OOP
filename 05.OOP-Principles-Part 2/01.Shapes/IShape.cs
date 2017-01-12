namespace _01.Shapes
{
    public interface IShape
    {
        double Width { get; }
        double Height { get; }

        double CalculateSurface();
    }
}