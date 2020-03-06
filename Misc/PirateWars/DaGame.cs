using System;
using System.Collections.Generic;
using System.Text;

namespace PirateWars
{
    static class DaGame
    {
        public static void Run()
        {
            string userName, userShip;
            Console.Write("\n\nCrew Hand: What shall we call ye, cap'n?\nYou: ");
            userName = Console.ReadLine();

            Console.Write($"Crew Hand: Aye, welcome aboard, captain {userName}! What shall we call yer ship?\nYou: ");
            userShip = Console.ReadLine();
            Console.WriteLine($"\n -- {userShip} sets sail! --");


            Parrot parrot = new Parrot();
        }
    }
}
