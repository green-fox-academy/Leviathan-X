using System;

namespace _05__Factorio
{
    class Program
    {
        static void Factorio (long input)
        {
            long facto2 = input;
            long facto = facto2;

            for (int i = 1; i < input; i++)
            {
                facto *= i;
                Console.WriteLine($"{i} \t* {facto2:N0} \t\t\t\t = {facto:N0}");
                facto2 = facto;
            }
            Console.WriteLine($"\n\nThe factorial of {input}! is: {facto:N0}.");
        }
        private static long UserInput()
        {
            string numCorrect = "no";
            long num;
            do
            {
                Console.Write("\nYour number: ");
                num = Int32.Parse(Console.ReadLine());

                if (num > 1 && num < 21)
                {
                    numCorrect = "yes";
                    return num;

                } else
                {
                    Console.WriteLine("\nLoading..\n\nThe number must be bigger than 1 and less than 21.\nPlease try again.");
                }
                
            } while (numCorrect == "no");
            return num;
        }

        static void Main(string[] args)
        {
            // - Create a function called `Factorio`
            //   that returns it's input's factorial
            // - Factorial example: 5! = 5 * 4 * 3 * 2 * 1 = 120

            string consent;
            do
            {
                Console.WriteLine("\nThis program calculates a numbers factorial.\nFactorial example: 5! = 5 * 4 * 3 * 2 * 1 = 120");

                long num = UserInput();

                Console.WriteLine("\nLoading..\n\n");

                Factorio(num);


                Console.Write("\n\nDo you wish to continue? (y/n): ");
                consent = Console.ReadLine();
            } while (consent == "y" || consent == "Y");
        }
    }
}
