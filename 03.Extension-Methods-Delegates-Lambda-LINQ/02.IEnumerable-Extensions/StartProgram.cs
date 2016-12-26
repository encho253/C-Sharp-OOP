namespace _02.IEnumerable_Extensions
{
    using System.Collections.Generic;
    using System;

    public class StartProgram
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 5,5,5};

            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Average());
        }
    }
}
