namespace _02.Students_And_Workers
{
    public interface IWorker
    {
        double WeekSalary { get; }
        double WorkHoursPerDay { get; }

        double MoneyPerHour();
        string ToString();    
    }
}