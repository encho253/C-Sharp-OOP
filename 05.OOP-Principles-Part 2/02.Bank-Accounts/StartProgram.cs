namespace _02.Bank_Accounts
{
    using System.Collections.Generic;
    using Contracts;
    using Accounts;
    using Customers;
    using System;

    public class StartProgram
    {
        public static void Main()
        {
            ICustomer pesho = new IndividualClient("Pesho Goshev", "Kichevo 12", 30);
            ICustomer woodForever = new CompanieClient("Wood-Forever", "Milevo 10", "Woodwork");
            ICustomer kiro = new IndividualClient("Kiril Kirilov", "Bulgaria 88", 40);
            ICustomer ilievi = new CompanieClient("Wood-Forever", "Tzar Boris", "Аccounting firm");

            IAccount peshoDeposit = new DepositAccount(pesho, 400, 2.3);
            IAccount woodForeverDeposit = new LoanAccount(woodForever, 58549.20, 3);
            IAccount kiroDeposit = new MortgageAccount(kiro, 7840, 2.5);
            IAccount ilieviDeposit = new MortgageAccount(ilievi, 124248.146, 3.5);

            List<IAccount> accounts = new List<IAccount>();
            accounts.Add(peshoDeposit);
            accounts.Add(woodForeverDeposit);
            accounts.Add(kiroDeposit);
            accounts.Add(ilieviDeposit);

            foreach (var item in accounts)
            {
                Console.WriteLine(item.InterestAmount(2));
                Console.WriteLine(item.InterestAmount(3));
                Console.WriteLine(item.InterestAmount(6));
                Console.WriteLine(item.InterestAmount(12));
                Console.WriteLine(item.InterestAmount(24));
                Console.WriteLine("____________________");
            }
        }
    }
}