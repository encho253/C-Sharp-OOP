namespace _06.Divisible_By_7_and_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartProgram
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() { 21, 14, 12, 123, 56, 76, 222, 29, 39, 147 };

            List<int> sortedNumbers = numbers.Where(x => (x % 7 == 0) && (x % 3 == 0)).ToList();

            foreach (var item in sortedNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}