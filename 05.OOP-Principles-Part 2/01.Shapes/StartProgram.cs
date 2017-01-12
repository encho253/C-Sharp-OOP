namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;

    public class StartProgram
    {
        public static void Main()
        {
            IEnumerable<IShape> shapes = new List<IShape>()
            {
                new Rectangle(2.5, 5),
                new Square(5),
                new Triangle(4, 3.2)
            };

            foreach (var item in shapes)
            {
                Console.WriteLine(item.CalculateSurface());
            }
        }
    }
}