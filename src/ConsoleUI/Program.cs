using System;
using LogicLib.CoreBasic;
using LogicLib.CoreBasicVol2;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // EnvInfo.PrintSystemInfo();
            // TalkToUser.Talk();
            // HierarchyDemo.PrintSomeInheritedStaff();
            // DataTypeFunctionality.PrintInfo();
            // DataTypeFunctionality.PrintCharInfo();
            // DataTypeFunctionality.PrintTryParsingInfo();
            // DateTimeAndSpanDemo.UseDateAndTimes();
            // BigIntegersDemo.UseBigInteger();
            // StringsDemo.PrintInfo();
            // PatternMatchingDemo.IfElsePatternMatching();
            // FunWithArrays.DemoArrays();
            // FunWithArrays.PrintObjectArrayInfo();
            // FunWithArrays.PrintInfoMultiDimArray();
            // FunWithArrays.PrintInfoJaggedArray();
            // FunWithArrays.PrintArrayStaticMethodsInfo();
            // IndexesAndRangesDemo.PrintInfo();
            // FunWithMethods.PrintProcessedInfo();
            // FunWithMethods.AddOutParamInfoDemo();
            // FunWithMethods.StringSwapRefMethodDemo();
            // FunWithMethods.NotChangingRefTypeWithInDemo();
            // FunWithMethods.CalculateAverageOfDoubleArr(new double[] {1.2, 3.45, 43.1234, 123, 0.4356, 32.12});
            // FunWithEnums.PrintInfoUnderType();
            FunWithStructures.PrintInfo();
            (double, int) t1 = (4.5, 3);
            (double, int) t2 = t1;
            t1.Item1 = 12;
            Console.WriteLine(t2);
        }
    }
}