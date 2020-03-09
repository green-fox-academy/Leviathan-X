using System;
using System.IO;

namespace _05__WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes 3 parameters: a path, a word and a number
            // and is able to write into a file.
            // The path parameter should be a string that describes the location of the file you wish to modify
            // The word parameter should also be a string that will be written to the file as individual lines
            // The number parameter should describe how many lines the file should have.
            // If the word is 'apple' and the number is 5, it should write 5 lines
            // into the file and each line should read 'apple'
            // The function should not raise any errors if it could not write the file.
            
            string path = @"D:\greenfox\Leviathan-X\06) File Manipulation week-08\05) WriteMultipleLines\TheFileOfAllTheFiles.txt";
            string word = "Tequila!";
            int num = word.Length;
            Console.WriteLine($"\nInput length is: {word.Length}.");

            Spammer(path, word, num);
            Console.WriteLine();
        }
        static void Spammer(string path, string word, int num)
        {
            try
            {
                using (StreamWriter writeThis = new StreamWriter(path))
                {
                    for (int i = 0; i < num; i++)
                    {
                        writeThis.WriteLine($"{i+ 1}. {word}");
                    }
                    Console.WriteLine($"\nInput \"{word}\" successfully written in file:\n{path}");
                    writeThis.Close();
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"\nError! Unable to find file: {path}");
            }
        }
    }
}
