using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Rex_Regio
{
    static class Log
    {
        static string LogPath = @"LogText.txt";

        static Log()
        {
        }

        // Basic Log Methods ---------
        public static void ResetAllText()
        {
            try
            {
                File.Delete(LogPath);
            }
            catch
            {
                Console.WriteLine("\n--Error!\nLog text file not found!");
            }
        }

        public static void Ini()
        {
            try
            {
                File.AppendAllText(LogPath, "You get the first three turns. Use them well.");
            }
            catch
            {
                Console.WriteLine("\n--Error!\nLog text file not found!");
            }
        }

        public static void LoadSmall()
        {
            string[] input = File.ReadAllLines(LogPath);
            Array.Reverse(input);

            if(input.Length <= 6)
            {
                foreach (var line in input)
                {
                    Console.WriteLine(line);
                }
            }
            else if(input.Length > 6)
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(input[i]);
                }
            }
        }

        public static void LoadBig()
        {
            string[] input = File.ReadAllLines(LogPath);
            XL.LongSpace();

            int i = 0;
            foreach (var line in input)
            {
                i++;
                Console.WriteLine($"\n{i}.) {line}");
            }

            bool consent = true;
            do
            {
                Console.WriteLine("\n(Press 'L' to continue)");
                var userInput = Console.ReadKey(true).Key;
                if (userInput == ConsoleKey.L) consent = false;
            } while (consent == true);
        }

        // Dragon Announcements ---------
        public static void DragonAttack(int Stance, int Damage, int StaminaPenalty, int Fury, int PlayerDefence)
        {
            string StanceName;
            if (Stance == 1) StanceName = "Claws";
            else if (Stance == 2) StanceName = "Spear";
            else if (Stance == 3) StanceName = "Fire";
            else throw new Exception("\n\n--Error!\nStance in dragon attack has invalid value!");

            int TotalDamage = Damage + Fury - PlayerDefence;
            File.AppendAllText(LogPath, $"\nDragon attacks with {StanceName} (" +
                $"{Damage}dmg + {Fury}dmg of Fury), causing {TotalDamage}dmg total ({PlayerDefence} " +
                $"{ChampMenu.GetChampName()} defence), for {StaminaPenalty} Stamina.");
        }

        public static void DragonNewStance(int newStance)
        {
            if (newStance == 1) File.AppendAllText(LogPath, $"\nDragon unsheathes his Razor Claws!");
            else if (newStance == 2) File.AppendAllText(LogPath, $"\nDragon thrashes his head around with his " +
                $"Spear of Doom!");
            else if (newStance == 3) File.AppendAllText(LogPath, $"\nDragon draws hot air into his lungs! " +
                $"Prepare for the Lava Rain!");
            else throw new Exception("\n\n--Error!\nDragon stance switch has invalid value!");
        }

        public static void DragonNewLocation(int newLocation)
        {
            string newLocationName;
            if (newLocation == 1) newLocationName = "Rocks";
            else if (newLocation == 2) newLocationName = "Huts";
            else if (newLocation == 3) newLocationName = "Trees";
            else throw new Exception("\n\n--Error!\nDragon location switch has invalid value!");

            File.AppendAllText(LogPath, $"\nDragon switches location to the {newLocationName}.");
        }

        public static void DragonRest(int Turns, int RestHP, int RestStamina)
        {
            File.AppendAllText(LogPath, $"\nDragon rests for {Turns} turns, " +
                $"for each turn gains {RestHP}hp and {RestStamina} Stamina.");
        }

        // Player Announcements ---------
        public static void PlayerAttack(int Weapon, int Damage, int StaminaPenalty, int DragonDefence)
        {
            string WeaponName;
            if (Weapon == 1) WeaponName = "Longsword";
            else if (Weapon == 2) WeaponName = "Battle-Axe";
            else if (Weapon == 3) WeaponName = "Spears";
            else throw new Exception("\n\n--Error!\nPlayer attack weapon has invalid value!");

            int TotalDamage = Damage - DragonDefence;
            File.AppendAllText(LogPath, $"\n{ChampMenu.GetChampName()} attacks with " +
                $"{WeaponName} ({Damage}dmg), causing {TotalDamage}dmg total ({DragonDefence} Dragon Defence), " +
                $"for {StaminaPenalty} Stamina.");
        }

        public static void PlayerNewWeapon(int newWeapon)
        {
            string newWeaponName;
            if (newWeapon == 1) newWeaponName = "Longsword";
            else if (newWeapon == 2) newWeaponName = "Battle-Axe";
            else if (newWeapon == 3) newWeaponName = "Spears";
            else throw new Exception("\n\n--Error!\nShow weapon in interface has invalid value!");

            File.AppendAllText(LogPath, $"\n{ChampMenu.GetChampName()} switches weapons to {newWeaponName}.");
        }

        public static void PlayerNewLocation(int newLocation)
        {
            string newLocationName;
            if (newLocation == 1) newLocationName = "Rocks";
            else if (newLocation == 2) newLocationName = "Huts";
            else if (newLocation == 3) newLocationName = "Trees";
            else throw new Exception("\n\n--Error!\nPlayer location switch has invalid value!");

            File.AppendAllText(LogPath, $"\n{ChampMenu.GetChampName()} switches location to the " +
                $"{newLocationName}.");
        }

        public static void PlayerPotion(int PotionHealth)
        {
            File.AppendAllText(LogPath, $"\n{ChampMenu.GetChampName()} drinks a potion, " +
                $"gains {PotionHealth} health.");
        }

        public static void PlayerRest(int Turns, int RestHP, int RestStamina)
        {
            File.AppendAllText(LogPath, $"\n{ChampMenu.GetChampName()} rests for {Turns} turns, " +
                $"for each turn gains {RestHP}hp and {RestStamina} Stamina.");
        }

        public static void PlayerNoStamina()
        {
            File.AppendAllText(LogPath, $"\n{ChampMenu.GetChampName()} doesn't have enough energy " +
                $"to finish the attack!");
        }
    }
}
