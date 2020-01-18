using System;

namespace _11__Draw_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nSet a number for a size of the Pyramid: ");
            int size = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    Console.Write("d");
                }
                for (int k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    Console.Write("d");
                }
                for (int k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
