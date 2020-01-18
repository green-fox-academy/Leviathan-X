using System;

namespace Rex_Regio
{
    class Program
    {
        // Methods - Star Castle Welcoming Screen
        static void Stars(int count)
        {
            for (int i = 0; i < count; ++i)
                Console.Write("*");
        }
        static void Spaces(int count)
        {
            for (int i = 0; i < count; ++i)
                Console.Write(" ");
        }

        // Method - Player Introduction
        static string PlayerIntro()
        {
            Console.Write("\n\nHooded figure: \"What is your name, stranger?\"\n\nYou: \"Greetings. My name is ");
            string playerName = Console.ReadLine();
            Console.WriteLine("and I've come to your land to mentor a champion.\"");
            Console.Write("\nHooded figure: \"How wonderful! You're just what we need, {0}. ", playerName);
            Console.WriteLine("My name is Oxphor, a humble councilman of our people.\"\nCouncilman: *bows graciously*\n\nCouncilman: \"These are troubled times in the kingdom of Regio, for " +
                "a dragon has slayed the king! \nWith no heirs left, the crown will belong to the man who shall slay the foul beast.\"" +
                "\n\n" + playerName + ": \"So I've heard. I trust the word has spread far enough, and worthy challengers have shown up.\"" +
                "\n\nCouncilman: \"The champions have assembled before you, wise one. They are ready to meet you, {0}.\"", playerName);

            int wait = 1;
            do
            {
                Console.Write("\nAre you ready?\n(y/n): ");
                string consent = Console.ReadLine();
                if (consent == "y" || consent == "Y")
                {
                    Console.WriteLine("\nCouncilman: \"Verily! {0}, please meet the brave champions.\"", playerName);
                    Console.WriteLine("\n\n----------------------------------------------------------------------------------------------------------------");
                    wait = 0;
                }
                else
                {
                    Console.WriteLine("\nCouncilman: *intensely staring at you and waiting*");
                }
            } while (wait == 1);

            return playerName;
        }

        // Method - Champions Introduction
        static void ChampIntro()
        {
            Console.WriteLine(
                "\n-= Magnus the Wild" +
                "\nA burly and an experienced warrior, who came for what is rightfully his." +
                "\n- Stats:" +
                "\nHealth:         1.200hp" +
                "\nAttack:         80%" +
                "\nDefense:        120%" +
                "\nStamina:        80%" +
                "\nHealth Potions: 2 (350hp)" +

                "\n\n-= Legibus II" +
                "\nAn ambitious young prince from a neighbouring kingdom, he seeks to prove himself and to defy his father." +
                "\n- Stats:" +
                "\nHealth:         1.000hp" +
                "\nAttack:         120%" +
                "\nDefense:        80%" +
                "\nStamina:        120%" +
                "\nHealth Potions: 4 (350hp)" +

                "\n\n-= Mysterio Dark Eyes" +
                "\nAn enchanter from lands unknown, carrying a strange, humming amulet. Nobody knows his true motivations." +
                "\n-Stats:" +
                "\nHealth:         450hp" +
                "\nAttack:         200%" +
                "\nDefense:        40%" +
                "\nStamina:        100%" +
                "\nHealth Potions: 6 (350hp)");
        }

