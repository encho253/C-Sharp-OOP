namespace _03.Animal_Hierarchy
{
    using System;

    public abstract class Animal
    {
        private string name;
        private double age;

        public Animal(string name, double age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Animal(string name, double age, AnimalSex sex)
            : this(name, age)
        {
            this.AnimalSex = sex;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name should not be empty!");
                }

                this.name = value;
            }
        }

        public double Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Age must be greater than zero!");
                }

                this.age = value;
            }
        }

        public AnimalSex AnimalSex { get; set; }
    }
}