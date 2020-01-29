using System;
using System.Collections.Generic;

namespace _05__Personal_Finance
{
    class Program
    {
        static void Main(string[] args)
        {
            // We are going to represent our expenses in a list containing integers.

            // Create a list with the following items:
            // 500, 1000, 1250, 175, 800 and 120

            // Create an application which solves the following problems:
            // How much did we spend?
            // Which was our greatest expense?
            // Which was our cheapest spending?
            // What was the average amount of our spendings?

            List<int> personalFinance = new List<int>();

            personalFinance.Add(500);
            personalFinance.Add(1000);
            personalFinance.Add(1250);
            personalFinance.Add(175);
            personalFinance.Add(800);
            personalFinance.Add(120);

            Console.WriteLine("\nPersonal Finance values: ");
            for (int i = 0; i < personalFinance.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {personalFinance[i]}");
            }
            HowMuchSpent(personalFinance);
            GreatestAndCheapestExpense(personalFinance);
            SumAverage(personalFinance);
        }
        static void HowMuchSpent(List<int> UserInput)
        {
            int total = 0;                   //int total = UserInput.Sum(); -- System.Linq
            foreach (int expense in UserInput)
            {
                total += expense;
            }
            Console.WriteLine($"\nTotal sum spent: {total}");
        }
        static void GreatestAndCheapestExpense(List<int> UserInput)
        {
            UserInput.Sort();
            Console.WriteLine($"\nGreatest expense: {UserInput[UserInput.Count - 1]}");
            Console.WriteLine($"Cheapest expense: {UserInput[0]}");
        }
        static void SumAverage(List<int> UserInput)
        {
            int total = 0;
            foreach (int expense in UserInput)
            {
                total += expense;
            }
            int numOfElem = UserInput.Count;
            float average = (float)total / numOfElem;

            Console.WriteLine($"\nThe average of the spending is: {average}");
        }
    }
}

