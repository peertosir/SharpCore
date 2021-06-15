using System;

namespace LogicLib.CoreBasic
{
    public class DateTimeAndSpanDemo
    {
        public static void UseDateAndTimes()
        {
            Console.WriteLine("Date and Time demo: ");
            DateTime dateTime = new DateTime(2021, 06, 15);
            Console.WriteLine($"The day of {dateTime.Date} is {dateTime.DayOfWeek}");
            Console.WriteLine($"Add two month for this date: ");
            dateTime = dateTime.AddMonths(2);
            Console.WriteLine($"The day to month further {dateTime.Date} is {dateTime.DayOfWeek}");
            TimeSpan timeSpan = new TimeSpan(4, 30, 45);
            Console.WriteLine(timeSpan);
            Console.WriteLine(
                $"{timeSpan} + 31 min 20 sec is {timeSpan.Add(new TimeSpan(0, 31, 20))}"
                );
        }
    }
}