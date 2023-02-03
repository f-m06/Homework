using System;
namespace Homework
{
    class Program
    {
        static void Valid(String CreditCardNumber)
        {
            Int32 RunningTotal = 0;
            for (int i = 1; i <= 15; i += 2)
            {
                Int32 Total = Int32.Parse(CreditCardNumber.Substring(i, 1));
                RunningTotal += Total;
            }
            for (int i = 0; i <= 15; i += 2)
            {
                Int32 Total = Int32.Parse(CreditCardNumber.Substring(i, 1));
                Total *= 2;
                if (Total > 9)
                {
                    Total -= 9;
                }
                RunningTotal += Total;
            }
            if (RunningTotal % 10 == 0)
            {
                Console.WriteLine($"Credit card number {CreditCardNumber} is valid");
            }
            else
            {
                Console.WriteLine($"Credit card number {CreditCardNumber} is invalid");
            }
            Console.WriteLine("~~~~~~~~~~");
        }
        static void Main(String[] args)
        {
            String UserInput = "";
            Console.WriteLine("~~~~~~~~~~");
            while (UserInput != "end")
            {
                Console.WriteLine("Enter a 16 digit credit card number\nEnter end to terminate the program\n~~~~~~~~~~");
                UserInput = Console.ReadLine();
                if (UserInput.Length == 16)
                {
                    Valid(UserInput);
                }
            }
        }
    }
}