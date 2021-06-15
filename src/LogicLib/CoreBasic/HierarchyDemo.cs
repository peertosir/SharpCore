using System;

namespace LogicLib.CoreBasic
{
    public class HierarchyDemo
    {
        public static void PrintSomeInheritedStaff()
        {
            int a = 12;
            Console.WriteLine("Integer is a child of ValueType. ValueType is a child of Object");
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Equals(12));
            Console.WriteLine(a.GetType());
        }
    }
}