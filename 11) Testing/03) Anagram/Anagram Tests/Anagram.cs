using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram_Tests
{
    class Anagram
    {
        private string Word1;
        private string Word2;
        private char[] Word1Modify;
        private char[] Word2Modify;

        private string Word1Base;
        private string Word2Base;

        public Anagram(string word1, string word2)
        {
            Word1 = word1;
            Word2 = word2;
        }

        public bool SortInput()
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
    }
}
