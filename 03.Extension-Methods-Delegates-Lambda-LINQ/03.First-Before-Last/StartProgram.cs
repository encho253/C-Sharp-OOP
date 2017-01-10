namespace _03.First_Before_Last
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StartProgram
    {
        public static void Main()
        {
            List<Student> students = new List<Student>
            {
               new Student(1, "Mitko", "Qnkov"),
               new Student(2, "Ivan", "Lilov"),
               new Student(3, "Pesho", "Atanasov"),
               new Student(4, "Andrei", "Cvetkov")
            };

            IEnumerable<Student> sortedStudents = students.SortNamesAlphabetically();

            foreach (var item in sortedStudents)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(item.FirstName).Append(" ").Append(item.LastName);
                Console.WriteLine(builder);
                builder.Clear();
            }
        }
    }
}
