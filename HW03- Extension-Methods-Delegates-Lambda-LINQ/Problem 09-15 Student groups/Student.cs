//• Create a class  Student  with properties  FirstName ,  LastName ,  FN ,  Tel ,  Email ,  Marks  (a List),  GroupNumber .

namespace Problem_9.Student_groups
{
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int fn;
        private string tel;
        private string email;
        private List<byte> marks;
        private byte groupNumber;

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

        public int FN
        {
            get { return this.fn; }
            private set { this.fn = value; }
        }

        public string Tel
        {
            get { return this.tel; }
            private set { this.tel = value; }
        }

        public string Email
        {
            get { return this.email; }
            private set { this.email = value; }
        }

        public List<byte> Marks
        {
            get { return this.marks; }
            private set { this.marks = value; }
        }

        public byte GroupNumber
        {
            get { return this.groupNumber; }
            private set { this.groupNumber = value; }
        }

        public Student(string firstname, string lastname, int fn, string tel, string mail, List<byte> marks, byte group)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.FN = fn;
            this.Tel = tel;
            this.Email = mail;
            this.Marks = marks;
            this.GroupNumber = group;
        }        

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, marks: {5}; group {6}", this.Firstname, this.Lastname, this.FN,
                this.Tel, this.Email, string.Join(", ", this.Marks), this.GroupNumber);
        }  
    }
}