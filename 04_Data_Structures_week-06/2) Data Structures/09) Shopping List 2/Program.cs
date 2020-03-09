using System;
using System.Collections.Generic;

namespace _09__Shopping_List_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Represent the following products with their prices
            // Represent Bob's shopping list
            // Represent Alice's shopping list

            // Create an application which solves the following problems:

            Dictionary<string, double> database = new Dictionary<string, double>();
            database.Add("Milk", 1.07);
            database.Add("Rice", 1.59);
            database.Add("Eggs", 3.14);
            database.Add("Cheese", 12.60);
            database.Add("Chicken Breasts", 9.40);
            database.Add("Apples", 2.31);
            database.Add("Tomato", 2.58);
            database.Add("Potato", 1.75);
            database.Add("Onion", 1.10);

            Dictionary<string, double> bob = new Dictionary<string, double>();
            bob.Add("Milk", 3);                 // 3.21
            bob.Add("Rice", 2);                 // 3.18
            bob.Add("Eggs", 2);                 // 6.28
            bob.Add("Cheese", 1);               // 12.60
            bob.Add("Chicken Breasts", 4);      // 37.6
            bob.Add("Apples", 1);               // 2.31
            bob.Add("Tomato", 2);               // 5.16
            bob.Add("Potato", 1);               // 1.75

            Dictionary<string, double> alice = new Dictionary<string, double>();
            alice.Add("Rice", 1);               // 1.59
            alice.Add("Eggs", 5);               // 15.7
            alice.Add("Chicken Breasts", 2);    // 18.8
            alice.Add("Apples", 1);             // 2.31
            alice.Add("Tomato", 10);            // 25.8

            // How much does Bob pay?
            Console.WriteLine($"\nBob has to pay in total: {HowMuch(database, bob)}");
            HowMuch(database, alice);

            // How much does Alice pay?
            Console.WriteLine($"\nAlice has to pay in total: {HowMuch(database, alice)}");

            // Who buys more Rice?
            WhoMoreRice(bob, alice);

            // Who buys more Potatoes?
            WhoMorePotato(bob, alice);

            // Who buys more different products?
            if (bob.Count == alice.Count)
            {
                Console.WriteLine($"\nBob and Alice buy the same amount of different products, {bob.Count} = {alice.Count}.");
            } 
            else if (bob.Count > alice.Count)
            {
                Console.WriteLine($"\nBob buys more different products than Alice, {bob.Count} > {alice.Count}.");
            }
            else if (bob.Count < alice.Count)
            {
                Console.WriteLine($"\nAlice buys more different products than Bob, {alice.Count} > {bob.Count}.");
            }

            // Who buys more products? (piece)
            WhoMorePieces(bob, alice);

        }
        static double HowMuch (Dictionary<string, double> database, Dictionary<string, double> input)
        {
            double total = 0;
            foreach (KeyValuePair<string, double> itemData in database)
            {
                foreach (KeyValuePair<string, double> itemShop in input)
                {
                    if (itemData.Key == itemShop.Key)
                    {
                        total += itemData.Value * itemShop.Value;
                    }
                }
            }
            return total;
        }
        static void WhoMoreRice (Dictionary<string, double> input1, Dictionary<string, double> input2)
        {
            if (input1.ContainsKey("Rice") && input2.ContainsKey("Rice"))
            {
                foreach (KeyValuePair<string, double> item1 in input1)
                {
                    foreach (KeyValuePair<string, double> item2 in input2)
                    {
                        if (item1.Key == "Rice" && item2.Key == "Rice")
                        {
                            if (item1.Value > item2.Value)
                            {
                                Console.WriteLine($"\nBob buys more rice than Alice, {item1.Value} > {item2.Value}.");
                            }
                            else if (item1.Value < item2.Value)
                            {
                                Console.WriteLine($"\nAlice buys more rice than Bob, {item2.Value} > {item1.Value}.");
                            }
                            else if (item1.Value > item2.Value)
                            {
                                Console.WriteLine($"\nBob and Alice buy the same amount of rice, {item1.Value} = {item2.Value}.");
                            }
                            else { Console.WriteLine("\nError!"); };
                        }
                    }
                }
            }
            else if (input1.ContainsKey("Rice") && !input2.ContainsKey("Rice"))
            {
                Console.WriteLine("\nBob buys rice, Alice doesn't.");
            }
            else if (!input1.ContainsKey("Rice") && input2.ContainsKey("Rice"))
            {
                Console.WriteLine("\nAlice buys rice, Bob doesn't.");
            }
            else {Console.WriteLine("\nError!"); };
        }
        static void WhoMorePotato(Dictionary<string, double> input1, Dictionary<string, double> input2)
        {
            if (input1.ContainsKey("Potato") && input2.ContainsKey("Potato"))
            {
                foreach (KeyValuePair<string, double> item1 in input1)
                {
                    foreach (KeyValuePair<string, double> item2 in input2)
                    {
                        if (item1.Key == "Potato" && item2.Key == "Potato")
                        {
                            if (item1.Value > item2.Value)
                            {
                                Console.WriteLine($"\nBob buys more potatoes than Alice, {item1.Value} > {item2.Value}.");
                            }
                            else if (item1.Value < item2.Value)
                            {
                                Console.WriteLine($"\nAlice buys more potatoes than Bob, {item2.Value} > {item1.Value}.");
                            }
                            else if (item1.Value > item2.Value)
                            {
                                Console.WriteLine($"\nBob and Alice buy the same amount of potatoes, {item1.Value} = {item2.Value}.");
                            }
                            else { Console.WriteLine("\nError!"); };
                        }
                    }
                }
            }
            else if (input1.ContainsKey("Potato") && !input2.ContainsKey("Potato"))
            {
                Console.WriteLine("\nBob buys potatoes, Alice doesn't.");
            }
            else if (!input1.ContainsKey("Rice") && input2.ContainsKey("Rice"))
            {
                Console.WriteLine("\nAlice buys potatoes, Bob doesn't.");
            }
            else { Console.WriteLine("\nError!"); };
        }
        static void WhoMorePieces(Dictionary<string, double> input1, Dictionary<string, double> input2)
        {
            Dictionary<string, double>.ValueCollection values1 = input1.Values;
            Dictionary<string, double>.ValueCollection values2 = input2.Values;

            List<double> list1 = new List<double>();
            foreach (double item in values1)
            {
                list1.Add(item);
            }
            List<double> list2 = new List<double>();
            foreach (double item in values2)
            {
                list2.Add(item);
            }

            list1.Sort();
            list2.Sort();

            if ((list1[list1.Count - 1]) > (list2[list2.Count - 1]))
            {
                Console.WriteLine($"\nBob buys more pieces of a product than Alice, {list1[list1.Count - 1]} > {list2[list2.Count - 1]}.");
            }
            else if ((list1[list1.Count - 1]) < (list2[list2.Count - 1]))
            {
                Console.WriteLine($"\nAlice buys more pieces of a product than Bob, {list2[list2.Count - 1]} > {list1[list1.Count - 1]}.");
            }
            else if ((list1[list1.Count - 1]) == (list2[list2.Count - 1]))
            {
                Console.WriteLine($"\nBob and Alice both buy the same amount of pieces of a product, {list1[list1.Count - 1]} = {list2[list2.Count - 1]}.");
            } 
            else
            {
                Console.WriteLine("\nError!");
            }

        }
    }
}

