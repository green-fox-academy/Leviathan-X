using System;
using System.Collections.Generic;

namespace _02__Map_Introduction_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create an empty map where the keys are integers and the values are characters
            Dictionary<int, char> mydic = new Dictionary<int, char>();

            // Print out whether the map is empty or not
            Console.WriteLine($"\nIs the map empty: {mydic.Count.Equals(0)}");

            // Add the following key-value pairs to the map
            mydic.Add(97, 'a');
            mydic.Add(98, 'b');
            mydic.Add(99, 'c');
            mydic.Add(65, 'A');
            mydic.Add(66, 'B');
            mydic.Add(67, 'C');

            // Print all the keys
            Console.WriteLine("\nAll the keys of mydic: ");

            foreach (int key in mydic.Keys)
            {
                Console.WriteLine(key);
            }

            // Print all the values
            Console.WriteLine("\nAll the values of mydic: ");

            foreach (char value in mydic.Values)
            {
                Console.WriteLine(value);
            }

            // Add value D with the key 68
            mydic.Add(68, 'D');

            // Print how many key-value pairs are in the map
            Console.WriteLine($"\nHow many key-value pairs in mydic: { mydic.Count}");

            // Print the value that is associated with key 99
            char ch;
            mydic.TryGetValue(99, out ch);
            Console.WriteLine($"\nValue of key 99: {ch}");

            // Remove the key-value pair with key 97
            mydic.Remove(97);

            // Print whether there is an associated value with key 100 or not
            Console.WriteLine($"\nIs there a value with key of 100: {mydic.ContainsKey(100)}");

            // Remove all the key-value pairs
            mydic.Clear();
            Console.WriteLine($"\nIs the map empty: {mydic.Count.Equals(0)}");


        }
    }
}
