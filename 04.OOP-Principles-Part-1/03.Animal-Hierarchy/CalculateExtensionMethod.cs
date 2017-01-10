namespace _03.Animal_Hierarchy
{
    using System.Collections.Generic;
    using System.Linq;

    public static class CalculateExtensionMethod
    {
        public static double AverageAge(this IEnumerable<Animal> collection)
        {
            double averageAge = collection.Average(x => x.Age);

            return averageAge;
        }
    }
}