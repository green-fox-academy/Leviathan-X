using System;

namespace _01__DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0

            string consent = "y";
            Console.Write("\nYou've got a number 10. Please type a number by which you would like to divide it by.\n");
            do
            {
                try
                {
                    Console.Write("\nYour number: ");
                    int num = Int32.Parse(Console.ReadLine());
                    Divider(num);
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nFailure - Letters are not numbers! Please try again.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nFailure - Number too small or too large! Get realistic, buddy.");
                }
                finally
                {
                    Console.Write("\nAgain? (y/n): ");
                    consent = (Console.ReadLine());
                }
            } while(consent == "y");

        }
        static void Divider (int div)
        {
                try
                {
                    int result = 10 / div;
                    Console.WriteLine($"10 / {div} = {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Failure - Can't divide by zero! Please try again.");
                }
        }
    }
}
