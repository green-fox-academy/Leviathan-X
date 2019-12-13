using System;

namespace AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            Console.WriteLine("Greetings, please enter five variables to calculate their average");
            int val1;
            string input1;
            input1 = Console.ReadLine();
            val1 = Convert.ToInt32(input1);

            int val2;
            string input2;
            input2 = Console.ReadLine();
            val2 = Convert.ToInt32(input2);

            int val3;
            string input3;
            input3 = Console.ReadLine();
            val3 = Convert.ToInt32(input3);

            int val4;
            string input4;
            input4 = Console.ReadLine();
            val4 = Convert.ToInt32(input4);

            int val5;
            string input5;
            input5 = Console.ReadLine();
            val5 = Convert.ToInt32(input5);

            Console.WriteLine("Loading..");
            int result = (val1 + val2 + val3 + val4 + val5) / 5;
            Console.WriteLine("The final result is: " + result);
        }
    }
}
