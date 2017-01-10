namespace _03.Animal_Hierarchy
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(string name, double age, AnimalSex sex)
            : base(name, age, sex)
        {

        }

        public string Sound()
        {
            return String.Format("Kvak,kvak");
        }
    }
}