namespace _03.Animal_Hierarchy
{
    using System;

    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name, double age) : base(name, age)
        {
            Sex = AnimalSex.male;
        }

        public static AnimalSex Sex { get; private set; }
    }
}