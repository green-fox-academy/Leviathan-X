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
        protected int ammoStorage;
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
            ammoStorage = 4;
            AllDamage = baseDamage * ammoStorage;
        }
        
        public void Fight()
        {
            Console.WriteLine($"Aircraft {airType} attacks! - {ammoStorage * baseDamage}hp damage in total.");
            ammoStorage = 0;
        }

        public int Refill(int carrierAmmo)
        {
            int remainingAmmo = 0;

            if (ammoStorage < maxAmmo)
            {
                do
                {
                    ammoStorage++;
                    carrierAmmo--;
                }
                while (ammoStorage < maxAmmo);
                remainingAmmo = carrierAmmo;
            }
            Console.WriteLine($"\nThe aircraft {airType} has been refilled!\nReturning {remainingAmmo} ammo to the carrier.");
            return remainingAmmo;
        }

        public string GetAirType()
        {
            string gettype = airType.ToString();

            return gettype;
        }

        public void getStatus()
        {
            Console.WriteLine($"\nType: {airType}, Ammo: {ammoStorage}, Base Damage: {baseDamage}, All Damage: {ammoStorage * baseDamage}");
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
