using System;

namespace _11__Nesting_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0} ", i * j);
                }
             Console.WriteLine();

            }

            string nextStudent;
            do
            {
                double marksTotal = 0;
                int marksNumber = 0;
                int markAdded = 0;

                do
                {
                    Console.Write("\nEnter the students mark\n(If you'd like to stop, add a zero): ");
                    markAdded = Int32.Parse(Console.ReadLine());
                    
                    if ((markAdded > 5) || (markAdded < 0))  {
                        Console.WriteLine("\nInvalid mark, please try again.");
                    }
                    if ((markAdded != 0) && (markAdded <= 5) && (markAdded > 0))
                    {
                        marksTotal += markAdded;
                        marksNumber += 1;
                        Console.WriteLine("\nMark has been added.");
                    }
                } while (markAdded != 0);

                double average = marksTotal / marksNumber;
                Console.WriteLine("\nThe aritmethical average is: " + average);

                Console.Write("\nWould you like to calculate a new average? (y/n): ");
                nextStudent = Console.ReadLine();

            } while (nextStudent == "y");

        }
    }
}
