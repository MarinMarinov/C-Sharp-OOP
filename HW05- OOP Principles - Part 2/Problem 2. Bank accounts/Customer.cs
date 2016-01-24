namespace Problem_2.Bank_accounts
{
    using System;
    
    public class Customer
    {
        private string firstName;
        private string lastName;
        private CustomerType type;

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can't be empty string!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can't be empyt string!");
                }
                this.lastName = value;
            }
        }

        public CustomerType Type
        {
            get { return this.type; }
            private set { this.type = value; }
        }

        public Customer(string firstname, string lastname, CustomerType type)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Type = type;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, client type: {2}", this.FirstName, this.LastName, this.Type);
        }
    }
}
