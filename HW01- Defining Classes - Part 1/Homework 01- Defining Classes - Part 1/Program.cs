namespace DefiningClassesHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            // Manual tests - start
            Battery lightBattery = new Battery("Nikel-Mh", 200, 50, BatteryType.NiMH);
            Battery meddiumBattery = new Battery("Nikel-Cd", BatteryType.NiCd);
            Battery goodBattery = new Battery("Nikel-Cd", 300, 90, BatteryType.NiCd);

            Console.WriteLine(lightBattery.ToString());
            Console.WriteLine(meddiumBattery.ToString());

            Display badDisplay = new Display(5.5, 256);
            Display goodDisplay = new Display(13, 120000000);
            Console.WriteLine(goodDisplay.ToString());


            Call firstCall = new Call(DateTime.Parse("08/03/2015 09:30:25"), "0888123456", 3.25);
            Call secondCall = new Call(DateTime.Parse("09/03/2015 10:30:25"), "0888456123", 4.23);

            List<Call> calls = new List<Call>();

            GSM sonyGsm = new GSM("Xperia T", "Sony", 1000, "Pesho Goshov", goodBattery, goodDisplay, calls);

            sonyGsm.AddCall(firstCall);
            sonyGsm.AddCall(secondCall);

            Console.WriteLine(sonyGsm.ToString());
            Console.WriteLine(sonyGsm.PrintCallHistory());

            sonyGsm.DeleteCall(secondCall);
            Console.WriteLine(sonyGsm.PrintCallHistory());

            sonyGsm.ClearCallHistory();
            Console.WriteLine(sonyGsm.PrintCallHistory());

            GSM.IPhone = new GSM("4s", "IPhone", 1100, "Sulio Puljov", lightBattery, badDisplay, new List<Call>());
            Console.WriteLine(GSM.IPhone.ToString());
            // Manual tests - end


            // Automated GSM tests with GSMTest class - start
            Battery iPhoneBattery = new Battery("Nikel-Mh", 200, 50, BatteryType.NiMH);
            Display iPhoneDisplay = new Display(10.2, 1200000);
            GSM.IPhone = new GSM("4s", "IPhone", 1100, "Sulio Puljov", iPhoneBattery, iPhoneDisplay, new List<Call>());

            GSMTest.PrintPhonesInfo(GSMTest.GenerateGSM(3)); //problem 7 

            Console.WriteLine(new string('-', 50));
            // Automated GSM tests with GSMTest class - end

            // Automated GSM call history with GSMCallHistoryTest class - start
            GSMCallHistoryTest.CreateCallTestHistory();

            GSMCallHistoryTest.DisplayCallTestHistory();

            GSMCallHistoryTest.CalculateAndPrintTestCallsPrice();

            GSMCallHistoryTest.RemoveLongestCall();

            GSMCallHistoryTest.CalculateAndPrintTestCallsPrice();
            // Automated GSM call history with GSMCallHistoryTest class - end
        }
    }
}