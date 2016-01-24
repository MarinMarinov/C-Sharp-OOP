namespace Problem_4.Person
{
    using System;
    
    public class Person
    {
        private string name;
        private byte? age;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public byte? Age
        {
            get { return this.age; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Age can't be negative or zero");
                }
                this.age = value;
            }
        }

        public Person(string name, byte? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            if (age == null)
            {
                return string.Format("This person {0}, has no specified age!", this.Name);
            }

            return string.Format("{0} has age of {1}", this.Name, this.Age);
        }

    }
}
