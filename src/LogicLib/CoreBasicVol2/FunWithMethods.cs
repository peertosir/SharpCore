using System;
using System.Diagnostics.CodeAnalysis;

namespace LogicLib.CoreBasicVol2
{
    public class FunWithMethods
    {
        public static int AddFullMethod(int a, int b)
        {
            return a + b;
        }

        public static int AddExpressionBodyMethod(int a, int b) => a + b;

        public static int AddWrapper(int x, int y)
        {
            return Add();
            int Add()
            {
                return x + y;
            }
        }

        #nullable enable
        public static void PrintProcessedInfo()
        {
            Process(new string?[] {"Some string", null, "Not a string", null},
                "SmallL");
        }

        #nullable enable
        public static void Process(string?[] lines, string mark)
        {
            foreach (var line in lines)
            {
                if (IsValid(line))
                {
                    Console.WriteLine(line);
                }
            }

            bool IsValid([NotNullWhen(true)] string? line)
            {
                return !string.IsNullOrEmpty(line) && line.Length >= mark.Length;
            }
        }

        public static void AddOutParamInfoDemo()
        {
            AddOutParamInfo(2 ,3, out int someInt);
            Console.WriteLine(someInt);
        }

        public static void AddOutParamInfo(int a, int b, out int result)
        {
            result = a + b;
        }

        private static void StringSwapRefMethod(ref string s1, ref string s2)
        {
            string tempVar = s1;
            s1 = s2;
            s2 = tempVar;
        }

        public static void StringSwapRefMethodDemo()
        {
            string s1 = "some 1 value";
            string s2 = "some 2 value";
            Console.WriteLine($"s1: {s1}. s2: {s2}");
            StringSwapRefMethod(ref s1, ref s2);
            Console.WriteLine($"s1: {s1}. s2: {s2}");
        }

        private static void NotChangingRefTypeWithIn(in Box someBox)
        {
            someBox.length = 15;
        }
        
        private static void NotChangingRefTypeWithIn(in BoxStruct someBoxStruct)
        {
            Console.WriteLine(someBoxStruct.length);
        }

        public static void NotChangingRefTypeWithInDemo()
        {
            Box box = new Box() {width = 10, length = 12};
            Console.WriteLine(box);
            NotChangingRefTypeWithIn(in box);
            Console.WriteLine(box);
            
            BoxStruct boxStruct = new BoxStruct() {width = 10, length = 12};
            Console.WriteLine(boxStruct);
            NotChangingRefTypeWithIn(in boxStruct);
            Console.WriteLine(boxStruct);
        }

        public static void CalculateAverageOfDoubleArr(params double[] nums)
        {
            Console.WriteLine($"You give me {nums.Length} doubles");

            double sum = 0;
            
            if (nums.Length == 0)
            {
                Console.WriteLine($"Average is: {sum}");
            }
            else
            {
                foreach (var t in nums)
                {
                    sum += t;
                }

                Console.WriteLine($"Average is: {sum/nums.Length:N2}");
            }
        }
        
    }
}