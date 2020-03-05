using System;

namespace _08__DiceSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // You have a `DiceSet` class which has a list for 6 dice
            // You can roll all of them with roll()
            // Check the current rolled numbers with getCurrent()
            // You can reroll with reroll()
            // Your task is to roll the dice until all of the dice are 6

            Console.WriteLine("\nWelcome to the Dice Roll!\nYou've got 6 dice, roll 'em until all of them are six!");            //diceSet.DaGame();

            DaGame.Start();

        }
    }
}