        // Method - The Champion Choice
        static int ChampChoice()
        {

            string spelling = "incorrect";
            do
            {
                Console.Write("\nChoose your champion! \n(Magnus/Legibus/Mysterio): ");
                string champName = Console.ReadLine();

                if (champName == "Magnus" || champName == "magnus")
                {
                    Console.WriteLine("\n\n-- You have chosen the Bear of the North --\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------\n");
                    spelling = "correct";
                    return 1;
                }
                else if ((champName == "Legibus") || (champName == "legibus"))
                {
                    Console.WriteLine("\n\n-- You have chosen the Viper of the West --\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------\n");
                    spelling = "correct";
                    return 2;
                }
                else if ((champName == "Mysterio") || (champName == "mysterio"))
                {
                    Console.WriteLine("\n\n-- You have chosen the Owl of the South. --\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------\n");
                    spelling = "correct";
                    return 3;
                }
                else
                {
                    Console.WriteLine("\nInvalid name!\nPlease check the spelling of your champion choice.");
                    spelling = "incorrect";
                }
            } while (spelling == "incorrect");
            return 0;
        }
        // Methods - Champion Statistics
        static int Health(int champChoice)
        {
            if (champChoice == 1)
            {
                return 1200;
            }
            else if (champChoice == 2)
            {
                return 1000;
            }
            else if (champChoice == 3)
            {
                return 450;
            }
            else
            {
                Console.WriteLine("Error!");
                return 0;
            }
        }
        static int Attack(int champChoice)
        {
            if (champChoice == 1)
            {
                return 80;
            }
            else if (champChoice == 2)
            {
                return 120;
            }
            else if (champChoice == 3)
            {
                return 200;
            }
            else
            {
                Console.WriteLine("Error!");
                return 0;
            }
        }
        static int Defense(int champChoice)
        {
            if (champChoice == 1)
            {
                return 120;
            }
            else if (champChoice == 2)
            {
                return 80;
            }
            else if (champChoice == 3)
            {
                return 40;
            }
            else
            {
                Console.WriteLine("Error!");
                return 0;
            }
        }
        static int Stamina(int champChoice)
        {
            if (champChoice == 1)
            {
                return 80;
            }
            else if (champChoice == 2)
            {
                return 120;
            }
            else if (champChoice == 3)
            {
                return 100;
            }
            else
            {
                Console.WriteLine("Error!");
                return 0;
            }
        }
        static int Potion(int champChoice)
        {
            if (champChoice == 1)
            {
                return 2;
            }
            else if (champChoice == 2)
            {
                return 4;
            }
            else if (champChoice == 3)
            {
                return 6;
            }
            else
            {
                Console.WriteLine("Error!");
                return 0;
            }
        }
        // Method - Fight Preparation
        static int FightPrep(int champStats)
        {
            string champName;
            if (champStats == 1) { champName = "Magnus"; Console.WriteLine("After lots of strenuous training, you and your champion {0} set out for the long road ahead..", champName); }
            if (champStats == 2) { champName = "Legibus"; Console.WriteLine("After lots of strenuous training, you and your champion {0} set out for the long road ahead..", champName); }
            if (champStats == 3) { champName = "Mysterio"; Console.WriteLine("After lots of strenuous training, you and your champion {0} set out for the long road ahead..", champName); }

            Console.Write("\n\nThe road was hard and treacherous, yet you finally make it to the mountains, where the den of the dragon is rumored to be." +
                "\nYou stand right before the entrance to the top of the mountain.");

            int wait = 1;
            do
            {
                Console.Write("\nDo you dare to continue further?\n(y/n): ");
                string consent = Console.ReadLine();
                if (consent == "y" || consent == "Y")
                {
                    if (champStats == 1) { champName = "Magnus"; Console.WriteLine("", champName); }
                    if (champStats == 2) { champName = "Legibus"; Console.WriteLine("", champName); }
                    if (champStats == 3) { champName = "Mysterio"; Console.WriteLine("", champName); }
                    wait = 0;
                }
                else
                {
                    Console.WriteLine("\nYou decide to take one more breather. You pour some more wine into your champion's cup.");
                }
            } while (wait == 1);

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

            int wait2 = 1;
            do
            {
                Console.Write("\nContinue? \n(y/n): ");
                string consent2 = Console.ReadLine();
                if (consent2 == "y" || consent2 == "Y")
                {
                    Console.WriteLine("\nYou look up to the Rocky mountain top. The dragon is looking straight at you.\n" +
                        "It is a red, scaled beast with the size of three houses. Its eyes glow red with rage and there's smoke coming out of its nostrils." +
                        "\nBut it isn't moving. It's waiting for you.");

                    if (champStats == 1)
                    {
                        champName = "Magnus"; Console.WriteLine("\n{0} growls like a wild animal, hairs on his limbs stand up, little foam spills from his mouth.\n" +
                        "\"This thing won't escape me now,\" {0} says through his teeth, while firmly gripping his long, braided beard.\nHe lets out a violent scream as he runs towards the valley.", champName);
                    }
                    if (champStats == 2)
                    {
                        champName = "Legibus"; Console.WriteLine("\nWhile staring at the dragon, {0} polishes his armor for the last time. With a focused gaze, he attempts to control his breath." +
                        "\n\"Let us be victorious, friend. For honor, for glory, and for our loved ones,\" says the young prince.\nAs he starts walking towards the valley, he lets out a peaceful smile.", champName);
                    }
                    if (champStats == 3)
                    {
                        champName = "Mysterio"; Console.WriteLine("\nFascinated by the visage, {0} studies the beast for a while, making a few crude sketches in one of his notes." +
                        "\n\"This is it then. In the name of knowledge, let us be off,\" says the shadowy scholar.\nWith a quick tempo, {0} strides towards the valley with hunger for power in his dark eyes.", champName);
                    }


                    wait2 = 0;
                }
                else
                {
                    Console.WriteLine("\nYou pour yourself some wine. Your champion picks his nose.");
                }
            } while (wait2 == 1);

            return 0;
        }

        // Method ---- Main
        static void Main(string[] args)
        {
            // Main - The Castle Welcoming Screen 
            int n = 8;
            for (int i = 0; i < n; ++i)
            {
                Stars(i + 1);
                Spaces(n - i - 1);
                Stars(n - i + 1);
                Spaces(2 * i);
                Stars(n - i);
                Spaces(n - i - 1);
                Stars(i + 1);

                Console.WriteLine();
            }
            Console.WriteLine("    -= Welcome to Rex Regio =-" +
                "\n\n\n  (Window fullscreen is advised)\n\n\n\n");
            
            // Main - The Player Introduction
            string playerName = PlayerIntro();

            string newGame = "y";

            do
            {
                // Main - The Champion Introduction
                ChampIntro();

                int champStats = ChampChoice();
                int health, attack, defense, stamina, potion;

                // Main - Champion Statistics
                health = Health(champStats);
                attack = Attack(champStats);
                defense = Defense(champStats);
                stamina = Stamina(champStats);
                potion = Potion(champStats);

                // Main - Fight Preparation
                FightPrep(champStats);




                // Main - Aftergame
                Console.Write("\nWould you like to play a new game, {0}? (y/n): ", playerName);
                newGame = Console.ReadLine();
            } while (newGame == "y" || newGame == "Y");
               if (newGame != "y" || newGame !="Y")
               {
                Console.WriteLine("\n\n\nSafe travels, {0}.\n\nCreated by: -= Igor Immanuel Orlov =-", playerName);
                Console.ReadLine();
               }

        }
    }
}
