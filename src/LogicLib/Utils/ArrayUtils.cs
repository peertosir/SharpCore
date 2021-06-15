using System;
using System.Text;

namespace LogicLib
{
    public class ArrayUtils
    {
        public static void PrintArray<T>(T[] array)
        {
            StringBuilder resultString = new StringBuilder();
            resultString.Append("[ ");
            for (int i = 0; i < array.Length; i++)
            { 
                resultString.Append(array[i] + ", ");
            }

            if (resultString.Length > 2)
            {
                resultString = resultString.Remove(resultString.Length - 2, 2);
            }

            resultString.Append(" ]");

            Console.WriteLine(resultString);
        }
    }
}