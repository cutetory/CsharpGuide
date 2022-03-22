using System;
using NameSpace.Utilities;

namespace NameSpace
{
    internal class NameSpacePractice
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = NameSpace.Utilities.Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
            
        }
    }
}

namespace NameSpace.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}
