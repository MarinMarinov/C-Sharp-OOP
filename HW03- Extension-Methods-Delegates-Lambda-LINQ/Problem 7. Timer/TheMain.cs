/*Problem 7. Timer
 • Using delegates write a class  Timer  that can execute certain method at each  t  seconds.*/

namespace Problem_7.Timer
{
    using System;
    using System.Threading;

    class TimerMain
    {
        public static void Main()
        {
            Console.Write("Enter time period in seconds: ");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Timer timer = new Timer(t);

            timer.SomeMethods += TestMethod;
            
            timer.ExecuteMethods();           
        }

        public static void TestMethod()
        {
            Console.WriteLine("Abra kadabra, Sim salabim");            
        }
    }
}