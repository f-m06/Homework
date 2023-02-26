using System;
namespace Homework
{
    class Program
    {
        static bool IsValidDate(string date)
        {
            DateTime Output;
            return DateTime.TryParse(date, out Output);
        }
        static string DayOfWeek(string date)
        {
            return DateTime.Parse(date).ToString("dddd");
        }
        static void Main(string[] args)
        {
            int DayInput = -1;
            int MonthInput = -1;
            int YearInput = -1;
            while (DayInput < 1 || DayInput > 31)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nEnter a day: 01 - 31\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                DayInput = int.Parse(Console.ReadLine());
            }
            while (MonthInput < 1 || MonthInput > 12)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nEnter a month: 01 - 12\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                MonthInput = int.Parse(Console.ReadLine());
            }
            while (YearInput < 1)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nEnter a year:\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                YearInput = int.Parse(Console.ReadLine());
            }
            string DateInput = DayInput.ToString("00") + '/' + MonthInput.ToString("00") + '/' + YearInput.ToString("00");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            if (IsValidDate(DateInput) == true)
            {
                Console.WriteLine($"The date {DateInput} is a valid and on that date it is a {DayOfWeek(DateInput)}.");
            }
            else
            {
                Console.WriteLine($"The date {DateInput} is invalid.");
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}