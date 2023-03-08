using System;
namespace Homework
{
    class Program
    {
        static string PasswordGenerator(int Length)
        {
            string Output = "";
            string[] Array = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", " ", "!", "?", "#", "$", "%", "&", "'", "(", ")", "*", "+", "-", ".", "/", ":", ";", "<", ">", "=", "@", "[", "]", "^", "{", "}", "|", "~" };
            Random random = new Random();
            for (int i = 0; i < Length; i++)
            {
                Output += Array[random.Next(0, 90)];
            }
            return "Your generated password is:\n\n" + Output + "\n";
        }
        static void Main(string[] args)
        {
            int UserInput = 0;
            while (UserInput < 1)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nEnter length of password to generate\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                UserInput = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" + PasswordGenerator(UserInput) + "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}