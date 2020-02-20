using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates_v1._0
{
    class Ship
    {
        List<Pirate> crew;
        string shipName;
        private Pirate captain;

        Random randomValue = new Random();

        public Ship(string ShipName, Pirate Captain)
        {
            crew = new List<Pirate>();
            shipName = ShipName;
            captain = Captain;

        }

        public void FillShip()
        {
            Random randomValue = new Random();
            int numOfCrew = randomValue.Next(2, 11);

            for (int i = 0; i < numOfCrew; i++)
            {
                crew.Add(new Pirate ("", false));
            }
        }

        public void ShipStatus()
        {
            Console.WriteLine($"\n\n * * * *\nThe {shipName} Ship Status: \n\nCaptain's Consumed Rum: {captain.perMil} per Mil\nCrew Passed Out: {Pirate.passedOutTotal}/{crew.Count}" +
                $"\nCrew Casualties: {Pirate.deadTotal}/{crew.Count}");
        }

        public void BrawlBreakOut()
        {
            int fate = randomValue.Next(1, crew.Count);

            Pirate.Brawl(crew[fate], crew[fate]);
        }

    }
}
