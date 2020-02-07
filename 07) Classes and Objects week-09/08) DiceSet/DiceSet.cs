using System;
using System.Collections.Generic;
using System.Text;

namespace _08__DiceSet
{
    class DiceSet
    {
        private Random randomValue = new Random();
        private int[] dice = new int[6];

        public int[] Roll()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = randomValue.Next(1, 7);
            }

            return dice;
        }

        public int[] GetCurrent()
        {
            return dice;
        }

        public int GetCurrent(int i)
        {
            return dice[i];
        }

        public void Reroll()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = randomValue.Next(1, 7);
            }
        }

        public void Reroll(int k)
        {
            dice[k] = randomValue.Next(1, 7);
        }


        

        public void DaGame()
        {
            int num = 0;
            string consent = "Let's roll!";
            do
            {
                Console.WriteLine($"\n** Roll number {num} **");

                // - I wanted to put this code in its own class but couldn't get around diceSet.GetCurrent()
                Console.WriteLine("\nStatus: ");
                Console.WriteLine($"\nDice 1: {GetCurrent(0)}");
                Console.WriteLine($"\nDice 2: {GetCurrent(1)}");
                Console.WriteLine($"\nDice 3: {GetCurrent(2)}");
                Console.WriteLine($"\nDice 4: {GetCurrent(3)}");
                Console.WriteLine($"\nDice 5: {GetCurrent(4)}");
                Console.WriteLine($"\nDice 6: {GetCurrent(5)}");

                Win();
                Console.Write("\nYour options:\nPress N - Roll 'em all!\nPress R - Roll a dice\nPress Q - Quit game\n\nYour choice: ");
                string userInput = Console.ReadLine();

                if (userInput == "n" || userInput == "N")
                {
                    Roll();
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
                            Reroll(0);
                            Console.WriteLine("-- Dice 1 has been rolled! --");
                            break;
                        case "2":
                            Reroll(1);
                            Console.WriteLine("-- Dice 2 has been rolled! --");
                            break;
                        case "3":
                            Reroll(2);
                            Console.WriteLine("-- Dice 3 has been rolled! --");
                            break;
                        case "4":
                            Reroll(3);
                            Console.WriteLine("-- Dice 4 has been rolled! --");
                            break;
                        case "5":
                            Reroll(4);
                            Console.WriteLine("-- Dice 5 has been rolled! --");
                            break;
                        case "6":
                            Reroll(5);
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

        public void Win()
        {
            int num = 0;
            foreach (var item in dice)
            {
                if (item == 6) num++;
            }
            if (num == 6)
            {
                Console.WriteLine("\n\n\t*****************************************************" +
                    "\n\t*****************************************************" +
                    "\n\t*****************************************************" +
                    "\n\t***********************WINNER!***********************" +
                    "\n\t*****************************************************" +
                    "\n\t*****************************************************" +
                    "\n\t*****************************************************\n");
            }
            num = 0;
        }
    }
}
