namespace Problem_2.Bank_accounts
{
    using System;
    
    public class Mortgage : Account, IDepositable, IRemuneratable
    {
        public Mortgage(Customer owner, decimal interestRate, decimal initialBalance)
            : base(owner, interestRate, initialBalance)
        {
        }

        public override decimal CalculateRemunerate(int months)
        {
            if (months <= 0)
            {
                throw new ArgumentOutOfRangeException("Time period can't be zero or negative");
            }
            else
            {
                if (this.Owner.Type == CustomerType.Company) //тук гърми пак заради Owner.Type
                {

                    if (months <= 12)
                    {
                        return ((this.Balance * this.InterestRate / 100) * months) / 2;
                    }
                    else return ((this.Balance * this.InterestRate / 100) * 12) / 2 + ((this.Balance * this.InterestRate / 100) * (months - 12));
                }
                else if (this.Owner.Type == CustomerType.Individual)
                {
                    if (months <= 6)
                    {
                        return ((this.Balance * this.InterestRate / 100) * months) / 2;
                    }
                    else return ((this.Balance * this.InterestRate / 100) * 6) / 2 + ((this.Balance * this.InterestRate / 100) * (months - 6));
                }
                else return 0.0m; //това е тъпотия!!
            }

        }

        public override string ToString()
        {
            return string.Format("Loan account of client {0} has balance: {1} lv.", this.Owner, this.Balance); //защо this.Owner дава празно, a this.Owner.LastName гърми
        }
    }
}
