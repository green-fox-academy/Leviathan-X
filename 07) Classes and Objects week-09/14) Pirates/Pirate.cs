using System;
using System.Collections.Generic;
using System.Text;

namespace _14__Pirates
{

    class Pirate
    {
        protected string name;
        public static int Intoxication { get; private set; } = 0;
        protected bool alive = true;
        protected bool passOut;
        public static int passedOutTotal { get; private set; } = 0;
        public static int AliveTotal { get; private set; } = 0;

        public Pirate(string Name)
        {
            name = Name;
            AliveTotal++;
        }

        public virtual void DrinkSomeRum()
        {
            if (alive)
            {
                if (passOut == true)
                {
                    Console.WriteLine($"\n{name} is too drunk to lift the cup!");
                }
                else
                {
                    Intoxication++;
                    Console.WriteLine($"\n{name} says: \"GLO GLO GLO!\"");
                }
            }
            else
            {
                Console.WriteLine($"\n{name} lies dead. And dead men don't drink.");
            }
        }

        // Do these things HAVE TO be fields? 
        // I'd rather they'd be inside the method HowsItGoingMate()
        protected string IntoxPlus = "Pirate: \"Pour me anudder!\"";
        protected string passOutLine = "Pirate: \"Arghh, I'ma Pirate. How d'ya d'ink its goin?\"\nThe pirate passes out.";
        protected string passOutStatus = "This pirate is passed out.";
        protected string deadStatus = "The pirate's dead.";

        public virtual void HowsItGoingMate()
        {
            Console.WriteLine($"\n{name}! How's it going, mate?");

            if (alive)
            {
                if(passOut == false)
                {
                    if (Intoxication < 4)
                    {
                        Console.WriteLine(IntoxPlus);
                    }
                    else if (Intoxication > 4)
                    {
                        Console.WriteLine(passOutLine);
                        passOut = true;
                        passedOutTotal++;
                    }
                }
                else
                {
                    Console.WriteLine(passOutStatus);
                }
            }
            else
            {
                Console.WriteLine(deadStatus);
            }
        }

        public void Die()
        {
            alive = false;
            AliveTotal--;
        }

        public void Brawl(Pirate enemy)
        {
            Console.WriteLine($"\nThe pirate {name} picks a fight with a crewmember, {enemy.name}!");
            Random randomValue = new Random();

            if (enemy.alive)
            {
                if (passOut == true || enemy.passOut == true)
                {
                    Console.WriteLine("\nCan't really fight if one of 'em is passed out, can they?");
                }
                else
                {
                    int fate = randomValue.Next(1, 4);
                    switch (fate)
                    {
                        case 1:                           
                            enemy.Die();
                            Console.WriteLine($"{enemy.name} blocks a punch with his head and dies!");
                            break;
                        case 2:
                            Die();
                            Console.WriteLine($"{name} probably regrets his life decisions as he slowly dies!");
                            break;
                        case 3:
                            Console.WriteLine("Both pirates fight for a while, then they fall on eachother and pass out.");
                            passOut = true;
                            enemy.passOut = true;
                            passedOutTotal += 2;
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("\nBut hey, you can't fight a corpse now, can ya?");
            }
        }


    }
}
