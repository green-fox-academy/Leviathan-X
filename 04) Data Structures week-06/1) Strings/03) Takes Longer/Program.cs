using System;
using System.Text;

namespace _03__Takes_Longer
{
    class Program
    {
        static void Main(string[] args)
        {
            // string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)
            Console.WriteLine();

            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            StringBuilder build = new StringBuilder("\nHofstadter's Law: It you expect, even when you take into account Hofstadter's Law.");

            Console.WriteLine(quote.IndexOf("you expect"));
            build = build.Insert(21, " always takes longer than");

            Console.WriteLine(build);

        }
    }
}
