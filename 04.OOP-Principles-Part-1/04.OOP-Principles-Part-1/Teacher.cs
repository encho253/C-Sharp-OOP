namespace _04.OOP_Principles_Part_1
{
    using System.Collections.Generic;
    using _04.OOP_Principles_Part_1.Interfaces;

    public class Teacher : Person, ITextBlock
    {
        public Teacher(IEnumerable<Discipline> setOfDisciplines, string name)
        {
            this.SetOfDisciplines = setOfDisciplines;
            this.Name = name;
        }

        public IEnumerable<Discipline> SetOfDisciplines { get; set; }
    }
}