using System;

namespace _6__Do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueProgram = "y";
            do
            {
                Console.Write("\nEnter a number smaller than 10, yet bigger than 0: ");
                int number = Int32.Parse(Console.ReadLine());
                int total = 0;
                Console.WriteLine(" ");
                while ((number < 10) && (number > 0))
                {
                    Console.WriteLine("Total = {0} + {1}", total, number);
                    total = total + number;
                    number = number - 1;
                }
                Console.WriteLine("Total = " + total);

                Console.Write("\nAgain? y/n: ");
                continueProgram = Console.ReadLine();

            } while ((continueProgram == "y"));
        }

    }
}
