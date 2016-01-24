namespace Problem_2.Students_and_workers
{
    using System;
    
    public class Student : Human
    {
        private double grades;

        public double Grade
        {
            get { return this.grades; }
            private set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Students grade scale in Bulgaria is between 2 and 6!");
                }
                this.grades = value;
            }
        }

        public Student(string firstname, string secondname, double grade)
            : base(firstname, secondname)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} has grade {2}", this.FirstName, this.LastName, this.Grade);
        }

    }
}
