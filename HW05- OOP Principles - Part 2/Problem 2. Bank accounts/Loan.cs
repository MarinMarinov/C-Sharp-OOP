namespace Problem_2.Bank_accounts
{
    using System;

    public class Loan : Account, IDepositable, IRemuneratable
    {
        public Loan(Customer owner, decimal interestRate, decimal initialBalance)
            : base(owner, interestRate, initialBalance)
        {
        }
        
        public override decimal CalculateRemunerate(int months)
        {
            if (months <= 0)
            {
                throw new ArgumentOutOfRangeException("Time period can't be zero or negative");
            }
            else if (this.Owner.Type == CustomerType.Individual && months > 3) //тук гърми пак заради Owner.Type
            {
                return (this.Balance * this.InterestRate / 100) * months;
            }
            else if (this.Owner.Type == CustomerType.Company && months > 2)
            {
                return (this.Balance * this.InterestRate / 100) * months;
            }
            else return 0.0m;
        }

        public override string ToString()
        {
            return string.Format("Loan account of client {0} has balance: {1} lv.", this.Owner, this.Balance); //защо this.Owner дава празно, a this.Owner.LastName гърми
        }
    }
}
