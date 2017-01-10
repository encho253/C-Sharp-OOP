namespace _02.Students_And_Workers
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public double MoneyPerHour(double workHoursPerDay, double weekSalary)
        {
            double moneyPerHour = (weekSalary / workHoursPerDay) / workHoursPerDay;

            return moneyPerHour;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(base.Print()).Append(" ").Append(String.Format("{0:F2}", MoneyPerHour(WorkHoursPerDay, WeekSalary)));

            return builder.ToString();
        }
    }
}