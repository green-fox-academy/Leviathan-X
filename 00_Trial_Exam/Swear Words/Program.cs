using System;
using System.Collections.Generic;
using System.IO;

namespace Swear_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\Leviathan\Desktop\C# Recap\00) Trial Exam\Swear Words\Text-File.txt";
            string path2 = @"C:\Users\Leviathan\Desktop\C# Recap\00) Trial Exam\Swear Words\Text-File2.txt";
            int nums = RemoveSwearWords(path1, path2);

            Console.WriteLine($"\nTarget: \t\t\t{path1}" +
                $"\nSuccessful censorship amount: \t{nums} words");
        }
        
        static int RemoveSwearWords(string OldFilePath1, string NewFilePath2)
        {
            int censorshipAmount = 0;
            string content = File.ReadAllText(OldFilePath1);
            var censore = new List<string>()
            {
                "bloody", "cock", "shit", "fucker","fuckstick", 
                "fuck", "asshole", "dick", "piss", "cunt"
            };

            for (int i = 0; i < censore.Count; i++)
            {
                if(content.ToLower().Contains(censore[i]))
                {
                    censorshipAmount++;
                }
                content = content.ToLower().Replace(" " + censore[i], string.Empty);
            }

            File.AppendAllText(NewFilePath2, content);

            return censorshipAmount;
        }
    }
}
