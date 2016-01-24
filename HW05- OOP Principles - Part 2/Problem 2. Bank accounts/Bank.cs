using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bank_accounts
{
    public class Bank
    {
        private string name;
        public List<Account> ListOfAccounts { get; private set; }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Give some bank name, mate");
                }
                this.name = value;
            }
        }

        public Bank(string name, List<Account> listOfAccounts)
        {
            this.Name = name;
            this.ListOfAccounts = listOfAccounts;
        }

        public void AddAccount(Account newAccount)
        {
            this.ListOfAccounts.Add(newAccount);
        }

        public override string ToString()
        {
            return string.Format("{0} has total of {1} accounts.", this.Name, this.ListOfAccounts.Count);
        }
    }
}
