using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    class BattleSource
    {
        private int ChampChoice;
        private Champion playerMagnus = new Magnus();
        private Champion playerLegibus = new Legibus();
        private Champion playerMysterio = new Mysterio();

        public BattleSource(int ChampChoice)
        {
            this.ChampChoice = ChampChoice;
        }

        public void Start()
        {
            if (ChampChoice == 1) playerMagnus.Init();
            else if (ChampChoice == 2) playerLegibus.Init();
            else if (ChampChoice == 3) playerMysterio.Init();
            else throw new Exception("\n\n--Error!\nChampion choice output is invalid!");
            

        }
    }
}
