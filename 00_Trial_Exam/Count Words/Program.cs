using System;
using System.Collections.Generic;
using System.IO;

namespace FileIO
{
    class Program
    {
        // Please write a function that takes two parameters:
        // the first parameter is a string that represents the name of a file
        // the function should read the file and count each of the words inside the file
        // the second parameter is a string that represents the name of a file
        // the function should write all the words and its count(separated with spaces) as new lines in the file 
        // You should handle the exceptions

        static void Main(string[] args)
        {
            string path1 = @"C:\Users\Leviathan\Desktop\C# Recap\00) Trial Exam\Count Words\TextFile1.txt";
            string path2 = @"C:\Users\Leviathan\Desktop\C# Recap\00) Trial Exam\Count Words\TextFile2.txt";

            WordCount(path1, path2);
        }

        static void WordCount(string OldPath, string newPath)
        {
            try
            {
                string input = File.ReadAllText(OldPath);
                string[] lines = input.Split(Environment.NewLine);
                List<string> words = new List<string>();

                foreach (var line in lines)
                {
                    words.AddRange(line.ToLower().Replace(",", "").Replace(".", "").Split(' '));
                }

                Dictionary<string, int> wordCount = new Dictionary<string, int>();
                
                foreach (var word in words)
                {
                    if (wordCount.ContainsKey(word))
                    {
                        wordCount[word] += 1;
                    }
                    else
                    {
                        wordCount.Add(word, 1);
                    }
                }

                string output = "";
                foreach (KeyValuePair<string, int> pair in wordCount)
                {
                    if (pair.Key != "")
                    {
                        output += $"{pair.Key} {pair.Value}\n";
                    }
                }
                File.WriteAllText(newPath, output);
                Console.WriteLine("\nDone!");
            }
            catch
            {
                Console.WriteLine("\nFuck!");
            }
        }  
    }
}
