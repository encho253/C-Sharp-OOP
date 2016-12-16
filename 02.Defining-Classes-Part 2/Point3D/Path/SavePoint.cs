namespace Point3D.Path
{
    using System.Collections.Generic;
    using Point3D.Points;

    public static class SavePoint
    {
        private static List<Point3d> allPoints;

        static SavePoint()
        {
            allPoints = new List<Point3d>();
        }

        public static void Save(Point3d point)
        {
            allPoints.Add(point);
        }

        public static List<Point3d> ReturnPoints()
        {
            return allPoints;
        }      
    }
}
