using System;
using System.Collections.Generic;

namespace _03__List_Introduction_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list ('List A') which contains the following values
            // Apple, Avocado, Blueberries, Durian, Lychee
            List<string> list_A = new List<string>();

            list_A.Add("Apple");
            list_A.Add("Avocado");
            list_A.Add("Blueberries");
            list_A.Add("Durian");
            list_A.Add("Lychee");

            // Create a new list ('List B') with the values of List A
            List<string> list_B = new List<string>();

            foreach (string item in list_A)                 // list_B = list_A; creates lots of mischief!!
            {
                list_B.Add(item);
            }

            // Print out whether List A contains Durian or not
            Console.WriteLine($"\nDoes List A contain Durian: {list_A.Contains("Durian")}");

            // Remove Durian from List B
            list_B.Remove("Durian");

            // Add Kiwifruit to List A after the 4th element
            list_A.Insert(3, "Kiwifruit");

            // Compare the size of List A and List B
            Console.WriteLine($"\nSize of List A: {list_A.Count} \nSize of List B: {list_B.Count}");

            // Get the index of Avocado from List A
            Console.WriteLine($"\nIndex of Avocado from List A: {list_B.IndexOf("Avocado")}");

            // Get the index of Durian from List B
            Console.WriteLine($"\nIndex of Durian from List B: {list_B.IndexOf("Durian")}");

            // Add Passion Fruit and Pomelo to List B in a single statement
            list_B.Add("Passion Fruit");
            list_B.Add("Pomelo");                   // DUNNO MAN

            // Print out the 3rd element from List A
            Console.WriteLine($"\n3rd element from List A: {list_A[2]}");


        }
    }
}
