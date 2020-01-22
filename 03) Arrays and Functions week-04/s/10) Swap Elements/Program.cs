using System;

namespace _10__Swap_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`

            string[] abc = new string[] { "first", "second", "third" };

            string store = null;
            store = abc[0];
            abc[0] = abc[2];
            abc[2] = store;
            Console.WriteLine("\n{0}, {1}", abc [0], abc[2]);

        }
    }
}
