namespace _02.Students_And_Workers
{
    public interface IHuman
    {
        string FirstName { get; }
        string LastName { get; }
        string Print();
    }
}