using System;
using System.Reflection.Metadata;

namespace LogicGate
{
    class Program
    {
        static String Logic(String LogicGate, Int32 Number1, Int32 Number2)
        {
            Int32 Output = 0;
            switch (LogicGate)
            {
                case "OR":
                    if (Number1 == 1 || Number2 == 1)
                    {
                        Output = 1;
                    }
                    return $"Input 1 = {Number1}\nInput 2 = {Number2}\n Output = {Output}\n~~~~~~~~~~";
                case "AND":
                    if (Number1 == 1 && Number2 == 1)
                    {
                        Output = 1;
                    }
                    return $"Input 1 = {Number1}\nInput 2 = {Number2}\n Output = {Output}\n~~~~~~~~~~";
                case "XOR":
                    if ((Number1 == 1 && Number2 == 1) || (Number1 == 0 && Number2 == 1))
                    {
                        Output = 1;
                    }
                    return $"Input 1 = {Number1}\nInput 2 = {Number2}\n Output = {Output}\n~~~~~~~~~~";
                case "NAND":
                    if (Number1 == 0 || Number2 == 0)
                    {
                        Output = 1;
                    }
                    return $"Input 1 = {Number1}\nInput 2 = {Number2}\n Output = {Output}\n~~~~~~~~~~";
                case "NOR":
                    if (Number1 == 0 || Number2 == 0)
                    {
                        Output = 1;
                    }
                    return $"Input 1 = {Number1}\nInput 2 = {Number2}\n Output = {Output}\n~~~~~~~~~~";
                default:
                    return null;
            }
        }
        static void Main(String[] args)
        {
            String LogicGateInput = "";
            Int32 Input1 = -1;
            Int32 Input2 = -1;
            Console.WriteLine("~~~~~~~~~~");
            while (LogicGateInput != "OR" && LogicGateInput != "AND" && LogicGateInput != "XOR" && LogicGateInput != "NAND" && LogicGateInput != "NOR")
            {
                Console.WriteLine("Enter logic gate\nOR\nAND\nXOR\nNAND\nNOR\n~~~~~~~~~~");
                LogicGateInput = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("~~~~~~~~~~");
            while (Input1 != 0 && Input1 != 1)
            {
                Console.WriteLine("Enter value of input 1\n0 - Off\n1 - On\n~~~~~~~~~~");
                Input1 = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("~~~~~~~~~~");
            while (Input2 != 0 && Input2 != 1)
            {
                Console.WriteLine("Enter value of input 2\n0 - Off\n1 - On\n~~~~~~~~~~");
                Input2 = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("~~~~~~~~~~");
            Logic(LogicGateInput, Input1, Input2);
        }

    }
}