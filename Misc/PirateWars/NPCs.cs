using System;
using System.Collections.Generic;
using System.Text;

namespace PirateWars
{
    class Pirate
    {
        public string Name { get; private set; }
        public bool PassOut { get; private set; }
        public bool Alive { get; private set; }
        public int ShotsTaken { get; private set; }

        public Pirate(string name)
        {
            Name = name;
            PassOut = false;
            Alive = true;
            ShotsTaken = 0;
        }

        public virtual void DrinkRum()
        {
            ShotsTaken++;
            if (ShotsTaken == 5) PassOut = true;
        }

        public void Die()
        {
            Alive = false;
        }

        public void Brawl(Pirate aggressor)
        {
            if (aggressor is Captain || this is Captain)
            {
                Console.WriteLine("\nA drunken sailor tries to fight you!" +
                    "To uphold authority, you have to kill him.");
                if (aggressor is Captain) this.Die();
                if (this is Captain) aggressor.Die();
            }
            else if (aggressor.PassOut == true || this.PassOut == true)
            {
                Console.WriteLine("\nCan't really fight if one of 'em is passed out, can they?");
            }
            else
            {
                switch ((new Random()).Next(1, 4))
                {
                    case 1:
                        this.Die();
                        Console.WriteLine($"The defending pirate blocks a punch with his head and dies!");
                        break;
                    case 2:
                        aggressor.Die();
                        Console.WriteLine($"The attacking pirate probably regrets his life decisions as he slowly dies!");
                        break;
                    case 3:
                        Console.WriteLine("Both pirates fight for a while, then they fall on eachother and pass out.");
                        aggressor.PassOut = true;
                        this.PassOut = true;
                        break;
                }
            }
        }
    }

    class Captain : Pirate
    {
        public Captain(string name) : base(name)
        {

        }
    }

    class Ship
    {
        private List<Pirate> Crew;
        private string Name;
        public bool Alive { get; private set; }
        private Captain Capn;

        private Random Randomizer = new Random();

        public Ship(string name, Captain capn)
        {
            Name = name;
            Capn = capn;
            Crew = new List<Pirate>();
        }

        public void FillShip()
        {
            int numOfCrew = Randomizer.Next(2, 11);
            for (int i = 0; i < numOfCrew; i++)
            {
                Crew.Add(new Pirate((i+1).ToString()));
            }
        }

        public int AliveCount
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < Crew.Count; i++)
                {
                    if (Crew[i].Alive) sum++;
                }
                return sum;
            }
        }

        public int AwakeCount
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < Crew.Count; i++)
                {
                    if (!Crew[i].PassOut) sum++;
                }
                return sum;
            }
        }

        public void ShipStatus()
        {
            Console.WriteLine($"\n\n * * * *\nThe {Name} Ship Status: \n\n" +
                $"Captain's Consumed Rum: {Capn.ShotsTaken} per Mil\n" +
                $"Crew Passed Out: {Crew.Count - AwakeCount}/{Crew.Count}" +
                $"\nCrew Alive: {AliveCount}/{Crew.Count}");
        }

        public void BrawlBreakOut()
        {
            Random Randomizer = new Random();
            Console.WriteLine($"\n-- A brawl breaks out on the {Name} ship! --");

            Pirate fighter1;
            Pirate fighter2;
            do
            {
                fighter1 = Crew[Randomizer.Next(0, Crew.Count)];
                fighter2 = Crew[Randomizer.Next(0, Crew.Count)];
            } while (fighter1 == fighter2);     // So that one pirate doesn't fight himself!
            fighter1.Brawl(fighter2);
        }

        public bool Battle(Ship enemy)
        {
            Console.WriteLine($"\n\n-- The {Name} ship sets its sight " +
                $"on the {enemy.Name} ship! --");

            int weAlive = AliveCount;
            int theyAlive = enemy.AliveCount;

            int ourScore = (weAlive - Capn.ShotsTaken);
            int enemyScore = (theyAlive - enemy.Capn.ShotsTaken);

            if (ourScore > enemyScore)
            {
                Console.WriteLine($"The {Name} ship leaves only a smoking " +
                    $"wreck where the {enemy.Name} ship used to be!\n" +
                    $"--Battle Aftermath:");
                WinBattle();
                enemy.LoseBattle();
                return true;
            }
            else
            {
                Console.WriteLine($"The {Name} ship gets ploughed for such an " +
                    $"insolence by the {enemy.Name} ship!\n" +
                    $"--Battle Aftermath:");
                enemy.WinBattle();
                LoseBattle();
                return false;
            }
        }

        public void WinBattle()
        {
            int rumDrinks = Randomizer.Next(1, 3);
            foreach (var pirate in Crew)
            {
                for (int i = 0; i < rumDrinks; i++)
                {
                    pirate.DrinkRum();
                }
            }
            Console.WriteLine($"The crew of {Name} have themselves a little party! " +
                $"Each pirate gets {rumDrinks} per Mil!");
        }

        public void LoseBattle()
        {
            int casualties = Randomizer.Next(0, AliveCount); // 1 always stays alive
            for (int cnt = 0, i = 0; cnt < casualties; i++)
            {
                if (Crew[i].Alive)
                {
                    Crew[i].Die();
                    cnt++;
                }
            }
            Console.WriteLine($"The crew of {Name} suffer {casualties} casualties.");
            Alive = false;
        }
    }
}
