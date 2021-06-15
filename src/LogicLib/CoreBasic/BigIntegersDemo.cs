using System;
using System.Numerics;

namespace LogicLib.CoreBasic
{
    public class BigIntegersDemo
    {
        public static void UseBigInteger()
        {
            Console.WriteLine("Using big integer: ");
            BigInteger bigInteger = BigInteger.Parse("999999999999999999999999999999999999999999999");
            Console.WriteLine($"Value of big integer is {bigInteger}");
            Console.WriteLine($"Is big integer variable value even? {bigInteger.IsEven}");
            Console.WriteLine($"Is big integer variable value a power of two? {bigInteger.IsPowerOfTwo}");
            BigInteger reallyBig = BigInteger.Multiply(bigInteger, BigInteger.Parse("8888888888888888"));
            Console.WriteLine(reallyBig);

        }
    }
}