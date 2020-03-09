using System;
using System.Collections.Generic;

namespace _06__Telephone_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            // We are going to represent our contacts in a map where the keys are going to be strings and the values are going to be strings as well.

            // Create a map with the following key-value pairs
            // Create an application which solves the following problems:


            Dictionary<string, string> contacts = new Dictionary<string, string>();
            contacts.Add("William A. Lathan", "405-709-1865");
            contacts.Add("John K. Miller", "402-247-8568");
            contacts.Add("Hortensia E. Foster", "606-481-6467");
            contacts.Add("Amanda D. Newland", "319-243-5613");
            contacts.Add("Brooke P. Aske", "307-687-2982");

            // What is John K. Miller's phone number?
            string str;
            contacts.TryGetValue("John K. Miller", out str);
            Console.WriteLine($"\nJohn K. Miller's phone: {str}");

            // Whose phone number is 307 - 687 - 2982 ?
            foreach (KeyValuePair<string, string> id in contacts)
            {
                if (id.Value == "307-687-2982") Console.WriteLine($"\nOwner of 307-687-2982 is: {id.Key}");
            }

            // Do we know Chris E. Myers' phone number?
            contacts.TryGetValue("Chris E. Myers", out str);
            Console.WriteLine($"\nDo we know Chris E. Myers' number?: {str != null}");

        }
    }
}
