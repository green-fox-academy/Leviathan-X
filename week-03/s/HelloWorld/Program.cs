using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Enter your name: ";
            string name;

            Console.Write(message);

            name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + ".");

            Console.WriteLine(" ");

            


            string myString = "Hello";
            if (myString == "Hello")
            {
                Console.WriteLine("Yep.");
            }

            Console.WriteLine(" ");

            int myNumber = 10;
            if (myNumber == 11)
            {
                Console.WriteLine("myNumber is 10");
            } else
            {
                Console.WriteLine("myNumber isn't 10");
            }



            Console.WriteLine("Please enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            switch (userNumber)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", userNumber);
                    break;
                default:
                    Console.WriteLine("Your number has to be 10, 20, or 30");
                    break;
            }
        }
    }
}
