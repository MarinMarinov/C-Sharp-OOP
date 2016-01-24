namespace Problem_2.Bank_accounts
{
    using System;
    
    public class Deposit : Account, IWithdrawable, IDepositable, IRemuneratable
    {
        public Deposit(Customer owner, decimal interestRate, decimal initialBalance)
            : base(owner, interestRate, initialBalance)
        {
        }

        public void Withdraw(decimal sum)
        {
            if (sum > this.Balance)
            {
                throw new IndexOutOfRangeException("You are out of money, mate! Can't withdraw so much money!");
            }
            this.Balance -= sum;
        }

        public override decimal CalculateRemunerate(int months)
        {
            if (months <= 0)
            {
                throw new ArgumentOutOfRangeException("Time period can't be zero or negative");
            }
            else if (this.Balance >= 1000)
            {
                return (this.Balance * this.InterestRate / 100) * months;
            }
            else return 0.0m;            
        }

        public override string ToString()
        {
            return string.Format("Deposit account of client {0} has balance: {1} lv.", this.Owner, this.Balance); //защо this.Owner дава празно, a this.Owner.LastName гърми
        }
    }
}
