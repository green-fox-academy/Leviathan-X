using System;

namespace _03__Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n** Welcome to the Anagram Comparer! **");

            //string input1 = "Listen";
            //string input2 = "Silent";
            string input1 = "Mother In Law";
            string input2 = "Woman Hitler";

            var derNeueAnagrame = new Anagram(input1, input2, true);
            derNeueAnagrame.CompareWords();

            Console.WriteLine("\n\nFeel free to try your own Anagrams.");
            string consent = "yes";
            do
            {
                Console.Write("\n\nContinue? (y/n): ");
                var userInput = Console.ReadKey().Key;
                if (userInput == ConsoleKey.N)
                {
                    consent = "no";
                    Console.WriteLine("\n\nHave a nice day!");
                }
                else if (userInput == ConsoleKey.Y)
                {
                    string userWord1;
                    string userWord2;

                    Console.WriteLine("\n\nPlease write your word or set of words you'd like to compare: ");
                    Console.Write($"Your first word/s:  ");
                    userWord1 = Console.ReadLine();
                    Console.Write($"Your second word/s: ");
                    userWord2 = Console.ReadLine();

                    var userAnagram = new Anagram(userWord1, userWord2, false);
                    userAnagram.CompareWords();
                }
                else 
                {
                    Console.WriteLine("\nPlease try again. Press Y or N.");
                }
            } while (consent == "yes");
        }
    }
}
