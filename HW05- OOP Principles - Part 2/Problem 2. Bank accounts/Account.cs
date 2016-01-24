namespace Problem_2.Bank_accounts
{
    using System;

    public abstract class Account : IDepositable, IRemuneratable
    {
        private Customer owner; // проблемът го оправих като смених тук customer с owner
        private decimal balance;
        private decimal interestRate;

        public Account(Customer owner, decimal interestRate,  decimal initialBalance = 0) //Ако началният баланс не е указан, по подразбиране е 0;
        {
            this.Owner = owner; // проблемът го оправих като смених тук customer с owner
            this.Balance = initialBalance;
            this.InterestRate = interestRate;
        }

        public Customer Owner
        {
            get { return this.owner; } // проблемът го оправих като смених тук customer с owner
            private set { this.owner = value; } // проблемът го оправих като смених тук customer с owner
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate can't be negative, unless you are European Central Bank");
                }
                this.interestRate = value;
            }
        }

        public void Deposit(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentOutOfRangeException("Give some money, mate! You can't deposit negative or zero ammount of money");
            }
            this.Balance += sum;
        }

        public abstract decimal CalculateRemunerate(int months);


        
    }
        
}
