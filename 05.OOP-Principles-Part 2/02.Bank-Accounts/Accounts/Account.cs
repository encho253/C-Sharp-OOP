namespace _02.Bank_Accounts.Accounts
{
    using Contracts;
    using Customers;

    public abstract class Account : IAccount
    {
        public Account(ICustomer client, double balance, double interestRate)
        {
            this.Client = client;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public ICustomer Client { get; private set; }
        public double Balance { get; protected set; }
        public double InterestRate { get; private set; }

        public void Deposit(double sum)
        {
            this.Balance += sum;
        }

        public abstract string InterestAmount(int period);                        
    }
}