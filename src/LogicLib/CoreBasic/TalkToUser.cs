using System;

namespace LogicLib.CoreBasic
{
    public class TalkToUser
    {
        public static void Talk()
        {
            Console.WriteLine("Hello! What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine($"Nice to meet you, {name}. You are {age} years old");
        }
    }
}