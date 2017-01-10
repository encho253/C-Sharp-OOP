namespace _04.OOP_Principles_Part_1
{
    using _04.OOP_Principles_Part_1.Interfaces;
    using System;

    public class Student : Person, ITextBlock
    {
        private int id;

        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Student(int id, string name, string comment)
            : this(id, name)
        {
            this.Comment = comment;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Id must be bigger than zero");
                }

                this.id = value;
            }
        }
    }
}