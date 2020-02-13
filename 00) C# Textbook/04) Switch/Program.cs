using System;

namespace _4__Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Kalkulačka");
            Console.Write("1. Zadejte vaše první číslo: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.Write("2. Zadejte vaše druhé číslo: ");
            int y = Int32.Parse(Console.ReadLine());
            Console.Write("3. Zadejte požadovanou operaci\n( +, -, *, / ): ");
            string operace = Console.ReadLine();

            Console.WriteLine(" ");

            switch (operace)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}\n", x, y, x + y);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}\n", x, y, x - y);
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}\n", x, y, x * y);
                    break;
                case "/":
                    Console.WriteLine("{0} / {1} = {2}\n", x, y, x / y);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }


        }
    }
}
