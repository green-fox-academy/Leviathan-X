using System;

namespace _10__Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 3;
            numbers[1] = 7;
            numbers[2] = 17;

            string[] strings = new string[4];
            strings[0] = "one";
            strings[1] = "two";
            strings[2] = "three";
            strings[3] = "four";

            Console.WriteLine("\nField of numbers contains the following variables: ");
            foreach (int variable in numbers)
            {
                Console.WriteLine(variable);
            }


            Console.WriteLine("\nField of strings contains the following variables: ");
            foreach (string variable in strings)
            {
                Console.WriteLine(variable);
            }

        }
    }
}
