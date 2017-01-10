namespace _03.First_Before_Last
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class LinqExtensionMethods
    {
        public static IEnumerable<T> SortNamesAlphabetically<T>(this IEnumerable<T> collection) where T : Student
        {
            IEnumerable<T> sortedList = collection.Where(x => x.FirstName.CompareTo(x.LastName) < 0).ToList();

            return sortedList;
        }
    }
}