using System;

namespace LogicLib.CoreBasicVol2
{
    public class FunWithArrays
    {
        public static void DemoArrays()
        {
            Console.WriteLine($"<<< Fun with arrays >>>");
            int[] myInts = new int[3]; //first form
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;
            Array.ForEach(myInts, Console.WriteLine);
        }

        public static void PrintInfo()
        {
            string[] booksOfDotNet = {"C# 9 and .NET 5", "ASP.NET Core Web API", "Programming patterns with C#"};
            int[] someInts = new[] {1, 2, 3};
            Console.WriteLine($"booksOfDotNet array has {booksOfDotNet.Length} elements");
        }

        public static void PrintObjectArrayInfo()
        {
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = DateTime.Now;
            myObjects[3] = "Some string value";

            foreach (var myObject in myObjects)
            {
                Console.WriteLine($"Type: {myObject.GetType()}, Value: {myObject}");
            }
        }

        public static void PrintInfoMultiDimArray()
        {
            Console.WriteLine($"=> Rectangular multidimensional array. ");
            int[,] myMatrix = new int[4, 5];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    myMatrix[i, j] = i * j;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void PrintInfoJaggedArray()
        {
            Console.WriteLine($"=> Jagged multidimensional array. ");
            int[][] myJagArray = new int[10][];
            for (int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 1];
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                {
                    Console.Write(myJagArray[i][j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void PrintArrayStaticMethodsInfo()
        {
            string[] rockGroups = {"Beatles", "Motorhead", "Three Days Grace", "Green Day"};
            Console.WriteLine("Here is the array: ");
            ArrayUtils.PrintArray(rockGroups);
            Array.Reverse(rockGroups);
            ArrayUtils.PrintArray(rockGroups);
            string[] copyOfRockGroups = new string[rockGroups.Length]; 
            Array.Copy(rockGroups, copyOfRockGroups, rockGroups.Length);
            Array.Clear(rockGroups, 1, rockGroups.Length - 2);
            ArrayUtils.PrintArray(rockGroups);
            ArrayUtils.PrintArray(copyOfRockGroups);
            Array.Sort(copyOfRockGroups);
            ArrayUtils.PrintArray(copyOfRockGroups);
        }
    }
}