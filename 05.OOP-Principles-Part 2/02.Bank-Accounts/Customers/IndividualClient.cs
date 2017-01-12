namespace _02.Bank_Accounts.Customers
{
    using Contracts;

    public class IndividualClient : Customer, ICustomer, IIndividualClient
    {
        public IndividualClient(string name, string address, int age) 
            : base(name, address)
        {
            this.Age = age;
        }

        public int Age { get; private set; }
    }
}