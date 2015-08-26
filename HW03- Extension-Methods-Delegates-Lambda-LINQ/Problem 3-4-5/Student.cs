namespace Problem_03_04_05
{   
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;       

        public string Firstname
        {
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

        public string Lastname
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public Student( string firstname, string lastname, int age)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Firstname, this.Lastname, this.Age);
        }  
    }
}