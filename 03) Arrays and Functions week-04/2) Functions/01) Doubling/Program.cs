using System;

namespace _01__Doubling
{
    class Program
    {
        static int Doubling (int input)
        {
            return input * 2;
        }

        static void Main(string[] args)
        {
            // - Create an integer variable named `baseNum` and assign the value `123` to it
            // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `Doubling(baseNum)`

            int baseNum = 123;

            Console.WriteLine(Doubling(baseNum));

        }
    }
}
