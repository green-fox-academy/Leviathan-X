using System;

namespace _20__Print_All
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {4, 5, 6, 7};

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ". ");
            }

        }
    }
}
