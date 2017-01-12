namespace _03.Range_Exceptions
{
    using System;

    public class StartProgram
    {
        static void Main()
        {
            DateTime birthDate = "01.23.1940".ConvertStringToDate();

            Person pesho = new Person("Pesho", 100, birthDate);
        }
    }
}