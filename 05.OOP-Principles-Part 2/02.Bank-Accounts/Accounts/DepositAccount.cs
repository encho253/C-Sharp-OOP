namespace _02.Bank_Accounts.Accounts
{
    using Customers;
    using Contracts;
    using System;

    public class DepositAccount : Account, IAccount, IMoneyDraw
    {
        public DepositAccount(ICustomer client, double balance, double interestRate)
            : base(client, balance, interestRate)
        {
        }

        public void Draw(double drawSum)
        {
            if (this.Balance >= drawSum)
            {
                this.Balance -= drawSum;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Account: {0}, You do not have enough money in your account.", this.Client.ClientName);
            }
        }

        public override string InterestAmount(int period)
        {
            if (this.Balance < 1000)
            {
                return String.Format("Account: {0}, Period: {1}, No interest!Balance is less than 1000", this.Client.ClientName, period);
            }
            else
            {
                return String.Format("Account: {0}, Period: {1}, Interest Amount: {2:F2}", this.Client.ClientName, period, period * this.InterestRate);
            }
        }
    }
}