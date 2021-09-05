using System;

namespace NUnitTestingPrograms
{
    class Program
    {
       public static int dayOfWeek(int date, int month, int year)
        {
            int y0 = year - ( 14 - month ) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (date + x + (31 * m0) / 12) % 7;
            return d0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NUnit Testing Programs");
            Console.WriteLine("Enter Date ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year ");
            int year = Convert.ToInt32(Console.ReadLine());
            string[] daysName = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = dayOfWeek(month, date, year);
            Console.WriteLine(daysName[day]);
        }
    }
}