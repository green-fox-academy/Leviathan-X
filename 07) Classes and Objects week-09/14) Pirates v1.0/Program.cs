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

            Pirate scotty = new Pirate("Scotty", true);
            Ship greenMermaid = new Ship("Green Mermaid", scotty);
            greenMermaid.FillShip();
            scotty.DrinkSomeRum();
            scotty.DrinkSomeRum();

            Pirate panzer = new Pirate("Panzer", true);
            Ship kommandant = new Ship("Kommandant", panzer);
            kommandant.FillShip();
            panzer.DrinkSomeRum();
            panzer.DrinkSomeRum();

            Pirate skull = new Pirate("Skull", true);
            Ship deathEater = new Ship("Death Eater", skull);
            deathEater.FillShip();
            skull.DrinkSomeRum();
            skull.DrinkSomeRum();

            greenMermaid.BrawlBreakOut();
            greenMermaid.ShipStatus();
            
            kommandant.BrawlBreakOut();
            kommandant.ShipStatus();
            
            deathEater.BrawlBreakOut();
            deathEater.ShipStatus();

            Console.WriteLine("\n\n----- Armada Wars a'brewin'! -----");
            Armada warParty1 = new Armada(2);



        }
    }
}
