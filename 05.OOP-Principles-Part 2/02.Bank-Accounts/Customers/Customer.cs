namespace _02.Bank_Accounts.Customers
{
    using Contracts;

    public class Customer : ICustomer
    {
        public Customer(string name, string address)
        {
            this.ClientName = name;
            this.Address = address;
        }

        public string ClientName { get; private set; }
        public string Address { get; private set; }
    }
}