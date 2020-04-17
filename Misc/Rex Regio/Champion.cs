using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    abstract class Champion
    {
        protected int Attack;
        protected int Health;
        protected int Defense;
        protected int Stamina;
        protected int Potions;
        protected string Weapon;
        protected string Location;

        public Champion()
        {
            Init();
        }

        public virtual void Init()
        {
            Health = 0;
            Attack = 0;
            Defense = 0;
            Stamina = 0;
            Potions = 0;
        }

        public void ChangeLocation(string Input)
        {
            Location = Input;
        }

        public int PlayAttack()
        {
            int Damage = Attack;
            return Damage;
        }

        public void ReactAttack(int Damage)
        {
            Health -= Damage;
        }

        public bool CheckIfAlive()
        {
            if (Health > 0) return true;
            else return false;
        }

        public int[] GetStatsInterface()
        {
            int[] stats = { Health, Attack, Defense, Stamina, Potions };
            return stats;
        }

        // Default Stats for Intro
        public string GetStats()
        {
            return "\n\n- Stats:" +
                $"\n\tHealth:         {Health}" +
                $"\n\tBase Attack:    {Attack}" +
                $"\n\tBase Defense:   {Defense}" +
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
            Init();
        }

        public override void Init()
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
            Init();
        }

        public override void Init()
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
            Init();
        }

        public override void Init()
        {
            Health = 450;
            Attack = 200;
            Defense = 40;
            Stamina = 100;
            Potions = 6;
        }
    }
}
