namespace Point3D.DistanceCalculation
{
    using System;
    using Points;

    public static class Distance
    {
        public static double Calculate(Point3d pointOne, Point3d pointTwo)
        {
            double d = Math.Pow((pointTwo.X - pointOne.Y), 2) +
                       Math.Pow((pointTwo.Y - pointOne.Y), 2) +
                       Math.Pow((pointTwo.Z - pointOne.Z), 2);

            double distance = Math.Sqrt(d);

            return distance;
        }
    }
}
