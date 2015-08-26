namespace Problem_5_7
{
    using System;
    
    class TheMain
    {
        static void Main()
        {
            GenericList<int> testOne = new GenericList<int>(3);
            GenericList<string> testTwo = new GenericList<string>(3);
            GenericList<double> testThree = new GenericList<double>(5);

            Console.WriteLine(testOne); //The generic list is empty!
            Console.WriteLine(testTwo); //The generic list is empty!
            Console.WriteLine(testThree); //The generic list is empty!

            testOne.Add(23);
            testOne.Add(13);
            testOne.Add(33);

            Console.WriteLine(testOne[0]);
            Console.WriteLine(testOne[1] + " " + testOne[2]);
            //Console.WriteLine(testOne[-1]); // throws "Index was out of range" Exception
            //Console.WriteLine(testOne[3]); //trhows "Index was out of range" Exception
            //testOne[3] = 100000000; // must throw Exception, because list length is 3. So will add validation in the setter to throw "You attemp to set element with invalid index!" Exception

            testOne.Clear();
            Console.WriteLine(testOne); // The generic list is empty!
            testOne.Add(53);
            testOne.Add(23);
            Console.WriteLine(testOne[0]);
            Console.WriteLine(testOne[1]);
            for (int i = 0; i < testOne.GenericListLength; i++) // using property GenericListlength
            {
                Console.WriteLine(testOne[i]);
            }
            //Console.WriteLine(testOne[5]); //Exception here!!!

            testOne.Add(32);
            testOne.Add(22);
            testOne.Add(2);
            testOne.Add(42);
            testOne.Add(52);
            Console.WriteLine(testOne[4]);
            testOne.RemoveAt(4);
            Console.WriteLine(testOne[4]);

            testOne.Add(88);
            testOne.Add(68);
            testOne.Add(58);
            testOne.Add(48);

            Console.WriteLine(testOne[8]);
            testOne.InsertAt(33, 8);
            Console.WriteLine(testOne[8]);
            Console.WriteLine(testOne.Find(88));
            Console.WriteLine(testOne);
        }
    }
}