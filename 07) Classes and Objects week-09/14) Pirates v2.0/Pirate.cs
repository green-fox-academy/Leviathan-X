using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates
{

    class Pirate
    {
        private string name;
        private int perMil = 0;
        public static int perMilCap { get; private set; } = 0;
        
        private bool passOut;

        private Ship hisShip;
        private bool playerStatus;
        public static int passedOutTotal { get; private set; } = 0;

        public Pirate(string Name, Ship HisShip, bool PlayerStatus)
        {
            name = Name;
            hisShip = HisShip;
            playerStatus = PlayerStatus;
        }

        public virtual void DrinkRum(Pirate pirate)
        {
            if (alive && pirate.playerStatus == false)
            {
                if (passOut == true)
                {
                    Console.WriteLine($"\nThe pirate {name} is too drunk to lift the cup!");
                }
                else
                {
                    perMil++;
                    Console.WriteLine($"\nThe pirate {name} says: \"GLO GLO GLO!\"");
                }
            }
            else if (alive && pirate.playerStatus == true)
            {
                if (passOut == true)
                {
                    Console.WriteLine($"\nThe pirate {name} is too drunk to lift the cup!");
                }
                else
                {
                    perMilCap++;
                    Console.WriteLine($"\nThe pirate {name} says: \"GLO GLO GLO!\"");
                }
            }

        }

        public void Die()
        {
            alive = false;
        }

        public void Brawl(Pirate enemy)
        {
            Console.WriteLine($"\nA brawl breaks out between two crew hands!");
            Random randomValue = new Random();

            if (alive)
            {
                if (passOut == true || enemy.passOut == true)
                {
                    Console.WriteLine("\nBut can't really fight if one of 'em is passed out, now can they?");
                }
                else if (playerStatus == true || enemy.playerStatus == true)
                {
                    Console.WriteLine("\nA drunken crew member dares to attack you, and kicked his ass!\nThe entire crew is now sobered up.");
                    perMil = 0;
                    perMilCap = 0;
                }
                else
                {
                    int fate = randomValue.Next(1, 4);
                    switch (fate)
                    {
                        case 1:
                            enemy.Die();
                            Console.WriteLine($"The pirate {enemy.name} blocks a punch with his head and dies!\nThe entire crew looses their buzz by 3 per mil.");
                            perMil -= 3;
                            perMilCap -= 3;
                            break;
                        case 2:
                            Die();
                            Console.WriteLine($"The pirate {name} probably regrets his life decisions as he slowly dies!\nThe entire crew looses their buzz by 3 per mil.");
                            perMil -= 3;
                            perMilCap -= 3;
                            break;
                        case 3:
                            Console.WriteLine("Both pirates fight for a while, then they fall on eachother and pass out. Fallin' asleep like babies.");
                            passOut = true;
                            enemy.passOut = true;
                            passedOutTotal += 2;
                            break;
                    }
                }
            }

        }
    }
}
