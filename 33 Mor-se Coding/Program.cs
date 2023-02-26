using System;
namespace Homework
{
    class Program
    {
        static string EnglishToMorse(string Input)
        {
            string[] English = new string[] { " ", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string[] Morse = new string[] { "|", ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----" };
            string Output = "";
            for (int i = 0; i < Input.Length; i++)
            {
                foreach (string Character in English)
                {
                    if (Input.Substring(i, 1) == Character)
                    {
                        Output += Morse[Array.IndexOf(English, Character)];
                        break;
                    }
                }
            }
            return Output;
        }
        static void Main(string[] args)
        {
            string UserInput = "";
            while (UserInput == "")
            {
                Console.WriteLine("\nEnter a string of characters to convert to Morse Code\n");
                UserInput = Console.ReadLine();
            }
            Console.WriteLine(EnglishToMorse(UserInput));
        }
    }
}