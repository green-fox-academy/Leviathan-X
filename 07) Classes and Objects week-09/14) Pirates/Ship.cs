using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates
{
    class Ship
    {
        List<Pirate> pirateCrew;
        private string shipName;

        public Ship(string ShipName)
        {
            shipName = ShipName;
            pirateCrew = new List<Pirate>();
            Console.WriteLine($"\n\n---- {shipName} sets sail! ----");
        }

        public void FillShip(Pirate crewMember)
        {

            // DUNNO HOW: 
            // How to auto-generate objects and to distinguish between them

            // Random randomValue = new Random();
            // int numOfCrew = randomValue.Next(2, 11);

            // Captain crewCap = new Captain("Cap'n");
            // pirateCrew.Add(crewCap);

            // for (int i = 0; i < numOfCrew; i++)
            // {
            //     Pirate crewHand = new Pirate("Bob");
            //     pirateCrew.Add(crewHand);
            // }

            pirateCrew.Add(crewMember);
        }

        public void GetStatus()
        {
            Console.WriteLine($"\n * * * *\nStatus of the {shipName} ship:\n\nCaptain's Rum Consuption: {Captain.CapIntoxication} per mil\nTotal Crew Passed Out: {Pirate.passedOutTotal}" +
                $"\nNumber of Pirates Alive: {Pirate.AliveTotal}/{pirateCrew.Count} (Including captain)");
        }

        public void Battle(Ship enemyShip)
        {
            int ourScore = Pirate.AliveTotal - Captain.CapIntoxication;
            //int theirScore = 


        }
    }
}
