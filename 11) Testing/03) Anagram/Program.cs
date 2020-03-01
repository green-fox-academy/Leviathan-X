using System;

namespace _03__Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n** Welcome to the Anagram Comparer! **");
            Anagram.ExampleAnagram();

            Console.WriteLine("\nFeel free to try out your own Anagrams.");
            Anagram.StartLoop();
        }
    }
}
