namespace Homework
{
    class Program
    {
        static int Chance(int Bet, int Guess)
        {
            Random RNG = new Random();
            int Number = RNG.Next(0, 31);
            int Output = Bet;
            bool IsPrime = true;
            if (Guess == Number)
            {
                Console.WriteLine($"Your guess of {Guess} was the correct number.");
                if (Number % 2 == 0)
                {
                    Console.WriteLine($"The number {Number} is even. Existing bet is 2x.");
                    Output *= 2;
                }
                if (Number % 10 == 0)
                {
                    Console.WriteLine($"The number {Number} is a multiple of 10. Existing bet is 3x.");
                    Output *= 3;
                }
                if (Number < 5)
                {
                    Console.WriteLine($"The number {Number} is below 5. Existing bet is 2x.");
                    Output *= 2;
                }
                for (int i = 2; i < Number; i++)
                {
                    if (Number % i == 0)
                    {
                        IsPrime = false;
                    }
                }
                if (IsPrime == true)
                {
                    Console.WriteLine($"The number {Number} is prime. Existing bet is 5x.");
                    Output *= 5;
                }
            }
            else
            {
                Console.WriteLine($"Your guess of {Guess} was incorrect. The number was {Number}.");
                Output = 0;
            }
            return Output;
        }
        static void Main(string[] args)
        {
            int UserBalance = 50; //Starting balance
            string UserInput = "";
            int UserBet = -1;
            int UserGuess = -1;
            while (UserInput != "end")
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nCurrent balance is {0:C}.\nDo you want to continue or end?\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~", UserBalance);
                UserInput = Console.ReadLine().ToLower();
                if (UserInput == "continue")
                {
                    while (UserBet > UserBalance || UserBet <= 0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nEnter an amount to bet.\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        UserBet = int.Parse(Console.ReadLine());
                    }
                    while (UserGuess > 30 || UserGuess < 0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nEnter your guess between 0 - 30.\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        UserGuess = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    UserBalance -= UserBet;
                    UserBalance += Chance(UserBet, UserGuess);
                    if (UserBalance == 0)
                        break;
                    UserInput = "";
                    UserBet = -1;
                    UserGuess = -1;
                }
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nFinal balance was {0:C}.\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~", UserBalance);
        }
    }
}