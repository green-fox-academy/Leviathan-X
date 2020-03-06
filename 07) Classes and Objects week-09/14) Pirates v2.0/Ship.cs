using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates
{
    class Ship
    {
        protected string shipName;

        public Ship(string ShipName)
        {
            shipName = ShipName;
        }

        public void FillShip(Pirate captain, Ship thisShip)
        {
            List<Pirate> theCrew = new List<Pirate>();

            theCrew.Add(captain);
        
            // How to auto-generate objects, sadly, without distinguishing between them (Don't know how to make distinguishable yet)
            
            Random randomValue = new Random();
            int numOfCrew = randomValue.Next(2, 11);

            for (int i = 0; i < numOfCrew; i++)
            {
                theCrew.Add(new Pirate("", thisShip, false));        // How do I move around writing the "thisShip" thing? How to say to target the current object?
            }
            
        }
    }
}
