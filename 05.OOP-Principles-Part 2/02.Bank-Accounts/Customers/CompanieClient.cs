namespace _02.Bank_Accounts.Customers
{
    using Contracts;
    using System;

    public class CompanieClient : Customer, ICustomer, ICompanieClient
    {
        public CompanieClient(string name,string address, string companyActivity) 
            : base(name, address)
        {
            this.CompanyActivity = companyActivity;
        }

        public string CompanyActivity { get; private set; }
    }
}