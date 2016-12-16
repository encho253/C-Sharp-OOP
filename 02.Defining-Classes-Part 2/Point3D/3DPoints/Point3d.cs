namespace Point3D.Points
{
    using System.Text;

    public struct Point3d
    {
        private static readonly Point3d StartPoint;

        static Point3d()
        {
            StartPoint = new Point3d(0, 0, 0);
        }

        public Point3d(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;         
        }
          
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(this.X).Append(",").Append(this.Y).Append(",").Append(this.Z);

            return builder.ToString();
        }
    }
}
