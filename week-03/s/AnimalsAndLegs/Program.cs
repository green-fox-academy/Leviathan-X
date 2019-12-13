using System;

namespace AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.WriteLine("\nThe Leg Counter\nThere's a chicken farm and a pig farm.\n" +
                "First, enter how many chickens there are: ");
            int chick;
            string val1;
            val1 = Console.ReadLine();
            chick = Convert.ToInt32(val1);
            
            Console.WriteLine("And now, enter how many pigs there are: ");
            int pig;
            string val2;
            val2 = Console.ReadLine();
            pig = Convert.ToInt32(val2);
            Console.WriteLine("Loading...");
            int result = (chick * 2) + (pig * 4);
            Console.WriteLine("There are " + result + " legs on all the farms");

        }
    }
}
