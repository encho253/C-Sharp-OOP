namespace _03.Animal_Hierarchy
{
    using System;
    using System.Collections.Generic;

    public class StartProgram
    {
        public static void Main()
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog("Sharo" , 10 ,AnimalSex.male),
                new Dog("Balo" , 2.5 ,AnimalSex.female),             
            };

            List<Cat> cats = new List<Cat>()
            {
                new Kitten("Pisi" , 5),
                new Tomcat("Galcho" , 3.5),
                new Kitten("Mishi" , 4.2),
                new Tomcat("Petio", 7)
            };

            List<Frog> frogs = new List<Frog>()
            {
                new Frog("Koko" , 1 ,AnimalSex.male),
                new Frog("Dimka" , 2 ,AnimalSex.female),
            };

            Console.WriteLine(dogs.AverageAge());
            Console.WriteLine(cats.AverageAge());
            Console.WriteLine(frogs.AverageAge());
        }
    }
}