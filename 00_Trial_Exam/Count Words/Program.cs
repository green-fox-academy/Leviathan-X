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
            string path1 = @"C:\Users\Leviathan\Desktop\ExampleExam\FileIO\TextFile1.txt";
            string path2 = @"C:\Users\Leviathan\Desktop\ExampleExam\FileIO\TextFile2.txt";

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
                    words.AddRange(line.Split(' '));
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

                string content = "";
                foreach (KeyValuePair<string, int> entry in wordCount)
                {
                    if (entry.Key != "")
                    {
                        content += $"{entry.Key} {entry.Value}\n";
                    }
                }
                File.WriteAllText(newPath, content);
                Console.WriteLine("\nDone!");
            }
            catch
            {
                Console.WriteLine("\nFuck!");
            }
        }  
    }
}
