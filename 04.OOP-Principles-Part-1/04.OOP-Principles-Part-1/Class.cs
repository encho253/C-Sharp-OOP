namespace _04.OOP_Principles_Part_1
{
    using Interfaces;
    using System.Collections.Generic;
    using System;

    public class Class : ITextBlock
    {
        private string comment;

        public Class(IEnumerable<Teacher> classTeachers, IEnumerable<Student> students, string identifier)
        {
            this.ClassTeachers = classTeachers;
            this.Students = students;
            this.Identifier = identifier;
        }

        public Class(IEnumerable<Teacher> classTeachers, IEnumerable<Student> students, string identifier, string comment)
            : this(classTeachers, students, identifier)
        {
            this.Comment = comment;
        }

        public IEnumerable<Teacher> ClassTeachers { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public string Identifier { get; set; }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                if (value.Length < 20)
                {
                    throw new ArgumentException("The comment must be more than 20 characters");
                }
                this.comment = value;
            }
        }
    }
}