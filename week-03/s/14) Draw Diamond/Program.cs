using System;

namespace _14__Draw_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            string consent = "y";
            do
            {
                Console.Write("Enter your value: ");
                int num = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                // First Pyramid
                for (int i = 1; i <= num; i++)
                {
                    for (int j = i; j < num; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 1; k < i * 2; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                // Second Pyramid
                int count = 1;
                for (int i = 1; i <= num - 1; i++)
                {
                    for (int j = 1; j <= count; j++)
                    {
                        Console.Write(" ");
                    }

                    count++;

                    for (int k = 1; k <= 2 * (num - i) - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                Console.Write("\nContinue? (y/n): ");
                consent = Console.ReadLine();
            } while (consent == "y");
        
        }
    }
}
