/*Problem 6. Divisible by 7 and 3
 • Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
 * Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.*/

namespace Problem_6.Divisible_by_7_and_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class TheMain
    {
        static void Main()
        {
            Console.WriteLine("Enter the array length");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrayLength];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            //using Lambda expression
            List<int> numbersDivisibleBy3And7WithLambda = numbers.Where(n => n % 3 == 0 && n % 7 == 0).ToList();

            //Using LINQ
            List<int> numbersDivisibleBy3And7WithLINQ =
                (from number in numbers
                where number % 3 == 0 && number % 7 == 0
                select number).ToList();

            Console.WriteLine("Using Lambda expression");

            foreach (int number in numbersDivisibleBy3And7WithLambda)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            Console.WriteLine("Using LINQ query");
            foreach (int number in numbersDivisibleBy3And7WithLINQ)
            {
                Console.WriteLine(number);
            }
        }
    }
}