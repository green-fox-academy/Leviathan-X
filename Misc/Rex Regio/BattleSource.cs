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
            if (ChampChoice == 1) champName = "Magnus";
            else if (ChampChoice == 2) champName = "Legibus";
            else if (ChampChoice == 3) champName = "Mysterio";
            else throw new Exception("\n\n-- Error!\nChampion choice input is invalid!");

            Start();
        }

        // The Game Battle Source ---------------------------------------------
        public void Start()
        {
            ThePlayer().Init();
            TheDragon.Init();
            
            // The Battle
            bool gameOver = false;
            do
            {
                TurnNumber = 3;
                do
                {
                    PlayerTurn = true;
                    DisplayInterface();
                    Console.WriteLine("\n" +
                        "\n--------------" +
                        "\n-= Manual" +
                        "\n'Enter' to attack (1 move)" +
                        "\n'Tab' to switch weapon (1 move)" +
                        "\n'P' to drink potion (1 move)" +
                        "\n'S' to change location (2 moves)" +
                        "\n'R' to rest (all moves left)");
                    var userInput = Console.ReadKey(true).Key;
                    if (userInput == ConsoleKey.Enter) 
                    {
                        PlayerAttacks();
                        TurnNumber--;
                    }
                    else if (userInput == ConsoleKey.Escape) gameOver = true;

                    if (TheDragon.CheckIfAlive() == false) break;
                } while (TurnNumber > 0);
                if (TheDragon.CheckIfAlive() == false) break;

                TurnNumber = 3;
                do
                {
                    PlayerTurn = false;
                    DisplayInterface();
                    System.Threading.Thread.Sleep(2500);
                    DragonAttacks();

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
            else throw new Exception("\n\nError!\nShow Turn invalid value!");
        }

        // Bare Abilites ---------------------------------------------
        public void DragonAttacks()
        {
            ThePlayer().ReactAttack(TheDragon.PlayAttack());
        }

        public void PlayerAttacks()
        {
            TheDragon.ReactAttack(ThePlayer().PlayAttack());
        }

        // The Interface ---------------------------------------------
        public void DisplayInterface()
        {
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
                $"Health: {DragonStats[0]}\t\t\t\t\t\t\t\t\t\t\tHealth: {PlayerStats[0]}\n",
                $"Attack: {DragonStats[1]}\t\t\t\t\t\t\t\t\t\t\tAttack: {PlayerStats[1]}\n",
                $"Defense: {DragonStats[2]}\t\t\t\t\t\t\t\t\t\t\tDefense: {PlayerStats[2]}\n",
                $"Stamina: {DragonStats[3]}\t\t\t\t\t\t\t\t\t\t\tStamina: {PlayerStats[3]}\n",
                $"Location: huts_\t\t\t\t\t\t\t\t\t\t\tLocation: rocks\n",
                $"Stance: fire_\t\t\t\t\t\t\t\t\t\t\tWeapon: battle-axe\n" +
                $"Anger: {DragonStats[4]}\t\t\t\t\t\t\t\t\t\t\tPotions: {PlayerStats[4]}\n",
                $"\n" +
                $"Log:\n\n",
            };

            foreach (var line in output)
            {
                Console.Write(line);
            }
        }

        public void LoadInterfacePlayerStats()
        {
            PlayerStats = ThePlayer().GetStatsInterface();
        }

        public void LoadInterfaceDragonStats()
        {
            DragonStats = TheDragon.GetStatsInterface();
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
