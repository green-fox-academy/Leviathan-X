using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number for the Multiplication Table: ");
            int userNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(userNumber + " * " + i + " = " + userNumber*i);
            }
        }
    }
}
