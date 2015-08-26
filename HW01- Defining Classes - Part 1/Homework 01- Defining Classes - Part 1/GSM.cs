/*
Problem 1. Define class
• Define a class that holds information about a mobile phone device: model, manufacturer, price, owner,
    battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
• Define 3 separate classes (class  GSM  holding instances of the classes  Battery  and  Display ).*/

namespace DefiningClassesHomework
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class GSM
    {
        private string model; // Task 1
        private string manufacturer; // Task 1
        private decimal? price; // Task 1
        private string owner; // Task 1
        private Battery battery; // Task 1
        private Display display; // Task 1
        private static GSM IPhone4S; //Task 6
        private List<Call> callHistory; //Task 9

        public string Model // Task 5
        {
            get { return this.model; }
            set
            {
                if (value.Length == 0 || value.Length > 19 )
                {
                    throw new ArgumentOutOfRangeException("Model name length must be between 1 and 18 symbols");
                }
                this.model = value; 
            }
        }

        public string Manufacturer // Task 5
        {
            get { return this.manufacturer; }
            set
            {
                if (value.Length == 0 || value.Length > 19)
                {
                    throw new ArgumentOutOfRangeException("Manufacturer name length must be between 1 and 18 symbols");
                }
                this.manufacturer = value;
            }
        }

        public decimal? Price // Task 5
        {
            get { return this.price; }
            set
            {
                if ( value > 10000 || value < 0)
                {
                    throw new ArgumentOutOfRangeException("Are you sure, this is a phone price, not a car price?");
                }
                this.price = value;
            }
        }

        public string Owner // Task 5
        {
            get { return this.owner; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Owner name must have at least 3 symbols, mate!");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("Please, enter shorter name(less then 50 symbols)!");
                }
                foreach (char chars in value)
                {
                    if (!(char.IsLetter(chars)))
                    {
                        if (chars == ' ') // allow empty space in the name
                        {
                            continue;
                        }
                        throw new ArgumentException("Please, enter only letters!");
                    }
                }

                this.owner = value;                
            }
        }
        public Battery Battery // Task 5
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display // Task 5
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public static GSM IPhone // Task 6
        {
            get { return IPhone4S; }
            set { IPhone4S = value; }
        }

        public List<Call> CallHistory //Task 9
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        public void AddCall(Call call) // Task 10
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call) // Task 10
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory() // Task 10
        {
            this.CallHistory.Clear();
        }

        public GSM(string model, string manufacturer, string owner): this(model, manufacturer, null, owner, null, null, null) //Task 2
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display, List<Call> CallHistory) // Task 2
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }

        public override string ToString() // Task 4
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Model: " + this.model);
            result.AppendLine("Manufacturer: " + this.manufacturer);
            result.AppendLine(string.Format(new System.Globalization.CultureInfo("en-US"), "Price: {0:C}", this.price));
            result.AppendLine("Owner: " + this.owner);
            result.AppendLine("Battery model: " + this.battery.Model);
            result.AppendLine("Battery type: " + this.battery.Type);
            result.AppendLine("Talk hours: " + this.battery.HoursTalk);
            result.AppendLine("Idle hours: " + this.battery.HoursIdle);
            result.AppendLine("Display size: " + this.display.Size);
            result.AppendLine("Number of colors: " + this.display.Colors);

            return result.ToString();
        }

        public decimal CalculateTotalCallsPrice(decimal price) // Task 11
        {
            double totalDuration = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalDuration += callHistory[i].Duration;
            }

            decimal totalPrice = (decimal)totalDuration * price;

            return totalPrice;
        }

        public string PrintCallHistory()
        {
            string listOfCalls = string.Join(Environment.NewLine, this.CallHistory);

            return string.Format("Calls history:\n{0}", (listOfCalls == String.Empty) ? "List is empty" : listOfCalls);
        } 
    }
}