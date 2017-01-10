namespace _04.Age_Range
{
    using System.Text;

    public class Student
    {
        public Student(int id, string firstName, string lastName,uint age)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public uint Age { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();     
            builder
                .Append(Id).Append(" ")
                .Append(FirstName).Append(" ")
                .Append(LastName).Append(" ")
                .Append(Age);

            return builder.ToString();
        }
    }
}
