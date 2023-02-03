using System;
namespace Homework
{
    class Program
    {
        static void Temperature()
        {
            ;
            static void CelsiusToFahrenheit()
            {
                ;
            }
            static void FahrenheitToCelsius()
            {
                ;
            }
        }
        static void Currency()
        {
            ;
            static void GBPToUSD()
            {
                ;
            }
            static void GBPToEUR()
            {
                ;
            }
            static void USDToGBP()
            {
                ;
            }
            static void USDToEUR()
            {
                ;
            }
            static void EURToGBP()
            {
                ;
            }
            static void EURToUSD()
            {
                ;
            }
        }
        static void Volume()
        {
            ;
            static void CubicMetreToCubicFoot()
            {
                ;
            }
            static void CubicFootToCubicMetre()
            {
                ;
            }
        }
        static void Main(String[] args)
        {
            String UserInput = "";
            Console.WriteLine("~~~~~~~~~~");
            while (UserInput != "end")
            {
                Console.WriteLine("Enter a type of measurement\nTemperature\nCurrency\nVolume\nEnter end to terminate the program\n~~~~~~~~~~");
                UserInput = Console.ReadLine();
                if (UserInput.ToLower() == "temperature")
                {
                    Temperature();
                }
                else if (UserInput.ToLower() == "currency")
                {
                    Currency();
                }
                else if (UserInput.ToLower() == "volume")
                {
                    Volume();
                }
            }
        }
    }
}