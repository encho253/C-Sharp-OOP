namespace _09.Student_Groups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class SortedExtensionMethods
    {
        //Problem 10. Student groups extensions
        public static List<Student> SortByGroopAndFirtsName(this List<Student> listOfStudents)
        {
            List<Student> newSortedList = new List<Student>();
            newSortedList = listOfStudents
                            .Where(x => x.GroupNumber.GroupNumber == "42a")
                            .OrderBy(x => x.FirstName)
                            .ToList();

            return newSortedList;
        }

        //Problem 11. Extract students by email
        public static List<Student> SortByEmail(this List<Student> listOfStudents)
        {
            List<Student> newSortedList = new List<Student>();
            newSortedList = listOfStudents
                            .Where(x => x.Email.IndexOf("abv") != -1)
                            .ToList();

            return newSortedList;
        }

        //Problem 12. Extract students by phone
        public static List<Student> SortByPhone(this List<Student> listOfStudents)
        {
            List<Student> newSortedList = new List<Student>();
            newSortedList = listOfStudents
                            .Where(x => x.Tel.IndexOf("02/") != -1)
                            .ToList();

            return newSortedList;
        }

        //Problem 13. Extract students by marks
        public static void SortByGoodMarks(this List<Student> listOfStudents)
        {
            var newSortedList = listOfStudents
                             .Where(x => x.Marks.Contains(6))
                             .Select(x => new
                             {
                                 FirstName = x.FirstName,
                                 LastName = x.LastName,
                                 Mark = string.Join("," , x.Marks.ToArray())
                             });

            foreach (var item in newSortedList)
            {
                Console.WriteLine(item);
            }
        }

        //Problem 14. Extract students with two marks
        public static void SortByBadMarks(this List<Student> listOfStudents)
        {
            var newSortedList = listOfStudents
                             .Where(x => x.Marks.Contains(2))
                             .Select(x => new
                             {
                                 FirstName = x.FirstName,
                                 LastName = x.LastName,
                                 Mark = string.Join(",", x.Marks.ToArray())
                             });

            foreach (var item in newSortedList)
            {
                Console.WriteLine(item);
            }
        }

        //Problem 15. Extract marks
        public static void SortStudentsByFn(this List<Student> listOfStudents)
        {
            var newSortedList = listOfStudents
                             .Where(x => x.FN % 100 == 06)
                             .Select(x => new
                             {                              
                                 Mark = string.Join(",", x.Marks.ToArray())
                             });

            foreach (var item in newSortedList)
            {
                Console.WriteLine(item);
            }
        }

        //Problem 16.* Groups
        public static void SortByDepartment(this List<Student> listOfStudents)
        {
            var newSortedList = listOfStudents
                             .Where(x => x.GroupNumber.DepartmentName == "Mathematics")
                             .Select(x => new
                             {
                                 FirstName = x.FirstName,
                                 LastName = x.LastName,
                                 FacNumber = string.Join(",", x.GroupNumber.GroupNumber,x.GroupNumber.DepartmentName),
                             });

            foreach (var item in newSortedList)
            {
                Console.WriteLine(item);
            }
        }

        //Problem 18. Grouped by GroupNumber , Problem 19. Grouped by GroupName extensions
        public static List<Student> SortByGroupNumber(this List<Student> listOfStudents)
        {
            List<Student> newSortedList = listOfStudents.OrderBy(x => x.GroupNumber.GroupNumber).ToList();

            return newSortedList;
        }
    }
}