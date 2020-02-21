using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates_v1._0
{
    class WarApp
    {
        public Armada Attackers { get; private set; }
        public Armada Defenders { get; private set; }


        public WarApp(Armada attackers, Armada defenders)
        {
            Attackers = attackers;
            Defenders = defenders;

            Console.WriteLine("\n\n\n\n---- There's an Armada War a'brewin'! ----");
        }

        public void BeginWar()
        {
            Attackers.War(Defenders);
        }

    }
}
