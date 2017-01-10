namespace _02.Students_And_Workers
{
    using System;
    using System.Text;

    public abstract class Human 
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name should not be empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name should not be empty");
                }

                this.lastName = value;
            }
        } 
        
        public virtual string Print()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(FirstName).Append(" ").Append(LastName).Append(" ");

            return builder.ToString();
        }       
    }
}