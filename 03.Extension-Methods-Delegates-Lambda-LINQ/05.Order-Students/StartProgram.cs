namespace _05.Order_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartProgram
    {
        public static void Main()
        {
            List<Student> students = new List<Student>
            {
               new Student(1, "Mitko", "Qnkov",18),
               new Student(2, "Ivan", "Lilov",25),
               new Student(3, "Pesho", "Atanasov",24),
               new Student(4, "Andrei", "Cvetkov",17),
               new Student(5, "Andrei", "Minkov",27)
            };

            List<Student> sortedList = students.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}