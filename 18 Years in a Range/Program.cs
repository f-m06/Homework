using System;

namespace Homework
{
    class Program
    {
        static void RepeatedDigit(int CurrentYear, int YearRange)
        {
            string Output = "";
            for (int i = 1; i <= YearRange; i++)
            {
                Output = $"The year {CurrentYear} does not have a repeated digit";
                for (int compare1 = 0; compare1 < CurrentYear.ToString().Length - 1; compare1++)
                {
                    for (int compare2 = compare1 + 1; compare2 < CurrentYear.ToString().Length; compare2++)
                    {
                        if (CurrentYear.ToString().Substring(compare1, 1) == CurrentYear.ToString().Substring(compare2, 1))
                        {
                            Output = $"The year {CurrentYear} has a repeated digit";
                            compare1 = CurrentYear.ToString().Length;
                            break;
                        }
                    }
                }
                Console.WriteLine(Output);
                CurrentYear += 1;
            }
        }
        static void Main(string[] args)
        {
            int UserYear = 0;
            int UserRange = 0;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            while (UserYear < 1)
            {
                Console.WriteLine("Enter year to start from\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                UserYear = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            while (UserRange < 1)
            {
                Console.WriteLine("Enter range of years to check for\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                UserRange = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            RepeatedDigit(UserYear, UserRange);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}