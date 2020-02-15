using System;
using System.Collections.Generic;
using System.Text;

namespace _08__DiceSet
{
    class DaGame
    {
        public static int rerollsNum = 0;
        public static int highScore;

        public static void Start()
        {
            DiceSet dices = new DiceSet();
            string consent = "Let's roll!";
            do
            {
                Console.WriteLine($"\n** Roll number {rerollsNum} **\n\nHigh Score: {highScore}");

                // - I wanted to put this code in its own class but couldn't get around diceSet.GetCurrent()
                // - UPDATE: ISSUE SOLVED = Just instantiate in the new class + the method should be static
                
                dices.StatusShow();

                if(dices.CheckWin())
                {
                    Console.WriteLine("\n\nCongratulations! See if you can beat your own High Score!");
                    bool lockedLoop = true;
                    do
                    {
                        Console.Write($"\nPress N to continue: ");
                        var winnerInput = Console.ReadKey().Key;
                        if (winnerInput == ConsoleKey.N)
                        {
                            dices.Roll();
                            Console.WriteLine("\n\n-- Dices have been rolled! --");
                            lockedLoop = false;
                        }
                    } while (lockedLoop == true);
                    dices.StatusReset();
                    dices.StatusShow();
                }

                Console.Write("\nYour options:\nPress N - Roll 'em all!\nPress R - Roll a dice\nPress Q - Quit game\n\nYour choice: ");
                var userInput = Console.ReadKey().Key;

                if (userInput == ConsoleKey.N) //|| userInput == "N")
                {
                    dices.Roll();
                    Console.WriteLine("\n\n-- Dices have been rolled! --");
                    rerollsNum++;
                }
                else if (userInput == ConsoleKey.R) //|| userInput == "R")
                {
                    Console.Write("\nWhich dice to roll?\n\nYour choice: ");
                    // Mishi: "Instead of switch, use parse. Copypasting is never good."
                    //string userChoice = Console.ReadLine();
                    try
                    {
                        int userReroll = Int32.Parse(Console.ReadLine());
                        if (userReroll > 6 || userReroll < 0)
                        {
                            Console.WriteLine("Error! Wrong input!\nPlease choose between 1 and 6.");
                        }
                        else
                        {
                            dices.Reroll(userReroll - 1);
                            Console.WriteLine($"-- Dice {userReroll - 1} has been rolled! --");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error! Wrong input!\nPlease choose between 1 and 6.");
                    }
                    // My old code:
                    //switch (userChoice)
                    //{
                    //    case "1":
                    //        dices.Reroll(0);
                    //        Console.WriteLine("-- Dice 1 has been rolled! --");
                    //        break;
                    //    case "2":
                    //        dices.Reroll(1);
                    //        Console.WriteLine("-- Dice 2 has been rolled! --");
                    //        break;
                    //    case "3":
                    //        dices.Reroll(2);
                    //        Console.WriteLine("-- Dice 3 has been rolled! --");
                    //        break;
                    //    case "4":
                    //        dices.Reroll(3);
                    //        Console.WriteLine("-- Dice 4 has been rolled! --");
                    //        break;
                    //    case "5":
                    //        dices.Reroll(4);
                    //        Console.WriteLine("-- Dice 5 has been rolled! --");
                    //        break;
                    //    case "6":
                    //        dices.Reroll(5);
                    //        Console.WriteLine("-- Dice 6 has been rolled! --");
                    //        break;
                    //    default:
                    //        Console.WriteLine("Error! Wrong input!\nPlease choose between the N, R or Q buttons.");
                    //        break;
                    //}
                    rerollsNum++;
                }
                else if (userInput == ConsoleKey.Q) //|| userInput == "Q")
                {
                    Console.Write("\n\nExit game:\nAre you sure? (y/n): ");
                    consent = Console.ReadLine(); 
                }
                else
                {
                    Console.WriteLine("\nError! Wrong input!\nPlease choose between the N, R or Q buttons.");
                }
            } while (consent == "n" || consent == "N" || consent == "Let's roll!");
        }

    }
}