using System;
using System.Collections.Generic;
using System.Text;

namespace _03__Aircraft_Carrier
{
    enum TypeOfAircraft
    {
        F16,
        F35
    }

    class Aircraft
    {
        protected int maxAmmo;
        protected int baseDamage;
        protected int planeAmmoStorage;
        public TypeOfAircraft airType;
        public int AllDamage { get; private set; }

        public Aircraft(TypeOfAircraft AirType)
        {
            airType = AirType;

            if (airType == TypeOfAircraft.F16)
            {
                maxAmmo = 8;
                baseDamage = 30;
            }
            else if (airType == TypeOfAircraft.F35)
            {
                maxAmmo = 12;
                baseDamage = 50;
            }
            AllDamage = baseDamage * planeAmmoStorage;
            planeAmmoStorage = 0;
        }
        
        public void Fight()
        {
            if(planeAmmoStorage > 0)
            {
                Console.WriteLine($"Aircraft {airType} attacks! - {planeAmmoStorage * baseDamage}hp damage in total.");
                planeAmmoStorage = 0;
            }
            else
            {
                Console.WriteLine($"Aircraft {airType} has no ammo left! - {planeAmmoStorage * baseDamage}hp damage in total.");
            }
        }

        public int Refill(int carrierAmmo)
        {
            if (carrierAmmo < 0)
            {
                Console.WriteLine("\nError! Failed to refill!");
                return 0;
            }
            else
            {
                int ammoNeeded = 0;
                if (planeAmmoStorage < maxAmmo)
                {
                    do
                    {
                        planeAmmoStorage++;
                        ammoNeeded++;
                    }
                    while (planeAmmoStorage < maxAmmo);

                    Console.WriteLine($"\nThe aircraft {airType} has been refilled! ({airType} Max Ammo = {maxAmmo})\nThe amount of {carrierAmmo - ammoNeeded} ammo remains in the Carrier Storage.");
                    return carrierAmmo - ammoNeeded;
                }
                else return 0;
            }
        }

        public string GetAirType()
        {
            string gettype = airType.ToString();

            return gettype;
        }

        public void getStatus()
        {
            Console.WriteLine($"\nType: {airType}, Ammo: {planeAmmoStorage}, Base Damage: {baseDamage}, All Damage: {planeAmmoStorage * baseDamage}");
        }

        public bool isPriority()
        {
            if (airType == TypeOfAircraft.F16)
            {
                return false;
            }
            else if (airType == TypeOfAircraft.F35)
            {
                return true;
            }
            else
            {
                Console.WriteLine("\nError!");
                return false;
            }
        }

    }
}
