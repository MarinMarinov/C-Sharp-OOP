namespace DefiningClassesHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSMCallHistoryTest //problem 12
    {
        public static GSM testGSM = new GSM("TestGSM", "TestModel", "Test Owner");
        public static DateTime testCall2Date = DateTime.Parse("08/03/2015 19:15:30");
        public static DateTime testCall3Date = DateTime.Parse("09/03/2015 14:07:18");
        public static DateTime testCall4Date = DateTime.Parse("10/03/2015 08:15:55");
        public static DateTime testCall5Date = DateTime.Parse("10/03/2015 12:37:03");
        public static DateTime testCall1Date = DateTime.Parse("10/03/2015 09:25:10");

        public static Call[] testCalls = 
        {
            new Call(testCall1Date, "0888111111", 3.45),
            new Call(testCall2Date, "0888222222", 4.56),
            new Call(testCall3Date, "0888333333", 5.20),
            new Call(testCall4Date, "0888444444", 1.30),
            new Call(testCall5Date, "0888555555", 10.23)
        };

        public static void CreateCallTestHistory()
        {
            for (int i = 0; i < testCalls.Length; i++)
            {
                testGSM.AddCall(testCalls[i]);
            }
        }

        public static void DisplayCallTestHistory()
        {
            Console.WriteLine(testGSM.PrintCallHistory());
        }

        public static void CalculateAndPrintTestCallsPrice()
        {
            decimal totalPrice = testGSM.CalculateTotalCallsPrice(0.37M);
            Console.WriteLine("Total price of test calls: {0:F2}", totalPrice);
        }

        public static void RemoveLongestCall()
        {
            Call longestCall = testGSM.CallHistory.OrderBy(x => x.Duration).ToArray()[testGSM.CallHistory.Count - 1];
            testGSM.DeleteCall(longestCall);
        }
    }
}