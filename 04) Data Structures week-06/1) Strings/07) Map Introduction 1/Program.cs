using System;
using System.Collections.Generic;
using System.Text;

namespace _07__Map_Introduction_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create an empty map where the keys are integers and the values are characters
            Dictionary<int, char> map = new Dictionary<int, char>();

            // Print out whether the map is empty or not
            Console.WriteLine(map.Count.Equals(0));

            // Add the following key-value pairs to the map
            map.Add(97, 'a');
            map.Add(98, 'b');
            map.Add(99, 'c');
            map.Add(65, 'A');
            map.Add(66, 'B');
            map.Add(67, 'C');

            // Print all the keys
            Console.WriteLine();
            foreach (KeyValuePair<int, char> pair in map)
            {
                Console.WriteLine(pair.Key);
            }

            // Print all the values
            Console.WriteLine();
            foreach (KeyValuePair<int, char> pair in map)
            {
                Console.WriteLine(pair.Value);
            }

            // Add value D with the key 68
            map.Add(68, 'D');

            // Print how many key-value pairs are in the map
            Console.WriteLine("\n(One more pair added)\nKey-Value pairs: " + map.Count);

            // Print the value that is associated with key 99
            char ch;
            map.TryGetValue(99, out ch);
            Console.WriteLine("\n" + ch);

            // Remove the key-value pair where with key 97
            map.Remove(97);

            // Print whether there is an associated value with key 100 or not
            Console.WriteLine("\n" + map.ContainsKey(100));

            // Remove all the key-value pairs
            map.Clear();
            
        }
    }
}
