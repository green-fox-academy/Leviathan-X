using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Rex_Regio
{
    class DragonBattle
    {
        public DragonBattle(int ChampChoice)
        {
            FightPrep();
        }

        private void FightPrep()
        {   
            Console.WriteLine($"After lots of strenuous training, you and your champion " +
                $"{GameSource.GetChampName()} set out for the long road ahead..\n\nFew weeks later.." +
                "\n\nThe road was hard and treacherous, yet you finally made it to the mountains, " +
                "where the den of the dragon is rumored to be." +
                "\nYou stand right before the entrance to the top of the mountain.");

            bool wait = true;
            do
            {
                Console.Write("\nDo you dare to continue further?\n(Press Enter): ");
                var consent = Console.ReadKey().Key;
                if (consent == ConsoleKey.Enter)
                {
                    wait = false;
                }
                else
                {
                    Console.WriteLine("\n\nYou decide to take one more breather. You pour some more " +
                        "wine into your champion's cup.");
                }
            } while (wait == true);

            XL.ArrowBeforeSpace();
            Console.WriteLine(
                "\n\nOn the top of the mountain lies a valley. The valley contains: " +
                "\n1. Rocky mountain top" +
                "\n   Small stones and tough terrain everywhere. There is smoke and fire coming out of the cracks." +
                "\n2. Abandoned fishing village" +
                "\n   Light, slippery and wet terrain. Old, empty buildings right next to a crystal lake." +
                "\n3. Set of trees" +
                "\n   Forming a cool shade, this small forest is an ideal hiding ground.");

            Console.WriteLine("\nYou stop. An experienced advisor that you are, you know that this is the time to assess the situation. You look to your champion." +
                "\nThe dragon, once sensing he encountered a mighty foe, he'll try to switch positions to better his fighting tactics." +
                "\nAnd in response, so shall we have to change our tactics. You look at your champion sternly.");

            Console.WriteLine("\nChecking your champion's backpack, you find: " +
                "\n0. Enchanted shield" +
                "\n   This is a must have against a dragon. Your champion will have his shield equipped for the whole duration of this battle." +
                "\n1. Bastard Longsword" +
                "\n   A light, yet powerful weapon. A useful combination with the shield." +
                "\n2. Silver Battle-Axe" +
                "\n   As heavy as they come. The shield will not be as effective, but the damage will be undeniable." +
                "\n3. Set of Iron Spears" +
                "\n   Nothing special about it. Forged with maximum efficiency in mind, solely to be thrown at a long range.");

            bool wait2 = true;
            do
            {
                Console.Write("\nContinue? \n(Press Enter): ");
                var consent2 = Console.ReadKey().Key;
                if (consent2 == ConsoleKey.Enter)
                {
                    Console.WriteLine("\nYou look up to the Rocky mountain top. The dragon is looking straight at you.\n" +
                        "It is a red, scaled beast with the size of three houses. Its eyes glow red with rage and there's smoke coming out of its nostrils." +
                        "\nBut it isn't moving. It's waiting for you.");

                    if (ChampMenu.ChampChoiceOutput == 1)
                    {
                        Console.WriteLine("\nMagnus growls like a wild animal, hairs on his limbs stand up, little foam spills from his mouth.\n" +
                        "\"This thing won't escape me now,\" Magnus says through his teeth, while firmly gripping his long, braided beard.\nHe lets out a violent scream as he runs towards the valley.");
                    }
                    if (ChampMenu.ChampChoiceOutput == 2)
                    {
                        Console.WriteLine("\nWhile staring at the dragon, Legibus polishes his armor for the last time. With a focused gaze, he attempts to control his breath." +
                        "\n\"Let us be victorious, friend. For honor, for glory, and for our loved ones,\" says the young prince.\nAs he starts walking towards the valley, he lets out a peaceful smile.");
                    }
                    if (ChampMenu.ChampChoiceOutput == 3)
                    {
                        Console.WriteLine("\nFascinated by the visage, the wizard studies the beast for a while, making a few crude sketches in one of his notes." +
                        "\n\"This is it then. In the name of knowledge, let us be off,\" says the shadowy scholar.\nWith a quick tempo, Mysterio strides towards the valley with hunger for power in his dark eyes.");
                    }
                    wait2 = false;
                }
                else
                {
                    Console.WriteLine("\n\nYou pour yourself some wine. Your champion picks his nose.");
                }
            } while (wait2 == true);

        }
    }
}
