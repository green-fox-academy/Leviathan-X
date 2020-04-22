using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    class Dragon
    {
        private int MaxHealth;
        private int CurrentHealth;
        private int BaseAttack;
        private int CurrentAttack;
        private int BaseDefence;
        private int CurrentDefence;
        private int BaseStamina;
        private int CurrentStamina;
        private int Anger;
        private int Stance;
        private int Location;

        public Dragon()
        {
            Init();
        }

        // Initialize New Game Dragon
        public void Init()
        {
            MaxHealth = 2500;
            CurrentHealth = MaxHealth;
            BaseAttack = 140;
            CurrentAttack = BaseAttack;
            BaseDefence = 140;
            CurrentDefence = BaseDefence;
            BaseStamina = 150;
            CurrentStamina = BaseStamina;
            Anger = 0;
            Stance = 1;
            Location = 1;
        }

        // Apply Buffs 
        public void ApplyBuffs()
        {
            int StanceBuffsAttack;
            int StanceBuffDefence;
            if (Stance == 1)
            {
                StanceBuffsAttack = 0;
                StanceBuffDefence = 40;
            }
            else if (Stance == 2)
            {
                StanceBuffsAttack = 40;
                StanceBuffDefence = -30;
            }
            else if (Stance == 3)
            {
                StanceBuffsAttack = 0;
                StanceBuffDefence = 0;
            }
            else throw new Exception("\n--Error!\nDragon attack invalid stance input!");

            int LocationBuffsAttack;
            int LocationBuffDefence;
            if (Location == 1)
            {
                LocationBuffsAttack = 60;
                LocationBuffDefence = -30;
            }
            else if (Location == 2)
            {
                LocationBuffsAttack = 0;
                LocationBuffDefence = -20;
            }
            else if (Location == 3)
            {
                LocationBuffsAttack = 0;
                LocationBuffDefence = 0;
            }
            else throw new Exception("\n--Error!\nDragon attack invalid location input!");

            int AngerDamage = GetAngerDamage();

            CurrentAttack += StanceBuffsAttack + LocationBuffsAttack + AngerDamage;
            CurrentDefence += StanceBuffDefence + LocationBuffDefence;
        }

        public int GetAngerDamage()
        {
            int AngerDamage;
            if (Anger == 0) AngerDamage = 0;
            else if (Anger <= 20) AngerDamage = 5;
            else if (Anger <= 50 && Anger > 20) AngerDamage = 10;
            else if (Anger <= 80 && Anger > 50) AngerDamage = 15;
            else if (Anger <= 100 && Anger > 80) AngerDamage = 20;
            else throw new Exception("\n--Error!\nDragon anger damage invalid input!");

            return AngerDamage;
        }

        // Basic React to Attack
        public void ReactAttack(int Damage)
        {
            CurrentHealth -= Damage;
            if (CurrentHealth == MaxHealth) Anger = 0;
            else if (PercentCalc(CurrentHealth) > 80 && PercentCalc(CurrentHealth) < 100) Anger = 20;
            else if (PercentCalc(CurrentHealth) > 60 && PercentCalc(CurrentHealth) < 80) Anger = 40;
            else if (PercentCalc(CurrentHealth) > 40 && PercentCalc(CurrentHealth) < 60) Anger = 60;
            else if (PercentCalc(CurrentHealth) > 20 && PercentCalc(CurrentHealth) < 40) Anger = 80;
            else if (PercentCalc(CurrentHealth) > 0 && PercentCalc(CurrentHealth) < 20) Anger = 100;
        }
        private int PercentCalc(int input)
        {
            return (input * 100) / MaxHealth;
        }

        // Switch Stance Mechanism
        public void SwitchStance(int input)
        {
            if (input == 1) Stance = 1;
            else if (input == 2) Stance = 2;
            else if (input == 3) Stance = 3;
            else throw new Exception("\n\n--Error!\nWrong input in switch stance!");
        }

        // Switch Location Mechanism
        public void SwitchLocation(int input)
        {
            if (input == 1) Location = 1;
            else if (input == 2) Location = 2;
            else if (input == 3) Location = 3;
            else throw new Exception("\n\n--Error!\nWrong input in switch location!");
        }

        // Rest 
        public void Rest(int Turns)
        {
            int RestHP = 70;
            if (CurrentHealth + (RestHP * Turns) > MaxHealth) CurrentHealth = MaxHealth;
            else CurrentHealth += RestHP * Turns;
        }

        // Check Alive Status
        public bool CheckIfAlive()
        {
            if (CurrentHealth > 0) return true;
            else return false;
        }

        // Send Statistics to Player Interface
        public int[] GetStatsInterface()
        {
            int[] stats = { MaxHealth, BaseAttack, BaseDefence, BaseStamina, Anger,
            CurrentHealth, CurrentAttack, CurrentDefence, CurrentStamina, Stance, Location };
            return stats;
        }
    }
}
