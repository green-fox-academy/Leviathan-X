using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates_v1._0
{
    class Ship
    {
        private List<Pirate> crew;
        private string shipName;
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

        public bool Battle (Ship enemyShip)
        {
            Console.WriteLine($"\n\n-- The {shipName} ship sets its sight on the {enemyShip.shipName} ship! --");

            int ourCount = crew.Count;
            int enemyCount = enemyShip.crew.Count;

            int weAlive = 0;
            int theyAlive = 0;

            foreach (var ourPirate in crew)
            {
                if (ourPirate.alive) weAlive++;

            }
            foreach (var enemyPirate in enemyShip.crew)
            {
                if (enemyPirate.alive) theyAlive++;

            }

            int ourScore = (weAlive - captain.perMil);
            int enemyScore = (theyAlive - enemyShip.captain.perMil);

            if(ourScore > enemyScore)
            {
                Console.WriteLine($"The {shipName} ship leaves only a smoking wreck where the {enemyShip.shipName} ship used to be!\n--Battle Aftermath:");
                WinBattle();
                enemyShip.LoseBattle();
                return true;
            }
            else
            {
                Console.WriteLine($"The {shipName} ship gets ploughed for such an insolence by the {enemyShip.shipName} ship!\n--Battle Aftermath:");
                enemyShip.WinBattle();
                LoseBattle();
                return false;
            }
        }

        public void WinBattle()
        {
            int rumDrinks = randomValue.Next(1, 3);
            foreach (var pirate in crew)
            {
                for (int i = 0; i < rumDrinks; i++)
                {
                    pirate.DrinkSomeRum();
                }
            }
            Console.WriteLine($"The crew of {shipName} have themselves a little party! Each pirate gets {rumDrinks} per Mil!");
        }

        public void LoseBattle()
        {
            int casualties = randomValue.Next(1, crew.Count);
            int i = 0;
            foreach (var pirate in crew)
            {
                if (pirate.alive) pirate.Die();
                i++;
                if (i == casualties) break;
            }
            Console.WriteLine($"The crew of {shipName} suffer {casualties} casualties.");
        }


    }
}
