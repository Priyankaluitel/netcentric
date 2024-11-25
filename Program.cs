using System;

class Program
{
    static void Main()
    {
        int year = 2024;  
        int month = 12;  
        DateTime firstDay = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);
        int startDay = (int)firstDay.DayOfWeek;
        Console.WriteLine($"Calendar for {firstDay:MMMM yyyy}");
        Console.WriteLine("Su Mo Tu We Th Fr Sa");

        int currentDay = 1;

        for (int week = 0; week < 6; week++)
        {
            for (int day = 0; day < 7; day++)
            {
                if ((week == 0 && day < startDay) || currentDay > daysInMonth)
                {
                    Console.Write("   ");  
                }
                else
                {
                    Console.Write($"{currentDay,2} ");  
                    currentDay++;
                }
            }
            Console.WriteLine();  
        }
    }
}
