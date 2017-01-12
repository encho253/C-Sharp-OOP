namespace _02.Bank_Accounts.Contracts
{
    using Customers;

    public interface IAccount
    {
        ICustomer Client { get; }
        double Balance { get; }
        double InterestRate { get; }

        void Deposit(double sum);
        string InterestAmount(int period);
    }
}