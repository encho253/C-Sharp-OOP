namespace _03.Animal_Hierarchy
{
    using System;

    public class Dog : Animal, ISound
    {
        public Dog(string name, double age, AnimalSex sex)
            : base(name, age, sex)
        {

        }

        public string Sound()
        {
            return String.Format("Bau,bau");
        }
    }
}