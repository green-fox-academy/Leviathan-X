using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates
{
    class DaGame
    {
        public static void Run()
        {
            Console.WriteLine("\n---- Arrrr welcome, ye landlubbers, to the Pirate Wars! ----");

            Random randomValue = new Random();

            string userName, userShip;
            Console.Write("\n\nCrew Hand: What shall we call ye, cap'n?\nYou: ");
            userName = Console.ReadLine();

            Console.Write($"Crew Hand: Aye, welcome aboard, captain {userName}! What shall we call yer ship?\nYou: ");
            userShip = Console.ReadLine();
            Console.WriteLine($"\n -- {userShip} sets sail! --");

            PlayerShip playerShip = new PlayerShip(userShip, true);
            Pirate player = new Pirate(userName, playerShip, true);

            playerShip.BeginGame(player, playerShip);

            int handOfFate = randomValue.Next(1, 11);

            string consent = "Arrrr!";

            do
            {
                playerShip.GetStatus();




            }
            while (consent == "Arrrr!");

        }
    }
}
