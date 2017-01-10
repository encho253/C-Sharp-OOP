namespace _02.Students_And_Workers
{
    public class Student : Human
    {
        public Student(string firstName, string lastName, string grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string Grade { get; set; }
    }
}