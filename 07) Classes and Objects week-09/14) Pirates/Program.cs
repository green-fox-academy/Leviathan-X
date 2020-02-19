using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates
{
    class Program
    {
        static void Main(string[] args)
        {

            Ship maryAnn = new Ship("Mary Ann");

            Captain crewCap = new Captain("Cap'n");
            maryAnn.FillShip(crewCap);
            Pirate crewHand1 = new Pirate("Bob");
            maryAnn.FillShip(crewHand1);
            Pirate crewHand2 = new Pirate("Slime");
            maryAnn.FillShip(crewHand2);
            Pirate crewHand3 = new Pirate("Fartbubble");
            maryAnn.FillShip(crewHand3);
            Pirate crewHand4 = new Pirate("Sunshine");
            maryAnn.FillShip(crewHand4);

            crewCap.HowsItGoingMate();
            crewHand1.DrinkSomeRum();
            crewHand2.DrinkSomeRum();
            crewHand3.DrinkSomeRum();

            for (int i = 0; i < 5; i++)
            {
                crewHand4.DrinkSomeRum();
            }
            crewHand4.HowsItGoingMate();

            crewHand1.Brawl(crewHand2);

            maryAnn.GetStatus();


            Ship bombardia = new Ship("Bombardia");

            Captain crewCap0 = new Captain("Kommandant");
            bombardia.FillShip(crewCap0);
            Pirate crewHand01 = new Pirate("Eins");
            bombardia.FillShip(crewHand01);
            Pirate crewHand02 = new Pirate("Zwei");
            bombardia.FillShip(crewHand02);
            Pirate crewHand03 = new Pirate("Drei");
            bombardia.FillShip(crewHand03);
            Pirate crewHand04 = new Pirate("Vier");
            bombardia.FillShip(crewHand04);

            for (int i = 0; i < 4; i++)
            {
                crewCap0.DrinkSomeRum();
            }
            crewCap0.HowsItGoingMate();

            bombardia.GetStatus();

        }
    }
}
