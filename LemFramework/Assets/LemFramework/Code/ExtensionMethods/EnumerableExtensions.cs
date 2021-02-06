using System;
using System.Collections.Generic;
using System.Linq;

namespace LemFramework.ExtensionMethods
{
    public static class EnumerableExtensions
    {
        private static Random _random = new Random();
     
        public static T RandomElement<T>(this IEnumerable<T> tenumerable)
        {
            // If there are no elements in the collection, return the default value of T
            if (!tenumerable.Any())
                return default(T);
 
            return tenumerable.ElementAt(_random.Next(tenumerable.Count()));
        }
    }
}