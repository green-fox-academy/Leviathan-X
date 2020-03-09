using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates_v1._0
{
    class BattleApp
    {
        public Ship Attacker { get; private set; }
        public Ship Defender { get; private set; }

        public BattleApp(Ship attacker, Ship defender)
        {
            Attacker = attacker;
            Defender = defender;
        }

        public void BeginBattle()
        {
            Attacker.Battle(Defender);
        }

    }
}
