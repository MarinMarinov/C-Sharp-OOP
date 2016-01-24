namespace Problem_2.Bank_accounts
{
    using System;
    using System.Collections.Generic;
    
    class TheMain
    {
        static void Main()
        {
            Customer ivanCustomer = new Customer("Ivan", "Petrov", CustomerType.Individual);
            //Customer ivanCustomer = new Customer("Ivan", CustomerType.Individual);
            Deposit ivanDeposit = new Deposit(ivanCustomer, 0.5m, 6000);

            ivanDeposit.Withdraw(100);
            Console.WriteLine(ivanDeposit.Balance);
            Console.WriteLine(ivanDeposit.CalculateRemunerate(12));

            Console.WriteLine(ivanCustomer);
            Console.WriteLine(ivanDeposit);

            Loan ivanLoan = new Loan(ivanCustomer, 1.2m, 2500);
            
            Console.WriteLine(ivanLoan.Balance);
            Mortgage ivanMortgage = new Mortgage(ivanCustomer, 0.3m, 80000);

            List<Account> accountsList = new List<Account>();

            Bank ktb = new Bank("KTB", accountsList);
            ktb.AddAccount(ivanDeposit);
            ktb.AddAccount(ivanLoan);
            ktb.AddAccount(ivanMortgage);

            Console.WriteLine(ktb);

            Console.WriteLine(ivanLoan.CalculateRemunerate(4));
            Console.WriteLine(ivanMortgage.CalculateRemunerate(8));

            Console.WriteLine(ivanLoan);

        }
    }
}
