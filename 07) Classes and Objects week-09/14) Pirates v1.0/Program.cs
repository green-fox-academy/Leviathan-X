using System;

namespace _14__Pirates_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---- Arr! Welcome ta de Pirate Wars! ----");

            Pirate billy = new Pirate("Billy", true);

            Ship anneMarie = new Ship("Anne Marie", billy);
            anneMarie.FillShip();

            billy.DrinkSomeRum();
            billy.DrinkSomeRum();

            anneMarie.BrawlBreakOut();

            anneMarie.ShipStatus();

        }
    }
}
