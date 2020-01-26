using System;

namespace _06__SubInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a number and an array of integers as a parameter
            //  Returns the indices of the integers in the array of which the first number is a part of
            //  Or returns an empty array if the number is not part of any of the integers in the array

            //  Example:
            //  Console.WriteLine(SubInt(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            //  Console.WriteLine(SubInt(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'

            Console.WriteLine("\nLet's see if and where your int is in the array. Guess a number from 1 to 9.");
            int[] array = { 1, 11, 34, 52, 61 };

            string consent = "y";
            do
            {
                Console.Write("Please enter your int: ");
                int i = Int32.Parse(Console.ReadLine()); 
                SubInt(i, array);

                Console.Write("\nDo you wish to continue? (y/n): ");
                consent = Console.ReadLine();
            } while (consent == "y");
            
        }
        static void SubInt (int i, int[] j)
        {

        }
    }
}