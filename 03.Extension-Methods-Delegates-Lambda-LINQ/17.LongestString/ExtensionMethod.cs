namespace _17.LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ExtensionMethod
    {
        public static string MaxLenghtOfString(this List<string> collection)
        {
            string maxSting = collection.OrderByDescending(s => s.Length).First();

            return maxSting;
        }
    }
}
