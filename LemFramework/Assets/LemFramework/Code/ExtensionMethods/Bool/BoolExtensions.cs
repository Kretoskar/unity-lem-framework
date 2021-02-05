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
    }
}