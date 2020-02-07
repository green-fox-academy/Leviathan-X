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


            DiceSet diceSet = new DiceSet();
            Console.WriteLine("\nWelcome to the Dice Roll!\nYou've got 6 dice, roll 'em until all of them are six!");

            int num = 0;
            string consent = "Let's roll!";
            do
            {
                Console.WriteLine($"\n** Roll number {num} **");

                // - I wanted to put this code in its own class but couldn't get around diceSet.GetCurrent()
                Console.WriteLine("\nStatus: ");
                Console.WriteLine($"\nDice 1: {diceSet.GetCurrent(0)}");
                Console.WriteLine($"\nDice 2: {diceSet.GetCurrent(1)}");
                Console.WriteLine($"\nDice 3: {diceSet.GetCurrent(2)}");
                Console.WriteLine($"\nDice 4: {diceSet.GetCurrent(3)}");
                Console.WriteLine($"\nDice 5: {diceSet.GetCurrent(4)}");
                Console.WriteLine($"\nDice 6: {diceSet.GetCurrent(5)}");

                diceSet.Win();
                Console.Write("\nYour options:\nPress N - Roll 'em all!\nPress R - Roll a dice\nPress Q - Quit game\n\nYour choice: ");
                string userInput = Console.ReadLine();

                if (userInput == "n" || userInput == "N")
                {
                    diceSet.Roll();
                    Console.WriteLine("\n\n-- Dices have been rolled! --");
                    num++;
                }
                else if (userInput == "r" || userInput == "R")
                {
                    Console.Write("\nWhich dice to roll?\n\nYour choice: ");
                    string userChoice = Console.ReadLine();
                    switch (userChoice)
                    {
                        case "1":
                            diceSet.Reroll(0);
                            Console.WriteLine("-- Dice 1 has been rolled! --");
                            break;
                        case "2":
                            diceSet.Reroll(1);
                            Console.WriteLine("-- Dice 2 has been rolled! --");
                            break;
                        case "3":
                            diceSet.Reroll(2);
                            Console.WriteLine("-- Dice 3 has been rolled! --");
                            break;
                        case "4":
                            diceSet.Reroll(3);
                            Console.WriteLine("-- Dice 4 has been rolled! --");
                            break;
                        case "5":
                            diceSet.Reroll(4);
                            Console.WriteLine("-- Dice 5 has been rolled! --");
                            break;
                        case "6":
                            diceSet.Reroll(5);
                            Console.WriteLine("-- Dice 6 has been rolled! --");
                            break;
                        default:
                            Console.WriteLine("Error! Wrong input!\nPlease choose between the N, R or Q buttons.");
                            break;
                    }
                    num++;
                }
                else if (userInput == "q" || userInput == "Q")
                {
                    Console.Write("\nExit game:\nAre you sure? (y/n): ");
                    consent = Console.ReadLine(); ;
                }
                else
                {
                    Console.WriteLine("\nWrong input!\nPlease choose between 1 and 3.");
                }

            } while (consent == "n" || consent == "N" || consent == "Let's roll!");

        }
    }
}
