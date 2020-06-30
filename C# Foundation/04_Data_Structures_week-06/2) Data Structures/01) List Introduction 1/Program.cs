using System;
using System.Collections.Generic;

namespace _01__List_Introduction_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty list which will contain names (strings)
            List<string> myList = new List<string>();

            // Print out the number of elements in the list
            Console.WriteLine($"\nNumber of elements in myList: {myList.Count}");

            // Add William to the list
            myList.Add("William");

            // Print out whether the list is empty or not
            Console.WriteLine($"\nIs myList empty: {myList.Count == 0}");   // OR {myList.Count.Equals(0)}

            // Add John to the list
            myList.Add("John");

            // Add Amanda to the list
            myList.Add("Amanda");

            // Print out the number of elements in the list
            Console.WriteLine($"\nNumber of elements in myList: {myList.Count}");

            // Print out the 3rd element
            Console.WriteLine($"\n3rd element of myList: {myList[2]}");

            // Iterate through the list and print out each name
            Console.WriteLine("\nThe entire myList: ");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            // Iterate through the list and print
            // 1.William
            // 2.John
            // 3.Amanda

            Console.WriteLine("\nThe entire myList counted: ");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {myList[i]}");
            }

            // Remove the 2nd element
            myList.RemoveAt(1);

            // Iterate through the list in a reversed order and print out each name
            Console.WriteLine("\nThe entire myList reversed: ");
            for (int i = myList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"{myList[i]}");              // OR myList.Reverse(); and then simple foreach
            }

            // Remove all elements
            myList.Clear();
            Console.WriteLine($"\nIs myList empty: {myList.Count.Equals(0)}");

        }
    }
}
