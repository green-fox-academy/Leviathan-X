using System;
using System.Collections.Generic;

namespace _08__Product_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------- Product Database I. ----------------


            // We are going to represent our products in a map where the keys are strings representing the product's name and the values are numbers representing the product's price.

            // Create a map with the following key - value pairs
            // Create an application which solves the following problems:

            Dictionary<string, int> database = new Dictionary<string, int>();
            database.Add("Eggs", 200);
            database.Add("Milk", 200);
            database.Add("Fish", 400);
            database.Add("Apples", 150);
            database.Add("Bread", 50);
            database.Add("Chicken", 550);

            Console.WriteLine("\nItems in the Product Database: \n");
            foreach (KeyValuePair<string, int> item in database)
            {
                Console.WriteLine($"Product: {item.Key} \nPrice: {item.Value}\n");
            }

            // How much is the fish ?
            int num;
            database.TryGetValue("Fish", out num);
            Console.WriteLine($"\nHow much is the fish: {num}");

            // What is the most expensive product?
            // What is the cheapest product?
            MostExpensiveAndCheapest(database);

            // What is the average price?
            CountAverage(database);

            // How many products' price are below 300?
            PriceBelow(database, 300);

            // Is there anything we can buy for exactly 125 ?
            Console.WriteLine($"\nCan we buy anything for exactly 125: {database.ContainsValue(125)}");


            // ---------------- Product Database II. ----------------


            // Which products cost less than 201? (just the name)
            PriceBelowName(database, 201);

            // Which products cost more than 150? (name + price)
            PriceAbove(database, 150);

        }
        static void MostExpensiveAndCheapest(Dictionary<string, int> input)
        {
            Dictionary<string, int>.ValueCollection shapeshift = input.Values;
            // OR System.Linq -- List<int> myList = input.Keys.ToList();

            List<int> prices = new List<int>();

            foreach (int price in shapeshift)
            {
                prices.Add(price);
            }

            prices.Sort();
            Console.WriteLine($"\nThe Most Expensive item is: {prices[prices.Count - 1]}");
            Console.WriteLine($"The Cheapest item is: {prices[0]}");
        }
        static void CountAverage(Dictionary<string, int> input)
        {
            Dictionary<string, int>.ValueCollection shapeshift = input.Values;

            int total = 0;
            int divide = input.Count;
            foreach (int num in shapeshift)
            {
                total += num;
            }
            Console.WriteLine($"\nThe average of all items is: {(float) total / divide}");
        }
        static void PriceBelow(Dictionary<string, int> input, int below)
        {
            Console.WriteLine("\nItems below 300: ");
            foreach (KeyValuePair<string, int> item in input)
            {
                if (item.Value < below) Console.WriteLine(item);
            }
        }
        static void PriceBelowName(Dictionary<string, int> input, int below)
        {
            Console.WriteLine("\nItems below 201, just names: ");
            foreach (KeyValuePair<string, int> item in input)
            {
                if (item.Value < below) Console.WriteLine(item.Key);
            }
        }
        static void PriceAbove(Dictionary<string, int> input, int above)
        {
            Console.WriteLine("\nItems above 150: ");
            foreach (KeyValuePair<string, int> item in input)
            {
                if (item.Value > above) Console.WriteLine(item);
            }
        }
    }
}
