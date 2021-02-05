using System;

namespace LemFramework.ExtensionMethods
{
    public static class BoolExtensions
    {
        public static bool Random(this bool tbool)
        {
            var rand = new Random();
            return rand.NextDouble() > 0.5;
        }
        
        public static bool IsBetweenInclusive<T>(this T actual, T lower, T upper) where T : IComparable<T>
        {
            return actual.CompareTo(lower) >= 0 && actual.CompareTo(upper) <= 0;
        }
        
        public static bool IsBetweenExclusive<T>(this T actual, T lower, T upper) where T : IComparable<T>
        {
            return actual.CompareTo(lower) > 0 && actual.CompareTo(upper) < 0;
        }
    }
}