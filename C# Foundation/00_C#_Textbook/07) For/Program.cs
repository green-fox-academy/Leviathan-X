using System;

namespace _7__For
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueRound = "y";
            do
            {
                Console.WriteLine("\nPlease write how many numbers you'd like to count, and then write the numbers themselves.");
                Console.Write("Set how many numbers: ");
                int howMany = Int32.Parse(Console.ReadLine());
                int total = 0;

                for (int i = 1; i <= howMany; i++)
                {
                    Console.Write("Choose your {0}. number: ", i);

                    total += Int32.Parse(Console.ReadLine());
                }
                Console.WriteLine("The total of set numbers is: " + total);

                Console.Write("\nWould you like another round? y/n: ");
                continueRound = Console.ReadLine();

            } while (continueRound == "y");             
            

        }
    }
}
