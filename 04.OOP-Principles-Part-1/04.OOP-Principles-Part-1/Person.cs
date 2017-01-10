namespace _04.OOP_Principles_Part_1
{
    using System;
    using _04.OOP_Principles_Part_1.Interfaces;

    public abstract class Person : IName,ITextBlock
    {
        private string comment;
        private string name;

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

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("The name must be more than 5 characters");
                }
                this.name = value;
            }
        }
    }
}