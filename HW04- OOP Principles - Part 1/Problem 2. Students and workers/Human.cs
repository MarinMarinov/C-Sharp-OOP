namespace Problem_2.Students_and_workers
{
    using System;
    
    public abstract class Human
    {
        private string firstName;
        private string lastName;

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
                    throw new ArgumentNullException("Last name can't be empty string!");
                }
                this.lastName = value;
            }
        }

        public Human(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }
       
    }
}
