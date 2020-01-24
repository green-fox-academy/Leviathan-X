using System;
using System.Collections.Generic;
using System.Text;

namespace _06__List_Introduction_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty list which will contain names (strings)
            List<string> names = new List<string>();

            // Print out the number of elements in the list
            Console.WriteLine(names.Count);

            //Add William to the list
            names.Add("William");

            //Print out whether the list is empty or not
            Console.WriteLine(names.Count.Equals(0));

            //Add John to the list
            names.Add("John");

            //Add Amanda to the list
            names.Add("Amanda");

            // Print out the number of elements in the list
            Console.WriteLine(names.Count);

            // Print out the 3rd element
            Console.WriteLine(names[2]);

            // Iterate through the list and print out each name
            Console.WriteLine();
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            // Remove the 2nd element
            names.RemoveAt(1);

            //Iterate through the list in a reversed order and print out each name
            Console.WriteLine();
            names.Reverse();
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            // Remove all elements
            names.Clear();


        }
    }
}
