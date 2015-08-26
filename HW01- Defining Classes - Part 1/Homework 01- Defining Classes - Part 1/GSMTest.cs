/*
Problem 7. GSM test
 • Write a class  GSMTest  to test the  GSM  class:
    ◦ Create an array of few instances of the  GSM  class.
    ◦ Display the information about the GSMs in the array.
    ◦ Display the information about the static property  IPhone4S */

namespace DefiningClassesHomework
{
    using System;
    using System.Collections.Generic;

    class GSMTest //problem 7
    {
        public static string[] manufacturers = { "Nokia", "Samsung", "Motorola", "Sony", "HTC" };

        public static string[,] models = 
        {
            {"Lumia", "Galaxy Note", "Nexus 6", "Xperia", "One"},
            {"3310", "Galaxy S5", "Moto", "Xperia T", "Desire"},
            {"Asha", "Galaxy Grand", "Droid", "Xperia J", "Butterfly"},
        };

        public static string[] owners = { "Pesho Goshov", "Jhon Hammer", "Alesandro DelPiero", "Osama Bin Laden" };


        public static Battery[] batteries =
        {
            new Battery("Light Battery", 50, 25, BatteryType.NiMH),
            new Battery("Medium Battery", 200, 50, BatteryType.NiCd),
            new Battery("Best Battery", 300, 80, BatteryType.LiIon)
        };

        public static Display[] displays =
        {   new Display(3, 256),
            new Display(8, 250000),
            new Display(10, 120000000)
        };

        public static GSM[] GenerateGSM(int number)
        {
            GSM[] phones = new GSM[number];

            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                int col = random.Next(0, models.GetLength(1));
                int row = random.Next(1, models.GetLength(0));

                phones[i] = new GSM(manufacturers[col], models[row, col], random.Next(1, 2001),
                    owners[random.Next(0, owners.Length)], batteries[random.Next(0, batteries.Length)],
                    displays[random.Next(0, displays.Length)], new List<Call>());
            }

            return phones;
        }

        public static void PrintPhonesInfo(GSM[] phones)
        {
            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine("Sample GSM {0}: {1}", i + 1, phones[i]);
                Console.WriteLine(new string('-', 50));
            }

            Console.WriteLine("IPhone info: {0}", GSM.IPhone);
        }
    }
}