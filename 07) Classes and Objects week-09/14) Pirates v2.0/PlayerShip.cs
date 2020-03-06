using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates
{
    class PlayerShip : Ship
    {
        List<Pirate> playerCrew;

        public PlayerShip(string ShipName, bool PlayerShip) : base(ShipName)
        {
            playerCrew = new List<Pirate>();
        }

        public void BeginGame(Pirate captain, PlayerShip thisShip)
        {
            playerCrew.Add(captain);

            for (int i = 0; i < 5; i++)
            {
                playerCrew.Add(new Pirate("", thisShip, false));
            }
        }

        public void GetStatus()
        {
            Console.WriteLine($"\n * * * *\nStatus of the {shipName} ship:\n\nCaptain's Rum Consuption: {Pirate.perMilCap} per mil\nTotal Crew Passed Out: {Pirate.passedOutTotal}" +
                $"\nNumber of Pirates Alive: {}(Including captain)");
        }
    }
}
