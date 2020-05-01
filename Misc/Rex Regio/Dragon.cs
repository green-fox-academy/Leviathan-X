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
        private int FuryPercent;
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
            BaseDefence = 20;
            CurrentDefence = BaseDefence;
            BaseStamina = 240;
            CurrentStamina = BaseStamina;
            FuryPercent = 0;
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

            CurrentAttack += StanceBuffsAttack + LocationBuffsAttack + GetFuryDamage();
            CurrentDefence += StanceBuffDefence + LocationBuffDefence;
        }

        public int GetFuryDamage()
        {
            int FuryDamage;
            if (FuryPercent == 0) FuryDamage = 0;
            else if (FuryPercent <= 20) FuryDamage = 5;
            else if (FuryPercent <= 50 && FuryPercent > 20) FuryDamage = 10;
            else if (FuryPercent <= 80 && FuryPercent > 50) FuryDamage = 15;
            else if (FuryPercent <= 100 && FuryPercent > 80) FuryDamage = 20;
            else throw new Exception("\n--Error!\nDragon anger damage invalid input!");

            return FuryDamage;
        }

        // Basic Play Attack & React to Attack
        public void PlayAttack(int PlayerDefence)
        {
            Log.DragonAttack(Stance, CurrentAttack, GetStaminaPenalty(), GetFuryDamage(), PlayerDefence);
        }

        public void ReactAttack(int Damage)
        {
            if (Damage - CurrentDefence <= 0) Console.WriteLine("\n--No damage done to the Dragon!");
            else CurrentHealth -= Damage - CurrentDefence;

            if (CurrentHealth == MaxHealth) FuryPercent = 0;
            else if (PercentCalc(CurrentHealth) > 80 && PercentCalc(CurrentHealth) < 100) FuryPercent = 20;
            else if (PercentCalc(CurrentHealth) > 60 && PercentCalc(CurrentHealth) < 80) FuryPercent = 40;
            else if (PercentCalc(CurrentHealth) > 40 && PercentCalc(CurrentHealth) < 60) FuryPercent = 60;
            else if (PercentCalc(CurrentHealth) > 20 && PercentCalc(CurrentHealth) < 40) FuryPercent = 80;
            else if (PercentCalc(CurrentHealth) > 0 && PercentCalc(CurrentHealth) < 20) FuryPercent = 100;
        }
        private int PercentCalc(int input)
        {
            return (input * 100) / MaxHealth;
        }

        // Calculate Stamina Penalty from Ini. Attack
        public bool StaminaPenaltyCalc()
        {
            bool canAttack;

            int StaminaPenalty = GetStaminaPenalty();

            if (CurrentStamina - StaminaPenalty < 0) 
            {
                Console.WriteLine("\n--Not enough stamina to attack!");
                canAttack = false;
            }
            else
            {
                CurrentStamina -= StaminaPenalty;
                canAttack = true;
            }
            return canAttack;
        }

        public int GetStaminaPenalty()
        {
            int StaminaPenalty;
            if (Stance == 1) StaminaPenalty = 20;
            else if (Stance == 2) StaminaPenalty = 40;
            else if (Stance == 3) StaminaPenalty = 80;
            else throw new Exception("\n--Error!\nDragon stamina penalty has invalid value!");
            return StaminaPenalty;
        }

        // Switch Stance Mechanism
        public void SwitchStance(int input)
        {
            if (input == 1) Stance = 1;
            else if (input == 2) Stance = 2;
            else if (input == 3) Stance = 3;
            else throw new Exception("\n\n--Error!\nWrong input in switch stance!");

            Log.DragonNewStance(input);
        }

        // Switch Location Mechanism
        public void SwitchLocation(int input)
        {
            if (input == 1) Location = 1;
            else if (input == 2) Location = 2;
            else if (input == 3) Location = 3;
            else throw new Exception("\n\n--Error!\nWrong input in switch location!");

            Log.DragonNewLocation(input);
        }

        // Rest 
        public void Rest(int Turns)
        {
            int RestHP = 70;
            if (CurrentHealth + (RestHP * Turns) > MaxHealth) CurrentHealth = MaxHealth;
            else CurrentHealth += RestHP * Turns;

            int RestStamina = 40;
            if (CurrentStamina + (RestStamina * Turns) > BaseStamina) CurrentStamina = BaseStamina;
            else CurrentStamina += RestStamina * Turns;

            Log.DragonRest(Turns, RestHP, RestStamina);
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
            int[] stats = { MaxHealth, BaseAttack, BaseDefence, BaseStamina, 
            CurrentHealth, CurrentAttack, CurrentDefence, CurrentStamina,
            Stance, Location, FuryPercent };
            return stats;
        }
    }
}
