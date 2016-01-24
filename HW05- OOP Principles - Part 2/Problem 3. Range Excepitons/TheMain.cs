namespace Problem_3.Range_Excepitons
{
    using System;
    
    class TheMain
    {
        static void Main()
        {
            int[] numbers = { -10, 10, 110 };

            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    if (numbers[i] < 0 || numbers[i] > 100)
                    {
                        throw new InvalidRangeException<int>(0, 100);
                    }
                    else Console.WriteLine("Number {0} is in the range", numbers[i]);
                }
                catch (InvalidRangeException<int> ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            DateTime[] date =
            {
                new DateTime(1980,1,1),
                new DateTime(1981,2,2),
                DateTime.Now
            };

            for (int i = 0; i < date.Length; i++)
            {
                try
                {
                    if (date[i] < new DateTime(1981, 1, 1) || date[i] > new DateTime(2013, 1, 1))
                    {
                        throw new InvalidRangeException<DateTime>(new DateTime(1981, 1, 1), new DateTime(2013, 1, 1));
                    }
                    else Console.WriteLine("Date {0} is in the range", date);
                }
                catch (InvalidRangeException<DateTime> ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
