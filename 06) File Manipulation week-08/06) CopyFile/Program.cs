using System;
using System.IO;
using System.Collections.Generic;

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

            Console.WriteLine(ReadAndWrite(text1, text2));
        }
        static bool ReadAndWrite (string input1, string input2)
        {
            try
            {
                using StreamReader readThis = new StreamReader(input1);
                string str = "";

                List<string> oldText = new List<string>();
                
                Console.WriteLine("\nFirst text \n");

                while (str != null)
                {
                    str = readThis.ReadLine();
                    if (str != null)
                    {
                        Console.WriteLine(str);
                        oldText.Add(str);

                        //try
                        //{
                        //    using (StreamWriter writeThis = new StreamWriter(input2))
                        //    {
                        //        writeThis.WriteLine(str);
                        //    }
                        //}
                        //catch (Exception)
                        //{
                        //    Console.WriteLine($"\nError! Unable to write file: {input2}");
                        //}
                        // This doesn't work because:   
                        // Each iteration it writes on the same first line, and rewrites the previous string,
                        // at the end of the iteration the only thing in the textfile2 is the last line of textfile1.
                        // That's why I had to create the List<> oldText.
                        //
                    }
                }
                readThis.Close();
                try
                    // The Try-Catch at this StreamWriter is pretty much redundant, 
                    // if it doesn't find the file, it just creates a new one.
                {
                    using (StreamWriter writeThis = new StreamWriter(input2))
                    {
                        foreach (var newText in oldText)
                        {
                            writeThis.WriteLine(newText);
                        }
                    writeThis.Close();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"\nError! Unable to write file: {input2}");
                    Console.Write("\nProcess finished: ");
                    return false;
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"\nError! Unable to write file: {input1}");
                Console.Write("\nProcess finished: ");
                return false;
            }
            Console.Write("\nProcess finished: ");
            return true;
        }
    }
}
