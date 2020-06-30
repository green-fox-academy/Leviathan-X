using System;

namespace CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers ");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            if (second <= first)
            {
                Console.WriteLine("The second number should be bigger, try again");
            } else if (second > first)
            {
                for (int i = first; i <= second; i++)
                {
                    Console.WriteLine(i);
                }
            } else
            {
                Console.WriteLine("Error");
            }

        }
    }
}
