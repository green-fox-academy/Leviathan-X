using System;

namespace _10__Draw_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "y";
            do
            {
                Console.Write("\nSet a number for a size of the Pyramid: ");
                int size = Int32.Parse(Console.ReadLine());

                for (int i = 0; i <= size; i++)
                {
                    for (int j = i; j < size; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k < (i * 2); k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.Write("\n\nDo you wish to continue?\n(y/n): ");
                cont = Console.ReadLine();

            } while (cont == "y");
            
        }
    }
}
