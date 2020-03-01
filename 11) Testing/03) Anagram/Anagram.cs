using System;
using System.Collections.Generic;
using System.Text;

namespace _03__Anagram
{
    class Anagram
    {
        private string Word1;
        private string Word2;
        private char[] Word1Modify;
        private char[] Word2Modify;

        private string Word1Base;
        private string Word2Base;

        private bool ExampleObject;

        public Anagram(string word1, string word2, bool exampleObject)
        {
            Word1 = word1;
            Word2 = word2;

            ExampleObject = exampleObject;
        }

        private bool SortInput()
        {
            Word1 = Word1.Replace(" ", string.Empty);   // "Word1.Trim()" doesn't do anything for some reason.
            Word2 = Word2.Replace(" ", string.Empty);

            Word1 = Word1.ToLower();
            Word2 = Word2.ToLower();
            
            Word1Modify = Word1.ToCharArray();
            Array.Sort(Word1Modify);
            // Word1 = Word1Modify.ToString();      - BIG NONO! Caused a real mess!
            Word1Base = new string(Word1Modify);    // Use this instead!

            Word2Modify = Word2.ToCharArray();
            Array.Sort(Word2Modify);
            // Word2 = Word2Modify.ToString();      - BIG NONO! Caused a real mess!
            Word2Base = new string(Word2Modify);    // Use this instead! 
            // Maybe it's because of the rule that "strings can't be changed"? Or something?

            if (Word1Base == Word2Base) return true;
            else return false;
        }

        public void CompareWords()
        {
            Console.WriteLine("\n");
            if(ExampleObject == true)
            {
                Console.WriteLine("-- Example: ");
            }
            Console.Write($"Words to Compare: \"{Word1}\" and \"{Word2}\"");
            
            bool result = SortInput();
            
            Console.WriteLine($"\nWord Base: \t  \"{Word1Base}\" and \"{Word2Base}\"" +
                $"\n\nAre these words Anagrams? \nResult: -- {result}! --");
        }
    }
}
