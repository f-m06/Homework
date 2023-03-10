using System;
namespace Homework
{
    class Program
    {
        static string CalculatePI(int Digits)
        {
            Digits++;

            int[] x = new int[Digits * 10 / 3 + 2];
            int[] y = new int[Digits * 10 / 3 + 2];

            int[] PI = new int[Digits];

            for (int j = 0; j < x.Length; j++)
                x[j] = 20;
            for (int i = 0; i < Digits; i++)
            {
                int Carry = 0;
                for (int j = 0; j < x.Length; j++)
                {
                    int Num = (x.Length - j - 1);
                    int Dem = Num * 2 + 1;

                    x[j] += Carry;

                    int a = x[j] / Dem;
                    y[j] = x[j] % Dem;

                    Carry = a * Num;
                }


                PI[i] = (x[x.Length - 1] / 10);


                y[x.Length - 1] = x[x.Length - 1] % 10; ;

                for (int j = 0; j < x.Length; j++)
                    x[j] = y[j] * 10;
            }

            string Result = "";

            int c = 0;

            for (int i = PI.Length - 1; i >= 0; i--)
            {
                PI[i] += c;
                c = PI[i] / 10;

                Result = (PI[i] % 10).ToString() + Result;
            }

            return Result.Insert(1, ".");
        }
        static void Main(string[] args)
        {
            int NumOfDigits = 0;
            string Dash = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
            while (NumOfDigits < 1)
            {
                Console.WriteLine(Dash + "\nInput digits of PI to calculate to:\n" + Dash);
                NumOfDigits = int.Parse(Console.ReadLine());
            }
            Dash = "";
            for (int i = 0; i < (NumOfDigits + 2); i++)
            {
                Dash += "~";
            }
            Console.WriteLine(Dash + "\n" + CalculatePI(NumOfDigits) + "\n" + Dash);
        }
    }
}