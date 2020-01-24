using System;

namespace _02__Greet
{
    class Program
    {
        static void Greet (string input)
        {
            Console.WriteLine($"Greetings, dear {input}!");
        }
        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Green Fox` to it
            // - Create a function called `Greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Green Fox`
            // - Greet `al`

            string al = "Green Fox";
            Console.WriteLine();

            Greet(al);

        }
    }
}
