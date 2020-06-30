using System;
using System.Collections.Generic;

namespace _02__Map_Introduction_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create an empty map where the keys are integers and the values are characters
            Dictionary<int, char> myDic = new Dictionary<int, char>();

            // Print out whether the map is empty or not
            Console.WriteLine($"\nIs the map empty: {myDic.Count.Equals(0)}");

            // Add the following key-value pairs to the map
            myDic.Add(97, 'a');
            myDic.Add(98, 'b');
            myDic.Add(99, 'c');
            myDic.Add(65, 'A');
            myDic.Add(66, 'B');
            myDic.Add(67, 'C');

            // Print all the keys
            Console.WriteLine("\nAll the keys of myDic: ");

            foreach (int key in myDic.Keys)
            {
                Console.WriteLine(key);
            }

            // Print all the values
            Console.WriteLine("\nAll the values of myDic: ");

            foreach (char value in myDic.Values)
            {
                Console.WriteLine(value);
            }

            // Add value D with the key 68
            myDic.Add(68, 'D');

            // Print how many key-value pairs are in the map
            Console.WriteLine($"\nHow many key-value pairs in myDic: {myDic.Count}");

            // Print the value that is associated with key 99
            char ch;
            myDic.TryGetValue(99, out ch);
            Console.WriteLine($"\nValue of key 99: {ch}");

            // Remove the key-value pair with key 97
            myDic.Remove(97);

            // Print whether there is an associated value with key 100 or not
            Console.WriteLine($"\nIs there a value with key of 100: {myDic.ContainsKey(100)}");

            // Remove all the key-value pairs
            myDic.Clear();
            Console.WriteLine($"\nIs the map empty: {myDic.Count.Equals(0)}");


        }
    }
}
