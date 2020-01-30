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

            Console.Write("\nNumber of lines in the file: ");
            Console.Write(NumOfLines("Extremely-Important-File.txt"));
            Console.WriteLine();
        }
        static int NumOfLines(string fileName)
        {
            int num = 0;
            try
            {
                using (StreamReader readThis = new StreamReader(fileName))
                {
                    string line = "";
                    while (line != null)
                    {
                        line = readThis.ReadLine();
                        if (line !=null) num++;
                    }
                    readThis.Close();
                    return num;
                }
            }
            catch (Exception)
            {
                Console.Write("Error! Could not find file. Output: ");
                return 0;
            }
        }
    }
}
