using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Most_Common_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"../../../Text.txt";

            Dictionary<char, int> Output = new Dictionary<char, int>(MostCommonCharacters(filePath));

            Console.WriteLine();
            // Console.WriteLine($"\"{Output.ElementAt(0).Key}\": {Output.ElementAt(0).Value}");
            // Console.WriteLine($"\"{Output.ElementAt(1).Key}\": {Output.ElementAt(1).Value}");
            foreach (KeyValuePair<char, int> pair in Output)
            {
                Console.WriteLine($"\"{pair.Key}\": {pair.Value}");
            }
        }

        static Dictionary<char, int> MostCommonCharacters(string inputPath)
        {
            Dictionary<char, int> errorDict = new Dictionary<char, int>();
            errorDict.Add(' ', 0);

            try
            {
                string input = File.ReadAllText(inputPath);
                string[] lines = input.Split(Environment.NewLine);

                List<string> words = new List<string>();
                foreach (var line in lines)
                {
                    words.AddRange(line.ToLower().Replace(",", "").Replace(".", "").Split(' '));
                }

                List<char> characters = new List<char>();
                foreach (var word in words)
                {
                    characters.AddRange(word);
                }

                Dictionary<char, int> charCount = new Dictionary<char, int>();
                foreach (var character in characters)
                {
                    if (charCount.ContainsKey(character))
                    {
                        charCount[character] += 1;
                    }
                    else
                    {
                        charCount.Add(character, 1);
                    }
                }

                var sortedCharCount = from element in charCount orderby element.Value descending select element;

                Dictionary<char, int> topTwo = new Dictionary<char, int>();
                topTwo.Add(sortedCharCount.ElementAt(0).Key, sortedCharCount.ElementAt(0).Value);
                topTwo.Add(sortedCharCount.ElementAt(1).Key, sortedCharCount.ElementAt(1).Value);

                return topTwo;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"\nFile not found!\n\nError message:\n{e}");
                return errorDict;
            }
            catch(Exception e)
            {
                Console.WriteLine($"\nError message:\n{e}");
                return errorDict;
            }
        }
    }
}
