
namespace _09.Student_Groups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartProgram
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Qnko","Rusev",555606,"02/0876980540","qnko@gmail.com",new Groop("42a","Mathematics"),new List<int>() {6,4,6,5}),
                new Student("Penko","Slivev",545506,"0876980649","penko@gmail.com",new Groop("43a"),new List<int>() {6,2,6,5}),
                new Student("Joro","Ignatov",535510,"0876980349","joro@gmail.com",new Groop("42a"),new List<int>() {3,4,4,5}),
                new Student("Minko","Daskalov",595507,"0876940549","minko@gmail.com",new Groop("42a","Mathematics"),new List<int>() {2,4,4,5}),
                new Student("Penka","Dupkata",557508,"0876680549","penka@gmail.com",new Groop("43a"),new List<int>() {5,4,5,5}),
                new Student("Silvia","Kacarova",155507,"0856980549","silvia@gmail.com",new Groop("42b"),new List<int>() {5,5,4,5}),
                new Student("Ignat","Ignatev",555006,"02/0876660549","ignat@gmail.com",new Groop("42a","Mathematics"),new List<int>() {2,4,4,5}),
                new Student("Blagovest","Geshev",550505,"02/0806980549","blagovest@gmail.com",new Groop("43a"),new List<int>() {4,4,5,5}),
                new Student("Qna","Bulkina",755504,"0876980749","qna@gmail.com",new Groop("42b"),new List<int>() {6,6,6,6}),
                new Student("Mima","Shasheva",855509,"0876990949","mima@abv.com",new Groop("42a"),new List<int>() {3,3,4,5}),
                new Student("Damqn","Rusev",355504,"0876980840","damqn@gmail.com",new Groop("42a"),new List<int>() {2,4,4,5}),
                new Student("Nadejda","Bulkina",955504,"0845980549","nadejda@gmail.com",new Groop("42b"),new List<int>() {4,4,2,5}),
                new Student("Ahmed","Rusev",559006,"0876980849","ahmed@abv.com",new Groop("43a"),new List<int>() {3,2,2,2})
            };

            //Problem 9. Student groups
            List<Student> sortedListWithStudents = students
                                                  .Where(x => x.GroupNumber.GroupNumber == "42a")
                                                  .OrderBy(x => x.FirstName)
                                                  .ToList();

            //Problem 10. Student groups extensions
            List<Student> byGroopAndFirstName = students.SortByGroopAndFirtsName();

            //Problem 11. Extract students by email
            List<Student> byEmail = students.SortByEmail();

            //Problem 12. Extract students by phone
            List<Student> byPhone = students.SortByPhone();

            //Problem 13. Extract students by marks
            students.SortByGoodMarks();

            //Problem 14. Extract students with two marks
            students.SortByBadMarks();

            //Problem 15. Extract marks
            students.SortStudentsByFn();

            //Problem 16.* Groups
            students.SortByDepartment();

            //Problem 18.Grouped by GroupNumber , Problem 19. Grouped by GroupName extensions
            List<Student> byGroupNumber = students.SortByGroupNumber();

            foreach (var item in byGroupNumber)
            {
                Console.WriteLine(item);
            }
        }
    }
}