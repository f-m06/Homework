using System;
namespace Homework
{
    class Program
    {
        static void Temperature()
        {
            Int32 Choice = 0;
            while (Choice != 1 && Choice != 2)
            {
                Console.WriteLine("~~~~~~~~~~\n1 - Celsius -> Fahrenheit\n2 - Fahrenheit -> Celsius\n~~~~~~~~~~");
                Choice = Int32.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    CelsiusToFahrenheit();
                }
                else
                {
                    FahrenheitToCelsius();
                }
            }
            static void CelsiusToFahrenheit()
            {
                Double Value = 0;
                Console.WriteLine("~~~~~~~~~~\nEnter value to convert\n~~~~~~~~~~");
                Value = Double.Parse(Console.ReadLine());
                Value = (Value * 1.8) + 32;
                Console.WriteLine($"~~~~~~~~~~\n{Math.Round(Value, 2)} Degrees Fahrenheit\n~~~~~~~~~~");
            }
            static void FahrenheitToCelsius()
            {
                Double Value = 0;
                Console.WriteLine("~~~~~~~~~~\nEnter value to convert\n~~~~~~~~~~");
                Value = Double.Parse(Console.ReadLine());
                Value = (Value - 32) * 1.8;
                Console.WriteLine($"~~~~~~~~~~\n{Math.Round(Value, 2)} Degrees Celsius\n~~~~~~~~~~\"");
            }
        }
        static void Currency()
        {
            Int32 Choice = 0;
            while (Choice != 1 && Choice != 2 && Choice != 3 && Choice != 4 && Choice != 5 && Choice != 6)
            {
                Console.WriteLine("~~~~~~~~~~\n1 - GBP -> USD\n2 - GBP -> EUR\n3 - USD -> GBP\n4 - USD -> EUR\n5 - EUR -> GBP\n6 - EUR -> USD\n~~~~~~~~~~");
                Choice = Int32.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    GBPToUSD();
                }
                else if (Choice == 2)
                {
                    GBPToEUR();
                }
                else if (Choice == 3)
                {
                    USDToGBP();
                }
                else if (Choice == 4)
                {
                    USDToEUR();
                }
                else if (Choice == 5)
                {
                    EURToGBP();
                }
                else
                {
                    EURToUSD();
                }
            }
            static void GBPToUSD()
            {
                Double Value = 0;
                Console.WriteLine("~~~~~~~~~~\nEnter value to convert\n~~~~~~~~~~");
                Value = Double.Parse(Console.ReadLine());
                Value *= 1.21;
                Console.WriteLine($"~~~~~~~~~~\n{Math.Round(Value, 2)} USD\n~~~~~~~~~~\"");
            }
            static void GBPToEUR()
            {
                Double Value = 0;
                Console.WriteLine("~~~~~~~~~~\nEnter value to convert\n~~~~~~~~~~");
                Value = Double.Parse(Console.ReadLine());
                Value *= 1.12;
                Console.WriteLine($"~~~~~~~~~~\n{Math.Round(Value, 2)} EUR\n~~~~~~~~~~\"");
            }
            static void USDToGBP()
            {
                Double Value = 0;
                Console.WriteLine("~~~~~~~~~~\nEnter value to convert\n~~~~~~~~~~");
                Value = Double.Parse(Console.ReadLine());
                Value *= 0.83;
                Console.WriteLine($"~~~~~~~~~~\n{Math.Round(Value, 2)} GBP\n~~~~~~~~~~\"");
            }
            static void USDToEUR()
            {
                Double Value = 0;
                Console.WriteLine("~~~~~~~~~~\nEnter value to convert\n~~~~~~~~~~");
                Value = Double.Parse(Console.ReadLine());
                Value *= 0.92;
                Console.WriteLine($"~~~~~~~~~~\n{Math.Round(Value, 2)} EUR\n~~~~~~~~~~\"");
            }
            static void EURToGBP()
            {
                Double Value = 0;
                Console.WriteLine("~~~~~~~~~~\nEnter value to convert\n~~~~~~~~~~");
                Value = Double.Parse(Console.ReadLine());
                Value *= 0.9;
                Console.WriteLine($"~~~~~~~~~~\n{Math.Round(Value, 2)} GBP\n~~~~~~~~~~\"");
            }
            static void EURToUSD()
            {
                Double Value = 0;
                Console.WriteLine("Enter value to convert\n~~~~~~~~~~");
                Value = Double.Parse(Console.ReadLine());
                Value *= 1.08;
                Console.WriteLine($"~~~~~~~~~~\n{Math.Round(Value, 2)} USD\n~~~~~~~~~~\"");
            }
        }
        static void Volume()
        {
            Int32 Choice = 0;
            while (Choice != 1 && Choice != 2)
            {
                Console.WriteLine("~~~~~~~~~~\n1 - Cubic Metre -> Cubic Feet\n2 - Cubic Feet -> Cubic Metre\n~~~~~~~~~~");
                Choice = Int32.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    CubicMetreToCubicFeet();
                }
                else
                {
                    CubicFeetToCubicMetre();
                }
            }
            static void CubicMetreToCubicFeet()
            {
                Double Value = 0;
                Console.WriteLine("~~~~~~~~~~\nEnter value to convert\n~~~~~~~~~~");
                Value = Double.Parse(Console.ReadLine());
                Value *= 35.315;
                Console.WriteLine($"~~~~~~~~~~\n{Math.Round(Value, 2)} Cubic Feet\n~~~~~~~~~~\"");
            }
            static void CubicFeetToCubicMetre()
            {
                Double Value = 0;
                Console.WriteLine("~~~~~~~~~~\nEnter value to convert\n~~~~~~~~~~");
                Value = Double.Parse(Console.ReadLine());
                Value /= 35.315;
                Console.WriteLine($"~~~~~~~~~~\n{Math.Round(Value, 2)} Cubic Metres\n~~~~~~~~~~\"");
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