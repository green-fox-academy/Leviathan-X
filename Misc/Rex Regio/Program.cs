using System;

namespace Rex_Regio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game Intro
            Console.WriteLine();
            GameIntro.Begin();

            // New Game Instances Loop
            bool consent;
            do
            {
                // The Game
                GameSource.PlayerNameInput();
                GameSource.ChampChoiceInput();
                
                // Aftermath
                Console.WriteLine($"\n\nWould you like to play again, {GameSource.GetPlayerName()}? " +
                    $"\n(Press Enter for a new game)");
                var userInput = Console.ReadKey(true).Key;
                if (userInput == ConsoleKey.Enter) consent = true;
                else consent = false;
                Console.WriteLine(Environment.NewLine);
            }
            while (consent == true);
            Console.WriteLine($"\n\n\nSafe travels, {GameSource.GetPlayerName()}.\n\nCreated by: -= Igor Immanuel Orlov =-");
            Console.ReadKey(true);
        }
    }
}
