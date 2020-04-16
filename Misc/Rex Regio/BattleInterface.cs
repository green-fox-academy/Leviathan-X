using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Rex_Regio
{
    static class BattleInterface
    {
        static BattleInterface()
        {

        }

        public static void Show()
        {
            var output = new[]
            {
                $"\n---------------------------------------------------------------------------------------------------------------------\n",
                $"DRAGON                                            TURN                                            name\n\n",
                $"Health: 0.000                                     You (3x)___                                     Health: 0.000\n",
                $"Attack: 00                                                                                        Attack: 00\n",
                $"Defense: 00                                                                                       Defense: 00\n",
                $"Stamina: 150                                                                                      Stamina: 000\n",
                $"Location: huts_                                                                                   Location: rocks\n",
                $"Stance: fire_                                                                                     Weapon: Battle-Axe\n" +
                $"Anger: 000                                                                                        Potions: 0\n",
                $"\n",
            };

            foreach (var line in output)
            {
                Console.Write(line);
            }
        }
    }
}
