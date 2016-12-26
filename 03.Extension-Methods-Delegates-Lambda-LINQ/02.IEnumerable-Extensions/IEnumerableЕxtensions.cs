namespace _02.IEnumerable_Extensions
{
    using System;
    using System.Collections.Generic;

    public static class IEnumerableЕxtensions
    {
        public static decimal Sum<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            decimal sum = 0;
            foreach (var item in collection)
            {
                sum += Convert.ToDecimal(item);
            }
           
            return sum;
        }

        public static decimal Product<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            decimal product = 0;

            foreach (var item in collection)
            {
                product *= Convert.ToDecimal(item);
            }

            return product;
        }

        public static dynamic Min<T>(this IEnumerable<T> collection)
        {
            decimal min = 0;
            decimal finalMin = 0;

            foreach (var item in collection)
            {
                min =(dynamic)item;
                if (finalMin == 0)
                {
                    finalMin = min;
                }            
                if (min < finalMin)
                {
                    min = (dynamic)item;
                }
            }

            return min;
        }

        public static dynamic Max<T>(this IEnumerable<T> collection)
        {
            var max = 0;

            foreach (var item in collection)
            {
                if ((dynamic)item > max)
                {
                    max = (dynamic)item;
                }
            }

            return max;
        }

        public static dynamic Average<T>(this IEnumerable<T> collection)
        {
            var average = 0;
            var counter = 0;

            foreach (var item in collection)
            {
                average += (dynamic)item;
                counter++;
            }
            average /= counter;
            return average;
        }
    }
}
