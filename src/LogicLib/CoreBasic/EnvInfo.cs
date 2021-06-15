using System;

namespace LogicLib.CoreBasic
{
    public class EnvInfo
    {
        public static void PrintSystemInfo()
        {
            Console.Beep();
            Console.Title = "System Info";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Here is your system information, {Environment.UserName}: \n");
            Console.WriteLine($"Machine name: {Environment.MachineName}");
            foreach (var drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine($"Drive: {drive}");
            }

            Console.WriteLine($"OS: {Environment.OSVersion}");
            Console.WriteLine($"Number of processors: {Environment.ProcessorCount}");
            Console.WriteLine($".NET version: {Environment.Version}");
        }
    }
}