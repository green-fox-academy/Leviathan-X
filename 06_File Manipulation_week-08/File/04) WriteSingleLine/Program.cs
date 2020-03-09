using System;
using System.IO;

namespace _04__WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message: "Unable to write file: my-file.txt"

            WriteALine("Da b0ss");
        }

        public static void WriteALine(string input)
        {
            string path = @"C:\Users\Leviathan\Desktop\C# Recap\03) File Manipulation\04) WriteSingleLine\tExTzz.txt";
            File.AppendAllText(path, $"{input}\n");
            Console.WriteLine($"\n\"{input}\" sucessfully written.");
        }
    }
}
