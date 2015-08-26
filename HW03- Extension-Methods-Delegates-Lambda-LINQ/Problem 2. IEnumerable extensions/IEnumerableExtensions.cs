namespace Problem_2.IEnumerable_extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> numbers)
        {
            T sum = (dynamic)0;
                       
            foreach (dynamic number in numbers)
            {
                sum += number;
            }   
         
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> numbers)
        {
            T product = (dynamic)1;

            foreach (dynamic number in numbers)
            {
                product *= number;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> numbers) where T : IComparable<T>
        {
            T min = numbers.First();

            foreach (T number in numbers)
            {
                if (number.CompareTo(min) < 0)
                {
                    min = number;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> numbers) where T : IComparable<T>
        {
            T max = numbers.First();

            foreach (T number in numbers)
            {
                if (number.CompareTo(max) > 0)
                {
                    max = number;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> numbers)
        {
            T sum = (dynamic)0;

            foreach (dynamic number in numbers)
            {
                sum += number;
            }

            T avarage = sum / (dynamic)numbers.Count();

            return avarage;
        }
    }
}