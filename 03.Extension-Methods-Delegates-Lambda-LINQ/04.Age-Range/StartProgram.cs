namespace _04.Age_Range
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartProgram
    {
        public static void Main()
        {          
            List<Student> students = new List<Student>
            {
               new Student(1, "Mitko", "Qnkov",18),
               new Student(2, "Ivan", "Lilov",25),
               new Student(3, "Pesho", "Atanasov",24),
               new Student(4, "Andrei", "Cvetkov",17)
            };

            var sortedStudents = students
                .Where(x => (x.Age >= 18) && (x.Age <= 24))
                .Select(x => new
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName
                });

            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item);
            }
        }
    }
}
