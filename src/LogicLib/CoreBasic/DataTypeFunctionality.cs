using System;

namespace LogicLib.CoreBasic
{
    public class DataTypeFunctionality
    {
        public static void PrintInfo()
        {
            Console.WriteLine("Data type Functionality");
            Console.WriteLine($"Min of int: {int.MinValue}");
            Console.WriteLine($"Max of int: {int.MaxValue}");
            Console.WriteLine($"Min of double: {double.MinValue}");
            Console.WriteLine($"Max of double: {double.MaxValue}");
            Console.WriteLine($"double.Epsilon: {double.Epsilon}");
            Console.WriteLine($"double.PositiveInfinity: {double.PositiveInfinity}");
            Console.WriteLine($"double.NegativeInfinity: {double.NegativeInfinity}");

            Console.WriteLine();
            Console.WriteLine($"bool.FalseString: {bool.FalseString}");
            Console.WriteLine($"bool.TrueString: {bool.TrueString}");
        }

        public static void PrintCharInfo()
        {
            Console.WriteLine("Char functionality: ");
            char someChar = 'a';
            Console.WriteLine("Char variable is 'a'");
            Console.WriteLine($"Is variable a digit? {char.IsDigit(someChar)}");
            Console.WriteLine($"Is '1' a digit? {char.IsDigit('1')}");
            Console.WriteLine($"Is variable a letter? {char.IsLetter(someChar)}");
            Console.WriteLine($"Is '1' a letter? {char.IsLetter('1')}");
            Console.WriteLine($"Is ' ' a whitespace? {char.IsWhiteSpace(' ')}");
            Console.WriteLine($"Is variable a whitespace? {char.IsWhiteSpace(someChar)}");
            Console.WriteLine($"Is variable a punctuation? {char.IsPunctuation(someChar)}");
            Console.WriteLine($"Is '?' a punctuation? {char.IsPunctuation('1')}");
        }

        public static void PrintParsingInfo()
        {
            Console.WriteLine("Enter an int value");
            try
            {
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine($"Yor value is {value} of type {value.GetType()}");
            }
            catch (Exception)
            {
                Console.WriteLine("Error occured, because value is not an integer");
            }
        }

        public static void PrintTryParsingInfo()
        {
            Console.WriteLine("Enter integer value: ");
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine($"Yor value is {result} of type {result.GetType()}");
            }
            else
            {
                Console.WriteLine("Error occured, because value is not an integer");
            }
        }
    }
}