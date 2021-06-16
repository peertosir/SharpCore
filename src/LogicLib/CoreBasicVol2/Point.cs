using System;

namespace LogicLib.CoreBasicVol2
{
    public struct Point
    {
        public int X;
        public int Y;

        public void Increment()
        {
            X++;
            Y++;
        }
        
        public void Decrement()
        {
            X--;
            Y--;
        }

        public void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }
    }
}