using System;

namespace LogicLib.CoreBasicVol2
{
    public class IndexesAndRangesDemo
    {
        public static void PrintInfo()
        {
            int[] someInts = {1, 2, 3, 4, 5, 6};
            for (int i = 0; i < someInts.Length; i++)
            {
                Index idx = i;
                Console.Write(someInts[idx] + ", ");
            }

            Console.WriteLine();

            for (int i = 1; i <= someInts.Length; i++)
            {
                Index idx = ^i;
                Console.Write(someInts[idx] + ", ");
            }

            Console.WriteLine();

            foreach (var someInt in someInts[..3])
            {
                Console.WriteLine(someInt);
            }
        }
    }
}