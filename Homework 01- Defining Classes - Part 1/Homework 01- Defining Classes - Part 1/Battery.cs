namespace DefiningClassesHomework
{
    using System;

    public class Battery
    {
        private string model; // Task 1
        private int? hoursIdle; // Task 1
        private int? hoursTalk; // Task 1
        private BatteryType type; // Task 3

        public string Model // Task 5
        {
            get { return this.model; }
            set
            {
                if (value.Length < 2 || value.Length > 30)
                {
                    throw new ArgumentOutOfRangeException("Battery model name length must be between 2 and 30 symbols");
                }

                this.model = value;
            }
        }

        public int? HoursIdle // Task 5
        {
            get { return this.hoursIdle; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid battery idle capacity, must be possitive number!");
                }

                this.hoursIdle = value;
            }
        }

        public int? HoursTalk // Task 5
        {
            get { return this.hoursTalk; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid battery talk capacity, must be possitive number!");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType Type // Task 5
        {
            get { return this.type; }
            set { this.type = value; }
        }


        public Battery(string model, BatteryType type) // Task 2
            : this(model, null, null, type)
        {
            this.Model = model;
            this.Type = type;
        }

        public Battery(string model, int? idle, int? talk, BatteryType type) // Task 2
        {
            this.Model = model;
            this.HoursIdle = idle;
            this.HoursTalk = talk;
            this.Type = type;
        }

        public override string ToString()
        {
            return string.Format("Battery: model {0}, Idle hours {1}, Speek hours {2}, Type {3};", this.Model, this.HoursIdle, this.HoursTalk, this.Type);
        }
    }
}