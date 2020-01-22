using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Green Fox";
            Greet(al);
        }
        static void Greet (string yoyoyo)
        {
            Console.WriteLine("\nGreetings, dear " + yoyoyo);
        }
    }
}
