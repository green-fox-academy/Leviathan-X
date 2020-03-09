using System;
using System.IO;

namespace _03__Count_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            string path = @"C:\Users\Leviathan\Desktop\C# Recap\03) File Manipulation\03) Count Lines\AyyLmao.txt";

            string[] textio = File.ReadAllLines(path);
            Console.WriteLine($"\nNum of lines in file: {textio.Length}");
        }
    }
}
