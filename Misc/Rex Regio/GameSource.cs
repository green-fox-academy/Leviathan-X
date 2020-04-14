using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    static class GameSource
    {
        private static string PlayerName = "";

        static GameSource()
        {
        
        }

        public static string GetPlayerName()
        {
            return PlayerName;
        }

        // Player Introduction
        public static void PlayerIntro()
        {
            Console.Write("\n\nHooded figure: \"What is your name, stranger?\"\n\nYou: " +
                "\"Greetings. My name is ");
            PlayerName = Console.ReadLine();
            if (PlayerName.Trim() == "") PlayerName = "Player";
            Console.WriteLine("and I've come to your land to mentor a champion.\"");
            Console.Write("\nHooded figure: \"How wonderful! I've heard of your coming. " +
                $"You're just what we need, {PlayerName}.\nMy name is Oxphor, a humble councilman of our people.\"" +
                "\nOxphor: *bows graciously*\n\nOxphor: \"These are troubled times in the " +
                "kingdom of Regio, for a dragon has slayed the king! \nWith no heirs left, " +
                "the crown will belong to the man who shall slay the foul beast.\"" +
                $"\n\n{PlayerName}: \"So I've heard. I trust the word has spread far enough, " +
                "and worthy challengers have shown up.\"\n\nOxphor: \"The champions have assembled " +
                $"before you, wise one. They are ready to meet you, {PlayerName}.\nSo, are you ready?\"");

            bool wait = true;
            do
            {
                Console.WriteLine("\n\n(Press Enter) ");
                var consent = Console.ReadKey().Key;
                if (consent == ConsoleKey.Enter)
                {
                    Console.WriteLine($"\nOxphor: \"Verily! {PlayerName}, please meet the brave champions.\"");
                    wait = false;
                }
                else
                {
                    Console.WriteLine("\nOxphor: *intensely staring at you and waiting*");
                }
            } while (wait == true);
        }

        // The Champions Introduction
        public static void ChampIntro()
        {
            ChampIntroMenu.Input();
        }
    }
}
