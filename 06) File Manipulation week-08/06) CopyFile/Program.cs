using System;
using System.IO;

namespace _06__CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            string text1 = @"HolyScripture.txt";
            string text2 = @"Script.txt";

            ReadAndWrite(text1, text2);

        }
        static bool ReadAndWrite (string input1, string input2)
        {
            bool progress;
            string text = "";
            try
            {
                using StreamReader readThis = new StreamReader(input1);
                string str = "";
                Console.WriteLine("\nFirst text \n");

                while (str != null)
                {
                    str = readThis.ReadLine();
                    if (str != null)
                    {
                        Console.WriteLine(str);
                        text += str;
                    }
                }
                readThis.Close();
                try
                {
                    using (StreamWriter writeThis = new StreamWriter(input2))
                    {
                        writeThis.WriteLine(text);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine($"\nError! Unable to write file: {input2}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"\nError! Unable to write file: {input1}");
                return progress = false;
            }
            return progress = true;
        }
    }
}
