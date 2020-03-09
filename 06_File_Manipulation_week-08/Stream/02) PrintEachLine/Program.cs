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

            string path = "my-file.txt";
            Console.WriteLine();
            try
            {
                using StreamReader readIt = new StreamReader(path);
                string str = "";
                while (str != null)
                {
                    str = readIt.ReadLine();
                    if (str != null)
                    {
                        Console.WriteLine(str);
                    }
                }
                readIt.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unable to read file: {path}");  // OR Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nEnd of program.");
            }
        }
    }
}
