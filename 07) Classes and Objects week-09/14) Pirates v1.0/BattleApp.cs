using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates_v1._0
{
    class BattleApp
    {
        private Ship attacker;
        private Ship defender;

        public BattleApp(Ship Attacker, Ship Defender)
        {
            attacker = Attacker;
            defender = Defender;
        }

        public void BeginBattle()
        {
            attacker.Battle(defender);
        }
    }
}
