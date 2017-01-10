namespace _09.Student_Groups
{
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        public Student(string firstName, string lastName, int fN, string tel, string email, Groop groopNumber,List<int> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groopNumber;
            this.Marks = marks;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public Groop GroupNumber { get; set; }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("First Name: ").AppendLine(FirstName)
                   .Append("Last Name: ").AppendLine(LastName)
                   .Append("Fac. Number: ").Append(FN).AppendLine()
                   .Append("Tel.: ").Append(Tel).AppendLine()
                   .Append("Email: ").AppendLine(Email)
                   .Append("Groop Number: ").AppendLine(GroupNumber.GroupNumber);

            return builder.ToString();
        }
    }
}