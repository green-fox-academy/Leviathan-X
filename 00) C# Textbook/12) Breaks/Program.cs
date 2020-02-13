using System;

namespace _12__Breaks
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.Write("\nHow many numbers would you like to add: ");
            int howMany = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your numbers. To abort, press \"a\"");

            for (int i = 0; i <= howMany; i++)
            {
                string userInput = Console.ReadLine();
                if (userInput == "a")
                {
                    break;
                }
                total += Int32.Parse(userInput);
            }
            Console.WriteLine("Total of number = " + total);



        }
    }
}
