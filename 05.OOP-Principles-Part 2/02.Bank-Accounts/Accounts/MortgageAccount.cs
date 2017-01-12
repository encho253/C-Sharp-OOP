namespace _02.Bank_Accounts.Accounts
{
    using System;
    using Customers;
    using Contracts;

    public class MortgageAccount : Account, IAccount
    {
        public MortgageAccount(ICustomer client, double balance, double interestRate)
            : base(client, balance, interestRate)
        {
        }

        public override string InterestAmount(int period)
        {
            if (this.Client is ICompanieClient && period <= 12)
            {
                return String.Format("Account: {0}, Period: {1}, Interest Amount: {2:F2}", this.Client.ClientName, period, (period * (this.InterestRate / 2)));
            }
            else if (this.Client is IIndividualClient && period <= 6)
            {
                return String.Format("Account: {0}, Period: {1}, No interest for the first 6 months for individuals.", this.Client.ClientName, period);
            }
            else
            {
                return String.Format("Account: {0}, Period: {1}, Interest Amount: {2:F2}", this.Client.ClientName, period, period * this.InterestRate);
            }
        }
    }
}