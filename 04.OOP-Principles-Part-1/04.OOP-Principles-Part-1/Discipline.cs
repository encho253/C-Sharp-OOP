namespace _04.OOP_Principles_Part_1
{
    using System;
    using _04.OOP_Principles_Part_1.Interfaces;

    public class Discipline : ITextBlock,IName
    {
        private string comment;

        public Discipline(string name,int numberOfLectures,int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfExercises = numberOfExercises;
            this.NumberOfLectures = numberOfLectures;
        }

        public Discipline(string name, int numberOfLectures,int numberOfExercises,string comment)
            : this(name,numberOfExercises,numberOfLectures)
        {
            this.Comment = comment;
        }

        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExercises { get; set; }

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
            }
        }
    }
}