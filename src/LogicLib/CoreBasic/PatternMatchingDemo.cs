using System;

namespace LogicLib.CoreBasic
{
    public class PatternMatchingDemo
    {
        public static void IfElsePatternMatching()
        {
            object testItem1 = "123";
            object testItem2 = 123;
            Type t = typeof(string);
            char c = 'f';

            if (t is Type)
            {
                Console.WriteLine($"{t} is a Type");
            }

            if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
            {
                Console.WriteLine($"{c} is a character!");
            }

            if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
            {
                Console.WriteLine($"{c} is character or separator");
            }

            if (testItem2 is not string)
            {
                Console.WriteLine($"{testItem1} is not a string");
            }

            if (testItem1 is string stringValue)
            {
                Console.WriteLine($"Value of testItem1 as a string is {stringValue}");
            }

            if (testItem1 is not null)
            {
                Console.WriteLine($"{testItem1} is not null");
            }
            
        }
    }
}