using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates_v1._0
{
    class Pirate
    {
        private string captainName;
        private bool passOut = false;
        private bool captain;

        public bool Alive { get; private set; } = true;
        public int PerMil { get; private set; } = 0;
        public static int PassedOutTotal { get; private set; } = 0;
        public static int DeadTotal { get; private set; } = 0;

        public Pirate(string CaptainName,  bool Captain)
        {
            captainName = CaptainName;
            captain = Captain;
        }

        public void DrinkSomeRum()
        {
            PerMil++;
            if (captain) Console.WriteLine($"\nThe pirate {captainName} says: \"GLO GLO GLO!\"");
        }

        public void HowsItGoingMate()
        {
            Console.WriteLine("\nHow's it going, pirate?");
            if (Alive)
            {
                if (PerMil < 5)
                {
                    Console.WriteLine("\nPour me anudder!");
                }
                else
                {
                    Console.WriteLine("\nArghh, I'ma Pirate. How d'ya d'ink its goin?");
                    passOut = true;
                }
            }
            else
            {
                Console.WriteLine("\nYo he dead.");
            }
        }

        public void Die()
        {
            Alive = false;
            DeadTotal++;
        }

        public static void Brawl(Pirate aggressor, Pirate defendant)
        {
            PassedOutTotal = 0;
            DeadTotal = 0;

            Random randomValue = new Random();

            if (aggressor.captain == true || defendant.captain == true)
            {
                Console.WriteLine("\nHey! You can't fight the captain!");
            }
            else if (aggressor.passOut == true || defendant.passOut == true)
            {
                Console.WriteLine("\nCan't really fight if one of 'em is passed out, can they?");
            }
            else if (aggressor.Alive == false || defendant.Alive == false)
            {
                Console.WriteLine("\nBut hey, you can't fight a corpse, now can ya?");
            }
            else
            {
                int fate = randomValue.Next(1, 4);
                switch (fate)
                {
                    case 1:
                        defendant.Die();
                        Console.WriteLine($"The defending pirate blocks a punch with his head and dies!");
                        break;
                    case 2:
                        aggressor.Die();
                        Console.WriteLine($"The attacking pirate probably regrets his life decisions as he slowly dies!");
                        break;
                    case 3:
                        Console.WriteLine("Both pirates fight for a while, then they fall on eachother and pass out.");
                        aggressor.passOut = true;
                        defendant.passOut = true;
                        PassedOutTotal += 2;
                        break;
                }
            }
        }

    }
}
