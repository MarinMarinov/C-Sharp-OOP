/*Problem 2. IEnumerable extensions
 • Implement a set of extension methods for  IEnumerable<T>  that implement the following group functions:
 sum, product, min, max, average.*/

namespace Problem_2.IEnumerable_extensions
{
    using System;
    using System.Collections.Generic;
    
    public class TheMain
    {
        static void Main()
        {
            List<int> integers = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine(integers.Sum());              //OK
            Console.WriteLine(integers.Product());          //OK
            Console.WriteLine(integers.Min());              //OK
            Console.WriteLine(integers.Max());              //OK
            Console.WriteLine(integers.Average());          //OK

            Console.WriteLine("----------------------------");
            
            List<float> floats = new List<float>() { 1.11f, 2.22f, 3.33f, 4.44f, 5.55f };
            Console.WriteLine(floats.Sum());                //OK
            Console.WriteLine(floats.Product());            //OK
            Console.WriteLine(floats.Min());                //OK
            Console.WriteLine(floats.Max());                //OK
            Console.WriteLine(floats.Average());            //OK

            Console.WriteLine("----------------------------");

            List<double> doubles = new List<double>() { 1.111111111111, 2.22222222222, 3.33333333333 };
            Console.WriteLine(doubles.Sum());               //OK
            Console.WriteLine(doubles.Product());           //OK
            Console.WriteLine(doubles.Min());               //OK
            Console.WriteLine(doubles.Max());               //OK
            Console.WriteLine(doubles.Average());           //OK

            Console.WriteLine("----------------------------");

            List<decimal> decimals = new List<decimal>() { 1.111111111111111111111m, 2.222222222222222222222m, 3.33333333333333333333m };
            Console.WriteLine(decimals.Sum()); //OK
            Console.WriteLine(decimals.Product()); //OK
            Console.WriteLine(decimals.Min()); //OK
            Console.WriteLine(decimals.Max()); //OK
            Console.WriteLine(decimals.Average()); //OK

            Console.WriteLine("----------------------------");

            List<decimal> differrentTypes = new List<decimal>() { 1, (decimal)2.22, (decimal)3.33333333333, 4.444444444444444444444444444444444m };//това реално още тук ги каства!!
            Console.WriteLine(differrentTypes.Sum());            //OK
            Console.WriteLine(differrentTypes.Product());        //OK
            Console.WriteLine(differrentTypes.Min());            //OK
            Console.WriteLine(differrentTypes.Max());            //OK
            Console.WriteLine(differrentTypes.Average());        //OK

            Console.WriteLine("----------------------------");

            List<int> empty = new List<int>() { };
            Console.WriteLine(empty.Sum()); //OK
            Console.WriteLine(empty.Product()); //OK
            //Console.WriteLine(empty.Min()); //exception
            //Console.WriteLine(empty.Max()); //exception
            //Console.WriteLine(empty.Average()); //exception

            /*List<char> chars = new List<char>() { 'a', 'b', 'c', 'd' }; //can't cast the chars
            Console.WriteLine(chars.Sum());*/
        }
    }
}