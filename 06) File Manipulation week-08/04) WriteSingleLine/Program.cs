using System;
using System.IO;
using System.Text;

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

            string path = "my-file.txt";
            string input = "Igor";

            textWriter(path, input);
        }
        static void textWriter(string path, string input)
        {
            try
            {
                using (StreamWriter writeThis = new StreamWriter(path))
                {
                    writeThis.WriteLine(input);
                    Console.WriteLine($"\nInput \"{input}\" sucessfully written in: {path}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"\nUnable to write file: {path}");
            }
        }
    }
}
