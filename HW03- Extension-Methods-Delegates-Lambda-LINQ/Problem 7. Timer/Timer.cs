
namespace Problem_7.Timer
{
    using System;
    using System.Threading;

    public delegate void TimerDlg();
    
    public class Timer
    {
        public TimerDlg SomeMethods { get; set; }

        private int timeInterval;

        public int TimeInterval
        {
            get { return this.timeInterval; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Interval must be >= 1");
                }

                this.timeInterval = value;
            }
        }

        public Timer(int seconds)
        {
            this.TimeInterval = seconds;
        }

        public void ExecuteMethods()
        {
            while (true)
            {
                this.SomeMethods();
                Console.WriteLine("I will say it again after {0} seconds!", this.TimeInterval);
                Thread.Sleep(this.timeInterval * 1000);                
            }
        }
    }
}
