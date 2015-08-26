/*Problem 17. Longest string
• Write a program to return the string with maximum length from an array of strings.
• Use LINQ.*/

namespace Problem_17.Longest_string
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class Program
    { 
        static void Main()
        {
            string[] someStrings = new string[] { "ala", "bala nica", "turska panica", "Hej gidi Vancho", "Nash pehlivancho" };

            var longestString = (from strings in someStrings
                                 orderby strings.Length descending
                                 select strings).First();

            Console.WriteLine(longestString);
        }
    }
}