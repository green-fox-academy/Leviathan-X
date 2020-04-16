using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    class BattleSource
    {
        private int ChampChoice;

        public BattleSource(int ChampChoice)
        {
            this.ChampChoice = ChampChoice;
        }

        public void Start()
        {
            if (ChampChoice == 1) new Magnus();
            else if (ChampChoice == 2) new Legibus();
            else if (ChampChoice == 3) new Mysterio();
            else throw new Exception("\n\n--Error!\nChampion choice output is invalid!");
            
        }
    }
}
