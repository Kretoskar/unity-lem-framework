using System;

namespace LemFramework.ExtensionMethods
{
    public static class BoolExtensionMethods
    {
        public static bool Random(this bool tbool)
        {
            var rand = new Random();
            return rand.NextDouble() > 0.5;
        }
    }
}