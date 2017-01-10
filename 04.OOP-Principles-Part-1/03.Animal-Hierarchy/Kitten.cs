namespace _03.Animal_Hierarchy
{
    using System;

    public class Kitten : Cat, ISound
    {
        public Kitten(string name, double age) : base(name, age)
        {
            Sex = AnimalSex.female;
        }

        public static AnimalSex Sex { get; private set; }
    }
}