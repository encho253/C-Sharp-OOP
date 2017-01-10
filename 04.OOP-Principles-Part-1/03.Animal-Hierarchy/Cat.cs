namespace _03.Animal_Hierarchy
{
    using System;

    public abstract class Cat : Animal, ISound
    {
        public Cat(string name, double age)
            : base(name, age)
        {

        }

        public string Sound()
        {
            return String.Format("May,May");
        }
    }
}