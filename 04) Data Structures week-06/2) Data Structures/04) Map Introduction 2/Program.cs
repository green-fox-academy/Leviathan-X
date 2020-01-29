using System;
using System.Collections.Generic;

namespace _04__Map_Introduction_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a map where the keys are strings and the values are strings with the following initial values
            Dictionary<string, string> map = new Dictionary<string, string>();

            map.Add("978-1-60309-452-8", "A Letter to Jo");
            map.Add("978-1-60309-459-7", "Lupus");
            map.Add("978-1-60309-444-3", "Red Panda and Moon Bear");
            map.Add("978-1-60309-461-0", "The Lab");

            // Print all the key-value pairs in the following format
            //A Letter to Jo (ISBN: 978-1-60309-452-8)
            Console.WriteLine();
            foreach (KeyValuePair<string, string> pairs in map)
            {
                Console.WriteLine($"{pairs.Value} (ISBN: {pairs.Key})");
            }

            // Remove the key-value pair with key 978-1-60309-444-3
            map.Remove("978-1-60309-444-3");

            // Remove the key-value pair with value The Lab
            map.Remove("The Lab");

            // Add the following key-value pairs to the map
            map.Add("978-1-60309-450-4", "They Called Us Enemy");
            map.Add("978-1-60309-453-5", "Why Did We Trust Him?");

            // Print whether there is an associated value with key 478-0-61159-424-8 or not
            Console.WriteLine($"\nDoes map contain 478 - 0 - 61159 - 424 - 8: {map.ContainsKey("478 - 0 - 61159 - 424 - 8")}");

            // Print the value associated with key 978-1-60309-453-5

            Console.WriteLine($"\nValue with key 978-1-60309-453-5: {map["978-1-60309-453-5"]}");

        }
    }
}
