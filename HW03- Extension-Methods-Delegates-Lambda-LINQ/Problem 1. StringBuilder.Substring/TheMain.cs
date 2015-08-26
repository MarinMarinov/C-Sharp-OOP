/*Problem 1. StringBuilder.Substring
 • Implement an extension method  Substring(int index, int length)  for the class  StringBuilder
  that returns new  StringBuilder  and has the same functionality as  Substring  in the class  String .*/

namespace Problem_1.StringBuilder.Substring
{
    using System;
    using System.Text;
    
    public class TheMain
    {
        static void Main()
        {
            string test = "Ala bala nica";
            StringBuilder str = new StringBuilder(test, 2, 5, 12);
            StringBuilder stringOne = str.Susbtring(2);
            StringBuilder stringTwo = str.Susbtring(2, 2);            
            
            Console.WriteLine(str);
            Console.WriteLine(stringOne); //OK
            Console.WriteLine(stringTwo); //OK

            string secondTest = "0123456789";
            StringBuilder stringNumbers = new StringBuilder(secondTest);
            StringBuilder stringLimitBelow = stringNumbers.Susbtring(-1); //throwing Exception OK!
            //Console.WriteLine(stringLimitBelow);
            //StringBuilder stringLimitAbove = stringNumbers.Susbtring(0, 11); //throwing Exception OK!            
            //Console.WriteLine(stringLimitAbove);
            
        }
    }
}
