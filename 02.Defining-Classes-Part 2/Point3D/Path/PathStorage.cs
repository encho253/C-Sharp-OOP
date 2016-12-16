namespace Point3D.Path
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using Points;

    public static class PathStorage
    {
        public static void ReadFromFile(string textFileOne)
        {
            StreamReader reader = new StreamReader(textFileOne);

            using (reader)
            {
                string text = reader.ReadToEnd();

                string pattern = @"[\r\n]";

                Regex regexText = new Regex(pattern);

                List<string> coordinatesFromFail = new List<string>();

                coordinatesFromFail = regexText.Split(text).ToList();

                for (int i = 0; i < coordinatesFromFail.Count; i++)
                {
                    if (coordinatesFromFail[i] != string.Empty)
                    {
                        List<double> splitCoordinates = new List<double>();
                        splitCoordinates = coordinatesFromFail[i].Split(',').Select(p => Convert.ToDouble(p)).ToList();
                        Point3d newPoint = new Point3d(splitCoordinates[0], splitCoordinates[1], splitCoordinates[2]);
                        SavePoint.Save(newPoint);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        public static void WriteOnFile(string textFile, List<Point3d> listPoints)
        {
            StreamWriter streamWriter = new StreamWriter(textFile);

            using (streamWriter)
            {
                foreach (var item in listPoints)
                {
                    streamWriter.WriteLine(item);                            
                }
            }
        }
    }
}