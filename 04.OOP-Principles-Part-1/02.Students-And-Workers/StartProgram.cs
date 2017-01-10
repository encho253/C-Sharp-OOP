namespace _02.Students_And_Workers
{
    using System;
    using System.Collections.Generic;

    public class StartProgram
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Qnko","Rusev","bachelor"),
                new Student("Penko","Slivev","bachelor"),
                new Student("Joro","Ignatov","master"),
                new Student("Minko","Daskalov","bachelor"),
                new Student("Penka","Dupkata","master"),
                new Student("Silvia","Kacarova","bachelor"),
                new Student("Ignat","Ignatev","bachelor"),
                new Student("Blagovest","Geshev","master"),
                new Student("Qna","Bulkina","master"),
                new Student("Mima","Shasheva","bachelor"),
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Damqn","Rusev",200,8),
                new Worker("Nadejda","Bulkina",250,8),
                new Worker("Ahmed","Rusev",300,8),
                new Worker("Grigor","Dimitrov",220,10),
                new Worker("Spirido","Qhnev",250,8),
                new Worker("Munio","Gudjev",320,10),
                new Worker("Damqnka","Vidova",200,4),
                new Worker("Ivanna","Mehmedonova",300,10),
                new Worker("Ninio","Nunev",150,4),
                new Worker("Encho","Enevski",400,6)
            };

            IEnumerable<Student> sortedStudents = students.SortStudents();
            IEnumerable<Worker> sortedWorkers = workers.SortWorkers();

            foreach (var item in sortedWorkers)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();

            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item.ToString());
            }

            IEnumerable<Human> mergeAndSort = new List<Human>();
            mergeAndSort = mergeAndSort.MergeAndSort(sortedStudents, sortedWorkers);

            Console.WriteLine();

            foreach (var item in mergeAndSort)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}