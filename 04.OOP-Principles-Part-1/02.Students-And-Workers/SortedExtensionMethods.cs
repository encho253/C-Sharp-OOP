namespace _02.Students_And_Workers
{
    using System.Collections.Generic;
    using System.Linq;

    public static class SortedExtensionMethods
    {
        public static IEnumerable<Worker> SortWorkers(this IEnumerable<Worker> collection)
        {
            IEnumerable<Worker> sortedCollection = collection
                                                  .OrderBy(x => x.MoneyPerHour(x.WorkHoursPerDay, x.WeekSalary));

            return sortedCollection;
        }

        public static IEnumerable<Student> SortStudents(this IEnumerable<Student> collection)
        {
            IEnumerable<Student> sortedCollection = collection
                                                    .OrderByDescending(x => x.Grade)
                                                    .ThenBy(x => x.FirstName);

            return sortedCollection;
        }

        public static IEnumerable<Human> MergeAndSort(this IEnumerable<Human> collection,IEnumerable<Human> collectionStudents,IEnumerable<Human> collectionWorkers)
        {
            IEnumerable<Human> mergeLists = collectionStudents.Concat(collectionWorkers);
            IEnumerable<Human> sortedMergeLists = mergeLists
                                                  .OrderBy(x => x.FirstName)
                                                  .ThenBy(x => x.LastName);

            return mergeLists;
        }
    }
}