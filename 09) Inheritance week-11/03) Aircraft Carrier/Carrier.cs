using System;
using System.Collections.Generic;
using System.Text;

namespace _03__Aircraft_Carrier
{
    class Carrier
    {
        List<Aircraft> aircrafts;
        string name;
        int ammoStorage;
        private int HP;

        public Carrier(string Name, int AmmoStorage)
        {
            name = Name;
            aircrafts = new List<Aircraft>();
            ammoStorage = AmmoStorage;
            HP = 0;
            Console.WriteLine($"\nThe {name} carrier is sighted roaming the sky!\nAmmo Storage: {ammoStorage}");
        }

        public void Add(Aircraft aircraft)
        {
            aircrafts.Add(aircraft);
            HP += 1000;
            Console.WriteLine($"\nAn aircraft of type {aircraft.airType} has joined the {name} carrier.");
        }

        public void Fill()
        {
            Console.WriteLine($"\nThe {name} carrier attempts to refill its aircraft units..\nLoading..");
            //int ammoRedistribute = ammoStorage;
            int ammoLeft = 0;
            if (ammoStorage > 0)
            {
                if (ammoStorage % aircrafts.Count != 0)
                {
                    Console.WriteLine($"Not enough ammo for all aircraft units! Giving priority to the F35 aircraft.");
                    //ammoRedistribute /= aircrafts.Count;
                    foreach (var plane in aircrafts)
                    {
                        if(plane.isPriority() == true)
                        {
                            ammoStorage += plane.Refill(ammoStorage);
                        }
                    }
                    foreach (var plane in aircrafts)
                    {
                        if (plane.isPriority() == false)
                        {
                            ammoStorage += plane.Refill(ammoStorage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enough ammo for all aircraft units. Equally redistributing to all aircraft units to fight communism.");
                    //ammoRedistribute /= aircrafts.Count;
                    
                    foreach (var plane in aircrafts)
                    {
                        ammoStorage += plane.Refill(ammoStorage);
                    }
                }
            }
            else
            {
                throw new Exception ("\nError!\nNo amount in carrier Ammo Storage!");
            }

            ammoStorage += ammoLeft;
            Console.WriteLine($"\nProcess of carrier filling complete.\nThe new {name} Ammo Storage: {ammoStorage} ");
        }

        public void Fight(Carrier enemyCarrier)
        {
            Console.WriteLine($"\nThe {name} carrier sets its sight on the {enemyCarrier.name} carrier!");

            foreach (var plane in aircrafts)
            {
                plane.Fight();
            }

            enemyCarrier.HP -= TotalBaseDmg();

            Console.WriteLine($"\nThe {enemyCarrier.name} Carrier Aftermath:\nDamage done: {TotalBaseDmg()}hp\nRemaining HP: {enemyCarrier.HP}hp");
        }

        public void GetStatus()
        {
            if(HP > 0)
            {
                Console.WriteLine($"\nThe {name} Carrier Status:\nHP: {HP}hp\nAircraft count: {aircrafts.Count}\nAmmo Storage: {ammoStorage}\nTotal Damage Potential: {TotalBaseDmg()}hp");
            }
            else
            {
                Console.WriteLine($"\nThe {name} Carrier Status:\nIt's dead, Jim.");
            }
        }

        private int TotalBaseDmg()
        {
            int totalBaseDmg = 0;

            foreach (var plane in aircrafts)
            {
                totalBaseDmg += plane.AllDamage;
            }
            return totalBaseDmg;
        }

    }
}
