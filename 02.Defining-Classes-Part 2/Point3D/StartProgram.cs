namespace Point3D
{
    using System;
    using DistanceCalculation;
    using Path;

    public class StartProgram
    {
        public static void Main()
        {
            string textFileOne = @"../../TextFiles/01.textFile.txt";
            string textFileTwo = @"../../TextFiles/02.textFile.txt";

            PathStorage.ReadFromFile(textFileOne);
            PathStorage.WriteOnFile(textFileTwo, SavePoint.ReturnPoints());

            double distance = Distance.Calculate(SavePoint.ReturnPoints()[0], SavePoint.ReturnPoints()[1]);

            foreach (var item in SavePoint.ReturnPoints())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(distance);
        }
    }
}
