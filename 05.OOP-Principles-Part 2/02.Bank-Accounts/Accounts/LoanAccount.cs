namespace _02.Bank_Accounts.Accounts
{
    using System;
    using Customers;
    using Contracts;

    public class LoanAccount : Account, IAccount
    {
        public LoanAccount(ICustomer client, double balance, double interestRate)
            : base(client, balance, interestRate)
        {
        }

        public override string InterestAmount(int period)
        {
            if (this.Client is ICompanieClient && period <= 2)
            {
                return String.Format("Account: {0}, Period: {1}, Loan accounts have no interest for the first 2 months if are held by a company.", this.Client.ClientName, period);
            }
            else if (this.Client is IIndividualClient && period <= 3)
            {
                return String.Format("Account: {0}, Period: {1}, Loan accounts have no interest for the first 3 months if are held by a individual customer.", this.Client.ClientName, period);
            }
            else
            {
                return String.Format("Account: {0}, Period: {1}, Interes Amount: {1:F2}", this.Client.ClientName, period, period * this.InterestRate);
            }
        }
    }
}