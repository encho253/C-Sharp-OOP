namespace _02.Students_And_Workers
{
    using System;
    using System.Text;

    public class Student : Human
    {
        public Student(string firstName, string lastName, string grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string Grade { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(base.Print()).Append(" ").Append(Grade);

            return builder.ToString();
        }
    }
}