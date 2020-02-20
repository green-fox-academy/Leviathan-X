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

            Pirate matheas = new Pirate("Matheas", true);

            Ship bombarda = new Ship("Bombarda", matheas);
            bombarda.FillShip();

            matheas.DrinkSomeRum();
            matheas.DrinkSomeRum();

            bombarda.BrawlBreakOut();

            bombarda.ShipStatus();

            BattleApp battle1 = new BattleApp(anneMarie, bombarda);

            battle1.BeginBattle();

            
        }
    }
}
