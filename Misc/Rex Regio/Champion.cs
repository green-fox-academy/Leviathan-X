using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    class Champion
    {
        protected int Attack;
        protected int Health;
        protected int Defense;
        protected int Stamina;
        protected int Potions;

        public Champion()
        {
        }

        public string GetStats()
        {
            return "\n\n- Stats:" +
                $"\n\tHealth:         {Health}" +
                $"\n\tAttack:         {Attack}" +
                $"\n\tDefense:        {Defense}" +
                $"\n\tStamina:        {Stamina}" +
                $"\n\tHealth Potions: {Potions} (350hp)";
        }

        public static void blankStats(int ChampNum)
        {
            Champion blankMagnus = new Magnus();
            Champion blankLegibus = new Legibus();
            Champion blankMysterio = new Mysterio();

            if (ChampNum == 1) Console.WriteLine(blankMagnus.GetStats());
            else if (ChampNum == 2) Console.WriteLine(blankLegibus.GetStats());
            else if (ChampNum == 3) Console.WriteLine(blankMysterio.GetStats());
            else throw new Exception("Blank Champion number is invalid!");
        }
    }

    class Magnus : Champion
    {
        public Magnus()
        {
            Health = 1200;
            Attack = 80;
            Defense = 120;
            Stamina = 80;
            Potions = 2;
        }
    }

    class Legibus : Champion
    {
        public Legibus()
        {
            Health = 850;
            Attack = 120;
            Defense = 80;
            Stamina = 120;
            Potions = 4;
        }
    }

    class Mysterio : Champion
    {
        public Mysterio()
        {
            Health = 450;
            Attack = 200;
            Defense = 40;
            Stamina = 100;
            Potions = 6;
        }
    }
}
