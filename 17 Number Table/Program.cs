using System;

namespace Homework
{
    class Program
    {
        static void Table(char Symbol, int Number)
        {
            string Output = $"{Symbol} | ";
            for (int i = 0; i <= Number; i++)
            {
                Output = String.Concat(Output, i.ToString(), " ");
            }
            Console.WriteLine(Output);
            Console.WriteLine("----------");
            switch (Symbol)
            {
                case '+':
                    for (double column = 0.00; column <= Number; column++)
                    {
                        Output = $"{column} | ";
                        for (double row = 0.00; row <= Number; row++)
                        {
                            Output = String.Concat(Output, (column + row).ToString("0.##"), " ");
                        }
                        Console.WriteLine(Output);
                    }
                    break;
                case '-':
                    for (double column = 0.00; column <= Number; column++)
                    {
                        Output = $"{column} | ";
                        for (double row = 0.00; row <= Number; row++)
                        {
                            Output = String.Concat(Output, (column - row).ToString("0.##"), " ");
                        }
                        Console.WriteLine(Output);
                    }
                    break;
                case '*':
                    for (double column = 0.00; column <= Number; column++)
                    {
                        Output = $"{column} | ";
                        for (double row = 0.00; row <= Number; row++)
                        {
                            Output = String.Concat(Output, (column * row).ToString("0.##"), " ");
                        }
                        Console.WriteLine(Output);
                    }
                    break;
                case '/':
                    for (double column = 0.00; column <= Number; column++)
                    {
                        Output = $"{column} | ";
                        for (double row = 1; row <= Number; row++)
                        {
                            Output = String.Concat(Output, (column / row).ToString("0.##"), " ");
                        }
                        Console.WriteLine(Output);
                    }
                    break;
            }
        }
        static void Main(string[] args)
        {
            char UserSymbol = ' ';
            int UserNumber = 0;
            while (UserSymbol != '+' && UserSymbol != '-' && UserSymbol != '*' && UserSymbol != '/')
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~\nEnter a symbol: +, -, *, /\n~~~~~~~~~~~~~~~~~~~~~~~~~~");
                UserSymbol = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            while (UserNumber < 1)
            {
                Console.WriteLine("Enter a natural number\n~~~~~~~~~~~~~~~~~~~~~~~~~~");
                UserNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Table(UserSymbol, UserNumber);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}