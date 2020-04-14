using System;

namespace Rex_Regio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game Intro
            Console.WriteLine();
            Intro.Begin();

            // New Game Instances Loop
            bool consent;
            do
            {
                // The Game
                GameSource.PlayerNameInput();
                GameSource.ChampChoiceInput();
                
                // Aftermath
                Console.Write($"\nWould you like to play a new game, {GameSource.GetPlayerName()}? " +
                    $"\nIf so, press Enter: ");
                var userInput = Console.ReadKey().Key;
                if (userInput == ConsoleKey.Enter) consent = true;
                else consent = false;
            }
            while (consent == true);
            Console.WriteLine($"\n\n\n_Safe travels, {GameSource.GetPlayerName()}.\n\nCreated by: -= Igor Immanuel Orlov =-");
            Console.ReadKey();
        }
    }
}
