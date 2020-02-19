using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates
{
    class Captain : Pirate
    {
        public static int CapIntoxication { get; private set; } = 0;


        public Captain(string Name) : base(Name)
        {
            name = Name;
        }
        
        public override void DrinkSomeRum()
        {
            if (alive)
            {
                if (passOut == true)
                {
                    Console.WriteLine($"\n{name} is too drunk to lift the cup!");
                }
                else
                {
                    CapIntoxication++;
                    Console.WriteLine($"\n{name} says: \"GLO GLO GLO!\"");
                }
            }
            else
            {
                Console.WriteLine($"\n{name} lies dead. And dead men don't drink.");
            }
        }

        public override void HowsItGoingMate()
        {
            // How to Inherit methods?
            // Can you really override only fields, not variables inside methods? That's kinda stupid, innit?
            
            IntoxPlus = "Pirate Captain: \"Pour me anudder!\"";
            passOutLine = "Pirate Captain: \"Arghh, I'ma Pirate Captain. How d'ya d'ink its goin?\"\nThe captain passes out.";
            passOutStatus = "The captain is passed out.";
            deadStatus = "The captain's dead.";

            base.HowsItGoingMate();
        }

    }
}
