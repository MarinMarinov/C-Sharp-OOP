namespace Problem_2.Students_and_workers
{
    using System;

    public class Worker : Human
    {
        private double weekSalary;
        private byte workHoursPerDay;
        
        public double WeekSalary
        {
            get { return this.weekSalary; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Week salary can't be 0(or less), the worker have to eat some food, you moron!");
                }
                this.weekSalary = value;
            }
        }

        public byte WorkOursPerDay
        {
            get { return this.workHoursPerDay; }
            private set
            {
                if (value > 24)
                {
                    throw new ArgumentOutOfRangeException("The day has 24 hours, didn't you know that!");
                }
                this.workHoursPerDay = value;
            }
        }

        public Worker(string firstname, string lastname, double salary, byte hours)
            : base(firstname, lastname)
        {
            this.WeekSalary = salary;
            this.WorkOursPerDay = hours;
        }

        public double MoneyPerHour()
        {
            double moneyPerHour = this.WeekSalary / this.WorkOursPerDay;
            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} earns {2}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
