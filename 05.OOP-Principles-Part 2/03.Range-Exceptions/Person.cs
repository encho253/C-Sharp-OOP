namespace _03.Range_Exceptions
{
    using System;

    public class Person : IPerson
    {
        private string name;
        private int gamePoints;
        private DateTime birthDate;

        public Person(string name, int gamePoints, DateTime birthDate)
        {
            this.Name = name;
            this.GamePoints = gamePoints;
            this.BirthDate = birthDate;
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
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public int GamePoints
        {
            get
            {
                return this.GamePoints = gamePoints;
            }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new InvalidRangeException<int>("Invalid Points", 1, 100);
                }

                this.gamePoints = value;
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return this.BirthDate = birthDate;
            }

            set
            {
                if (value > "12.31.2013".ConvertStringToDate() || value < "01.01.1980".ConvertStringToDate())
                {
                    throw new InvalidRangeException<DateTime>("Invalid Date", "01.01.1980".ConvertStringToDate(), "12.31.2013".ConvertStringToDate());
                }

                this.birthDate = value;
            }
        }

    }
}