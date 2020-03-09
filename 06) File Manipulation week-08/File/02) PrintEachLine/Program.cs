using System;
using System.IO;

namespace _02__PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each line from the file.
            // If the program is unable to read the file (for example it does not exist),
            // then it should print the following error message: "Unable to read file: my-file.txt"

            string path = @"C:\Users\Leviathan\Desktop\C# Recap\03) File Manipulation\02) PrintEachLine\my-file.txt";
            try
            {
                string[] texto = File.ReadAllLines(path);

                foreach (var item in texto)
                {
                    Console.WriteLine(item);
                }
            }
            catch
            {
                Console.WriteLine("Fuck!");
            }
        }
    }
}
