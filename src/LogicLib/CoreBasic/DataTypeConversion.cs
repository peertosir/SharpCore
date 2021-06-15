using System;

namespace LogicLib.CoreBasic
{
    public class DataTypeConversion
    {
        public static void PrintInfo()
        {
            short a = 9, b = 10;
            Console.WriteLine($"{a} + {b} = {Add(a, b)}");
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }
    }
}