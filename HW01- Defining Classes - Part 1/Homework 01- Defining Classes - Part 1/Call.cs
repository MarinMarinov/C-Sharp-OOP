/*Problem 8. Calls
• Create a class  Call  to hold a call performed through a GSM.
• It should contain date, time, dialled phone number and duration (in seconds).*/

namespace DefiningClassesHomework
{
    using System;

    public class Call
    {
        private DateTime date;
        private string dialledPhone;
        private double duration;

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string DialledPhone
        {
            get { return this.dialledPhone; }
            set { this.dialledPhone = value; }
        }

        public double Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public Call(DateTime date, string dialledPhone, double duration)
        {
            this.Date = date;
            this.DialledPhone = dialledPhone;
            this.Duration = duration;
        }

        public override string ToString()
        {
            return String.Format("Call on {0}, from number: {1}, duration in minutes: {2}", this.Date, this.DialledPhone, this.Duration);
        }
    }
}