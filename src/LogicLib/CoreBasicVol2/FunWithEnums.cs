using System;

namespace LogicLib.CoreBasicVol2
{
    public class FunWithEnums
    {
        public static void PrintInfoUnderType()
        {
            Console.WriteLine($"EmployeeTypeEnum uses a {Enum.GetUnderlyingType(typeof(EmployeeTypeEnum))}");
            var enumData = Enum.GetValues(typeof(EmployeeTypeEnum));
            Console.WriteLine($"EmployeeTypeEnum has {enumData.Length} members");
            foreach (var enumValue in enumData)
            {
                Console.WriteLine($"Name: {enumValue}. Value: {enumValue:D}");
            }
        }
        
        
    }
}