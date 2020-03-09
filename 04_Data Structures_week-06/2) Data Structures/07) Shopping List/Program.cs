using System;
using System.Collections.Generic;

namespace _07__Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // We are going to represent a shopping list in a list containing strings.

            // Create a list with the following items:
            // Eggs, milk, fish, apples, bread and chicken
            // Create an application which solves the following problems:
            // Do we have milk on the list?
            // Do we have bananas on the list?

            List<string> shoppingList = new List<string>();
            shoppingList.Add("eggs");
            shoppingList.Add("milk");
            shoppingList.Add("fish");
            shoppingList.Add("apples");
            shoppingList.Add("bread");
            shoppingList.Add("chicken");

            Console.WriteLine($"\nDo we have milk on the list: {shoppingList.Contains("milk")}");
            Console.WriteLine($"\nDo we have bananas on the list: {shoppingList.Contains("bananas")}");

        }
    }
}
