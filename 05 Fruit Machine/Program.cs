using System;
namespace Homework
{
    class Program
    {
        static Int32 Roll(Int32 Earnings)
        {
            String[] Symbol = new String[6] { "Cherries", "Bells", "Lemons", "Oranges", "Stars", "Skulls" };
            String[] RolledSymbol = new String[3];
            Random rand = new Random();
            Int32 SymbolIndex = rand.Next(Symbol.Length);
            for (int i = 0; i < 3; i++)
            {
                RolledSymbol[i] = Symbol[SymbolIndex];
                SymbolIndex = rand.Next(Symbol.Length);
            }
            if (RolledSymbol[0] == RolledSymbol[1] && RolledSymbol[1] == RolledSymbol[2])
            {
                if (RolledSymbol[0] == "Skull")
                {
                    Console.WriteLine("3 Skulls\nBankrupt");
                    Earnings = 0;
                }
                else if (RolledSymbol[0] == "Bell")
                {
                    Console.WriteLine("3 Bells\n+500p");
                    Earnings += 500;
                }
                else
                {
                    Console.WriteLine($"3 {RolledSymbol[0]}\n+100p");
                    Earnings += 100;
                }
            }
            else if (RolledSymbol[0] == RolledSymbol[1] || RolledSymbol[0] == RolledSymbol[2])
            {
                if (RolledSymbol[0] == "Skull")
                {
                    Console.WriteLine("2 Skulls\n-100p");
                    Earnings -= 100;
                }
                else
                {
                    Console.WriteLine($"2 {RolledSymbol[0]}\n+50p");
                    Earnings += 50;
                }
            }
            else if (RolledSymbol[1] == RolledSymbol[2])
            {
                if (RolledSymbol[1] == "Skull")
                {
                    Console.WriteLine("2 Skulls\n-100p");
                    Earnings -= 100;
                }
                else
                {
                    Console.WriteLine($"2 {RolledSymbol[1]}\n+50p");
                    Earnings += 50;
                }
            }
            else
            {
                Console.WriteLine("No 2s or 3s");
            }
            return Earnings;
        }
        static void Main(String[] args)
        {
            String PlayerInput = "";
            Int32 PlayerCredit = 100;
            Console.WriteLine("This is a fruit machine\n~~~~~~~~~~");
            while (PlayerInput != "end" && PlayerCredit >= 20)
            {
                Console.WriteLine($"Type continue to roll the machine\nType end to withdraw remaining cash of {PlayerCredit}p\n~~~~~~~~~~");
                PlayerInput = Console.ReadLine();
                Console.WriteLine("~~~~~~~~~~");
                if (PlayerInput == "continue")
                {
                    PlayerCredit -= 20;
                    PlayerCredit = Roll(PlayerCredit);
                    Console.WriteLine("~~~~~~~~~~");
                }
            }
            if (PlayerCredit < 0)
            {
                PlayerCredit = 0;
            }
            Console.WriteLine($"Final cash is {PlayerCredit}\n~~~~~~~~~~");
        }
    }
}