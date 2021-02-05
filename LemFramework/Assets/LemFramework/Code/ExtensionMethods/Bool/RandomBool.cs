using System;

namespace LemFramework.ExtensionMethods.Bool
{
    public static class RandomBool
    {
        public static bool Random(this bool tbool)
        {
            var rand = new Random();
            return rand.NextDouble() > 0.5;
        }
    }
}