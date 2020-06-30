using System;
using System.Collections.Generic;
using System.Text;

namespace _03__Aircraft_Carrier
{
    class Carrier
    {
        List<Aircraft> aircrafts;
        string name;
        int carrierAmmoStorage;
        private int HP;

        public Carrier(string Name, int CarrierAmmoStorage)
        {
            name = Name;
            aircrafts = new List<Aircraft>();
            carrierAmmoStorage = CarrierAmmoStorage;
            HP = 0;
            Console.WriteLine($"\nThe {name} carrier is sighted roaming the sky!\nAmmo Storage: {carrierAmmoStorage}");
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
            try
            {
                if (carrierAmmoStorage > 0)
                {
                    for (int i = 0; i < aircrafts.Count; i++)
                    {
                        if (aircrafts[i].isPriority() == true) carrierAmmoStorage = aircrafts[i].Refill(carrierAmmoStorage);
                    }
                    
                    if (carrierAmmoStorage > 0)
                    {
                        for (int i = 0; i < aircrafts.Count; i++)
                        {
                            if (aircrafts[i].isPriority() == false) carrierAmmoStorage = aircrafts[i].Refill(carrierAmmoStorage);
                        }
                    }
                }
                else
                {
                    throw new Exception("\nError!\nNo amount in carrier Ammo Storage!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n{e.Message}");
            }

            Console.WriteLine($"\nProcess of carrier filling complete.\nThe new {name} Ammo Storage: {carrierAmmoStorage} ");
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
                Console.WriteLine($"\nThe {name} Carrier Status:\nHP: {HP}hp\nAircraft count: {aircrafts.Count}\nAmmo Storage: {carrierAmmoStorage}\nTotal Damage Potential: {TotalBaseDmg()}hp");
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
