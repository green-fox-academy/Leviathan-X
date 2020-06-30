using System;

namespace _15__Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nHow many salaries?: ");
            int num = Int32.Parse(Console.ReadLine());

            int[] salaries = new int[num];

            int count = 0;
            foreach (var item in salaries)
            {
                Console.Write($"Salary n. {count + 1}: ");
                salaries[count] = Int32.Parse(Console.ReadLine());
                count++;
            }

            Console.WriteLine($"\nThe average salary is: {AverageSalary(salaries)}");

            Console.WriteLine($"\nThe smallest salary is: {SmallestSalary(salaries)}");

            Console.WriteLine($"\nThe biggest salary is: {BiggestSalary(salaries)}");

        }

        static int AverageSalary(int[] input)
        {
            if (input.Length > 0)
            {
                int total = 0;
                foreach (var salary in input)
                {
                    total += salary;
                }
                return total / input.Length;
            }
            else
            {
                return 0;
            }
        }
        static int SmallestSalary(int[] input)
        {
            if (input.Length > 0)
            {
                Array.Sort(input);
                return input[0];
            }
            else
            {
                return 0;
            }
        }
        static int BiggestSalary(int[] input)
        {
            if (input.Length > 0)
            {
                int max = input[0];
                foreach (var item in input)
                {
                    if (item > max) max = item;
                }
                return max;
            }
            else
            {
                return 0;
            }
        }
    }
}
