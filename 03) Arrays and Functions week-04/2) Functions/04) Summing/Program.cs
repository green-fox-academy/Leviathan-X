using System;

namespace _04__Summing
{
    class Program
    {
        static int Sum (int input)
        {
            int sum = 0;
            for (int i = 0; i <= input; i++)
            {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            // Write a function called `sum` that returns the sum of numbers from zero to the given parameter

            Console.Write("\nThis program returns the sum of numbers from zero to the given parameter.\nPlease enter a number: ");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(Sum(num));

        }
    }
}
