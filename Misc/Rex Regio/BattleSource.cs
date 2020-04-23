using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    class BattleSource
    {
        private int ChampChoice;
        private Champion playerMagnus = new Magnus();
        private Champion playerLegibus = new Legibus();
        private Champion playerMysterio = new Mysterio();
        private string champName;
        private Dragon TheDragon = new Dragon();

        private int[] PlayerStats;
        private int[] DragonStats;

        private int TurnNumber;
        private bool PlayerTurn;

        public BattleSource(int ChampChoiceInput)
        {
            ChampChoice = ChampChoiceInput;
            champName = ChampMenu.GetChampName();
            
            Start();
        }

        // The Game Battle Source ---------------------------------------------
        public void Start()
        {
            Log.ResetAllText();
            Log.Ini();
            ThePlayer().Init();
            ThePlayer().ApplyBuffs();
            TheDragon.Init();
            TheDragon.ApplyBuffs();
            Console.CursorVisible = false;

            // -------- The Battle
            bool gameOver = false;
            do
            {
                // ---- Player Turn
                TurnNumber = 3;
                do
                {
                    PlayerTurn = true;
                    DisplayInterface();
                    Console.WriteLine("\n" +
                        "\n--------------" +
                        "\n-= Manual" +
                        "\n'Enter' to attack (1 turn)" +
                        "\n'P' to drink potion (1 turn)" +
                        "\n'Tab' to switch weapons (1 turn)" +
                        "\n'Space' to change location (2 turns)" +
                        "\n'R' to rest (All turns left)" +
                        "\n'L' to see the entire Log (0 turns)");
                    var userInput = Console.ReadKey(true).Key;
                    if (userInput == ConsoleKey.Enter) 
                    {
                        // If both are in the same location
                        if (PlayerStats[6] == DragonStats[10])
                        {
                            // If player has enough stamina
                            if(ThePlayer().StaminaPenaltyCalc())
                            {
                                // Procede with the attack
                                TheDragon.ReactAttack(PlayerStats[8]);
                                ThePlayer().PlayAttack(DragonStats[7]);
                                TurnNumber--;
                            }
                            else
                            {
                                Log.PlayerNoStamina();
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n--Can't attack! Must be in the same location!");
                        }
                    }
                    else if (userInput == ConsoleKey.P)
                    {
                        ThePlayer().DrinkPotion();
                        TurnNumber--;
                    }
                    else if (userInput == ConsoleKey.Tab)
                    {
                        ThePlayer().SwitchWeapon();
                        ThePlayer().ApplyBuffs();
                        TurnNumber--;
                    }
                    else if (userInput == ConsoleKey.Spacebar)
                    {
                        if (TurnNumber < 2) Console.WriteLine("\n--Not enough turns to switch location!");
                        else
                        {
                            ThePlayer().SwitchLocation();
                            ThePlayer().ApplyBuffs();
                            TurnNumber--;
                            TurnNumber--;
                        }
                    }
                    else if (userInput == ConsoleKey.R)
                    {
                        ThePlayer().Rest(TurnNumber);
                        TurnNumber = 0;
                    }
                    else if (userInput == ConsoleKey.L)
                    {
                        Log.LoadBig();
                    }
                    else if (userInput == ConsoleKey.Escape) gameOver = true;

                    if (TheDragon.CheckIfAlive() == false) break;
                } while (TurnNumber > 0);
                if (TheDragon.CheckIfAlive() == false) break;

                // ---- Dragon Turn
                TurnNumber = 3;
                do
                {
                    PlayerTurn = false;
                    DisplayInterface();
                    System.Threading.Thread.Sleep(2500);

                    // -- Dragon "AI"

                    // - If both are at Rocks
                    //if (DragonStats[10] == 1 && PlayerStats[6] == 1)
                    //{
                    //    if (DragonStats[9] != 2) 
                    //    {
                    //        TheDragon.SwitchStance(2);
                    //        TheDragon.ApplyBuffs();
                    //        TurnNumber--;
                    //    }
                    //}

                    // Default Behavior
                    if (TheDragon.StaminaPenaltyCalc())
                    {
                        ThePlayer().ReactAttack(DragonStats[6]);
                        TheDragon.PlayAttack(PlayerStats[9]);
                    }
                    else TheDragon.Rest(TurnNumber);

                    if (ThePlayer().CheckIfAlive() == false) break;
                    TurnNumber--;
                } while (TurnNumber > 0);
                if (ThePlayer().CheckIfAlive() == false) break;
            } while (gameOver == false);
            DisplayInterface();
            Console.WriteLine("\n\nGAME OVER!");
        }

        // Battle Turn Counter ---------------------------------------------
        public string ShowTurn()
        {
            if (PlayerTurn == true) return "You";
            else if (PlayerTurn == false) return "Dragon";
            else throw new Exception("\n\nError!\nShow Turn has invalid value!");
        }

        // The Interface ---------------------------------------------
        public void DisplayInterface()
        {
            XL.LongSpace();
            LoadInterfacePlayerStats();
            LoadInterfaceDragonStats();
            InterfaceUI();
        }

        public void InterfaceUI()
        {
            var output = new[]
            {
                $"\n---------------------------------------------------------------------------------------------------------------------\n",
                $"DRAGON                                           TURN                                           {champName.ToUpper()}\n" +
                $"                                                {ShowTurn()} ({TurnNumber}x)\n",
                $"Health: {DragonStats[5]}/{DragonStats[0]}   \t\t\t\t\t\t\t\t\t\tHealth: {PlayerStats[0]}/{PlayerStats[7]}\n",
                $"Attack: {DragonStats[6]}/{DragonStats[1]}\t\t\t\t\t\t\t\t\t\t\tAttack: {PlayerStats[8]}/{PlayerStats[1]}\n",
                $"Defence: {DragonStats[7]}/{DragonStats[2]}\t\t\t\t\t\t\t\t\t\t\tDefence: {PlayerStats[9]}/{PlayerStats[2]}\n",
                $"Stamina: {DragonStats[8]}/{DragonStats[3]}  \t\t\t\t\t\t\t\t\t\tStamina: {PlayerStats[10]}/{PlayerStats[3]}\n",
                $"Location: {ShowLocationDragon()}\t\t\t\t\t\t\t\t\t\t\tLocation: {ShowLocationPlayer()}\n",
                $"Stance: {ShowStance()}\t\t\t\t\t\t\t\t\t\t\tWeapon: {ShowWeapon()}\n" +
                $"Fury: {DragonStats[4]}%\t\t\t\t\t\t\t\t\t\t\tPotions: {PlayerStats[4]}\n",
                $"\n" +
                $"Log:\n",
            };

            foreach (var line in output)
            {
                Console.Write(line);
            }
            Log.LoadSmall();
        }

        public void LoadInterfacePlayerStats()
        {
            PlayerStats = ThePlayer().GetStatsInterface();
        }

        public void LoadInterfaceDragonStats()
        {
            DragonStats = TheDragon.GetStatsInterface();
        }

        // The Interface -- Player Stats
        public string ShowWeapon()
        {
            if (PlayerStats[5] == 1) return "Longsword";
            else if (PlayerStats[5] == 2) return "Battle-Axe";
            else if (PlayerStats[5] == 3) return "Spears";
            else throw new Exception("\n\n--Error!\nShow weapon in interface has invalid value!");
        }

        public string ShowLocationPlayer()
        {
            if (PlayerStats[6] == 1) return "Rocks";
            else if (PlayerStats[6] == 2) return "Huts";
            else if (PlayerStats[6] == 3) return "Trees";
            else throw new Exception("\n\n--Error!\nShow player location in interface has invalid value!");
        }

        // The Interface -- Dragon Stats
        public string ShowStance()
        {
            if (DragonStats[9] == 1) return "Claws";
            else if (DragonStats[9] == 2) return "Spear";
            else if (DragonStats[9] == 3) return "Fire";
            else throw new Exception("\n\n--Error!\nShow stance in interface has invalid value!");
        }

        public string ShowLocationDragon()
        {
            if (DragonStats[10] == 1) return "Rocks";
            else if (DragonStats[10] == 2) return "Huts";
            else if (DragonStats[10] == 3) return "Trees";
            else throw new Exception("\n\n--Error!\nShow dragon location in interface has invalid value!");
        }

        // The Player Champion Choice ---------------------------------------------
        public Champion ThePlayer()
        {
            if (ChampChoice == 1) return playerMagnus;
            else if (ChampChoice == 2) return playerLegibus;
            else if (ChampChoice == 3) return playerMysterio;
            else throw new Exception("\n\n-- Error!\nChampion choice output is invalid!");
        }
    }
}
