using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates_v1._0
{
    class Armada
    {
        private List<Ship> warShips;
        private int size;
        private string warName;

        public Armada(string WarName, int Size)
        {
            warShips = new List<Ship>();
            size = Size;
            warName = WarName;

            int j = 1;
            for (int i = 1; i <= size; i++)
            {
                warShips.Add(new Ship(i.ToString(), new Pirate(j.ToString(), true)));
                j++;
            }
        }

        public bool War(Armada enemyArmada)
        {
            
            int ourParty = 0;
            int theirParty = 0;

            while (warShips.Count - 1 != ourParty && enemyArmada.warShips.Count - 1 != theirParty)
            {
                if (warShips[ourParty].Battle(enemyArmada.warShips[theirParty]))
                {
                    Console.WriteLine($"\nThe {warName} Armada ship destroys the {enemyArmada.warName} ship!");
                    theirParty++;
                }
                else
                {
                    Console.WriteLine($"\nThe {enemyArmada.warName} Armada ship destroys the {warName} ship!");
                    ourParty++;
                }
            }

            if(warShips.Count - 1 == ourParty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
