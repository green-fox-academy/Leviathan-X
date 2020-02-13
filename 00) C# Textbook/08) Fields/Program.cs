using System;

namespace _8__Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fieldOfNumbers = new int [3];
            string[] fieldOfStrings = new string [5];


            fieldOfNumbers[0] = 100;
            fieldOfNumbers[1] = 200;
            fieldOfNumbers[2] = 300;

            fieldOfStrings[0] = "Dumbass";
            fieldOfStrings[1] = "Wu Tang";
            fieldOfStrings[2] = "Mana";

            string contRound = "y";
            do
            {
                Console.Write("\nEnter how many numbers: ");
                int howMany = Int32.Parse(Console.ReadLine());
                int[] fieldMany = new int [howMany];
                int total = 0;

                for (int i = 0; i < howMany; i++)
                {
                    Console.Write("Enter your number: ");
                    int number = Int32.Parse(Console.ReadLine());
                    fieldMany[i] = number; 

                    total += number;
                }
                Console.WriteLine("The total is: " + total);


                int[] sumfield = new int[3];
                sumfield[0] = 4;
                sumfield[1] = 7;
                sumfield[2] = 8;

                Console.WriteLine("\nThe size of the field is {0}", sumfield.GetLength(0));
                Console.WriteLine("The numbers in the field are: ");
                for (int i = 0; i < sumfield.GetLength(0); i++)
                {
                    Console.WriteLine(sumfield[i]);
                }




                Console.Write("\nContinue? y/n: ");
                contRound = Console.ReadLine();
            } while (contRound == "y");

        }
    }
}
