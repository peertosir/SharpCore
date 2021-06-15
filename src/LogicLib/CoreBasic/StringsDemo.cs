using System;

namespace LogicLib.CoreBasic
{
    public class StringsDemo
    {
        public static void PrintInfo()
        {
            Console.WriteLine($"Basic String Manipulations: ");
            string name = "Peter";
            Console.WriteLine($"Variable name has value: {name}");
            Console.WriteLine($"'name' has {name.Length} characters");
            Console.WriteLine($"'name' has 'a' character? {name.Contains('a')}");
            Console.WriteLine($"'name' in uppercase: {name.ToUpper()}");
            Console.WriteLine($"'name' in lowercase: {name.ToLower()}");
            Console.WriteLine($"'name' without 't': {name.Replace("t", "pp")}");
        }
    }
}