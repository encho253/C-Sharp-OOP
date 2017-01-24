namespace _02.Students_And_Workers
{
    using System.Text;

    public class Student : Human, IHuman, IStudent
    {
        public Student(string firstName, string lastName, string grade)
            :base(firstName,lastName)
        {
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