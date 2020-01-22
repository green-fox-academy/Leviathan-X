using System;

namespace PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            Console.WriteLine("Greetings.\nPlease enter two numbers, and this program will compare which one is bigger.");

            Console.Write("\nNumber A: ");
            string valStr1 = Console.ReadLine();
            int val1 = Int32.Parse(valStr1);

            Console.Write("Number B: ");
            string valStr2 = Console.ReadLine();
            int val2 = Int32.Parse(valStr2);

            Console.WriteLine("\nLoading..");

            if (val1 > val2) 
            {
                Console.WriteLine(val1 + " is bigger than " + val2);
            } else if (val1 < val2) 
            {
                Console.WriteLine(val2 + " is bigger than " + val1);
            } else if (val1 == val2) 
            {
                Console.WriteLine("These numbers have the same value.");
            } else 
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
