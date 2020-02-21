using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates_v1._0
{
    class Armada
    {
        List<Ship> attackShips;
        int size;

        public Armada(int Size)
        {
            attackShips = new List<Ship>();
            size = Size;
        }

        public void AddShip(Ship ship)
        {
            if (attackShips.Count < size)
            {
                attackShips.Add(ship);
            }
            else if (attackShips.Count >= size)
            {
                Console.WriteLine("\nCan't add more ships to this Armada! Change it's size!");
            }
        }

        public bool War(Armada enemyArmada)
        {
            



            return true;
        }

       


    }
}
