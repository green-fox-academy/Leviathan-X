using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    abstract class Champion
    {
        protected int BaseAttack;
        protected int CurrentAttack;
        protected int MaxHealth;
        protected int CurrentHealth;
        protected int BaseDefence;
        protected int CurrentDefence;
        protected int BaseStamina;
        protected int CurrentStamina;
        protected int Potions;
        protected int Weapon;
        protected int Location;

        public Champion()
        {
            Init();
        }

        // Initialize New Game Character
        public virtual void Init()
        {
            CurrentHealth = 0;
            MaxHealth = CurrentHealth;
            BaseAttack = 0;
            CurrentAttack = BaseAttack;
            BaseDefence = 0;
            CurrentDefence = BaseDefence;
            BaseStamina = 0;
            CurrentStamina = BaseStamina;
            Potions = 0;
            Weapon = 1;
            Location = 1;
        }

        // Apply Buffs
        public void ApplyBuffs()
        {
            int WeaponBuffsAttack;
            int WeaponsBuffDefence;
            if (Weapon == 1)
            {
                WeaponBuffsAttack = 0;
                WeaponsBuffDefence = 40;
            }
            else if (Weapon == 2)
            {
                WeaponBuffsAttack = 40;
                WeaponsBuffDefence = -30;
            }
            else if (Weapon == 3)
            {
                WeaponBuffsAttack = 0;
                WeaponsBuffDefence = 0;
            }
            else throw new Exception("\n--Error!\nPlay attack invalid weapon input!");

            int LocationBuffsAttack;
            int LocationBuffDefence;
            if (Location == 1)
            {
                LocationBuffsAttack = -20;
                LocationBuffDefence = 20;
            }
            else if (Location == 2)
            {
                LocationBuffsAttack = 60;
                LocationBuffDefence = -30;
            }
            else if (Location == 3)
            {
                LocationBuffsAttack = 0;
                LocationBuffDefence = 50;
            }
            else throw new Exception("\n--Error!\nPlay attack invalid weapon input!");

            CurrentAttack += WeaponBuffsAttack + LocationBuffsAttack;
            CurrentDefence += WeaponsBuffDefence + LocationBuffDefence;
        }

        // Basic Play Attack & React to Attack
        public void PlayAttack(int DragonDefence)
        {
            Log.PlayerAttack(Weapon, CurrentAttack, GetStaminaPenalty(), DragonDefence);
        }

        public void ReactAttack(int Damage)
        {
            if (Damage - CurrentDefence <= 0) Console.WriteLine("\n--No damage done to the Player!");
            else CurrentHealth -= Damage - CurrentDefence;
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
            if (Weapon == 1) StaminaPenalty = 10;
            else if (Weapon == 2) StaminaPenalty = 20;
            else if (Weapon == 3) StaminaPenalty = 40;
            else throw new Exception("\n--Error!\nPlayer stamina penalty has invalid value!");
            return StaminaPenalty;
        }

        // Drink Potion
        public void DrinkPotion()
        {
            int PotionHealth = 350;
            Potions -= 1;
            if (CurrentHealth + PotionHealth >= MaxHealth) CurrentHealth = MaxHealth;
            else CurrentHealth += PotionHealth;
            Log.PlayerPotion(PotionHealth);
        }

        // Switch Weapon Mechanism
        public void SwitchWeapon()
        {
            bool selectDone = false;
            do
            {
                SwitchToLongsword();
                var userInput = Console.ReadKey().Key;
                if (userInput == ConsoleKey.Enter)
                {
                    Weapon = 1;
                    selectDone = true;
                }
                else if (userInput == ConsoleKey.DownArrow)
                {
                    bool activeArrow1 = true;
                    bool twiceNestedLoop = true;
                    do
                    {
                        SwitchToBattleAxe();
                        userInput = Console.ReadKey().Key;
                        if (userInput == ConsoleKey.Enter)
                        {
                            Weapon = 2;
                            selectDone = true;
                            break;
                        }
                        else if (userInput == ConsoleKey.UpArrow) activeArrow1 = false;
                        else if (userInput == ConsoleKey.DownArrow)
                        {
                            bool activeArrow2 = true;
                            do
                            {
                                SwitchToSpears();
                                userInput = Console.ReadKey().Key;
                                if (userInput == ConsoleKey.Enter)
                                {
                                    Weapon = 3;
                                    selectDone = true;
                                    twiceNestedLoop = false;
                                    break;
                                }
                                else if (userInput == ConsoleKey.UpArrow) activeArrow2 = false;
                            } while (activeArrow2 == true);
                        }

                    } while (activeArrow1 == true && twiceNestedLoop == true);
                }
            } while (selectDone == false);
            Log.PlayerNewWeapon(Weapon);
        }

        private void SwitchToLongsword()
        {
            XL.LongSpace();
            Console.WriteLine("\n\nChoose your weapon:" +
                "\n-->\tBastard Longsword (Standard Attack, +Defense)" +
                "\n\tSilver Battle-Axe (+Attack, -Defense)" +
                "\n\tIron Spears (Attack different location)" +
                "\n(Press Enter to choose)");
        }
        private void SwitchToBattleAxe()
        {
            XL.LongSpace();
            Console.WriteLine("\n\nChoose your weapon:" +
                "\n\tBastard Longsword (Standard Attack, +Defense)" +
                "\n-->\tSilver Battle-Axe (+Attack, -Defense)" +
                "\n\tIron Spears (Attack different location)" +
                "\n(Press Enter to choose)");
        }
        private void SwitchToSpears()
        {
            XL.LongSpace();
            Console.WriteLine("\n\nChoose your weapon:" +
                "\n\tBastard Longsword (Standard Attack, +Defense)" +
                "\n\tSilver Battle-Axe (+Attack, -Defense)" +
                "\n-->\tIron Spears (Attack different location)" +
                "\n(Press Enter to choose)");
        }

        // Switch Location Mechanism
        public void SwitchLocation()
        {
            bool selectDone = false;
            do
            {
                SwitchToRocks();
                var userInput = Console.ReadKey().Key;
                if (userInput == ConsoleKey.Enter)
                {
                    Location = 1;
                    selectDone = true;
                }
                else if (userInput == ConsoleKey.DownArrow)
                {
                    bool activeArrow1 = true;
                    bool twiceNestedLoop = true;
                    do
                    {
                        SwitchToHuts();
                        userInput = Console.ReadKey().Key;
                        if (userInput == ConsoleKey.Enter)
                        {
                            Location = 2;
                            selectDone = true;
                            break;
                        }
                        else if (userInput == ConsoleKey.UpArrow) activeArrow1 = false;
                        else if (userInput == ConsoleKey.DownArrow)
                        {
                            bool activeArrow2 = true;
                            do
                            {
                                SwitchToTrees();
                                userInput = Console.ReadKey().Key;
                                if (userInput == ConsoleKey.Enter)
                                {
                                    Location = 3;
                                    selectDone = true;
                                    twiceNestedLoop = false;
                                    break;
                                }
                                else if (userInput == ConsoleKey.UpArrow) activeArrow2 = false;
                            } while (activeArrow2 == true);
                        }

                    } while (activeArrow1 == true && twiceNestedLoop == true);
                }
            } while (selectDone == false);
            Log.PlayerNewLocation(Location);
        }

        private void SwitchToRocks()
        {
            XL.LongSpace();
            Console.WriteLine("\n\nChoose your location:" +
                "\n-->\tRocky Mountain Top (-Attack, +Defense)" +
                "\n\tAbandoned Fishing Village (+Attack, -Defense)" +
                "\n\tSmall Forest (Can't Attack, ++Defense)" +
                "\n(Press Enter to choose)");
        }
        private void SwitchToHuts()
        {
            XL.LongSpace();
            Console.WriteLine("\n\nChoose your location:" +
                "\n\tRocky Mountain Top (-Attack, +Defense)" +
                "\n-->\tAbandoned Fishing Village (+Attack, -Defense)" +
                "\n\tSmall Forest (Can't Attack, ++Defense)" +
                "\n(Press Enter to choose)");
        }
        private void SwitchToTrees()
        {
            XL.LongSpace();
            Console.WriteLine("\n\nChoose your location:" +
                "\n\tRocky Mountain Top (-Attack, +Defense)" +
                "\n\tAbandoned Fishing Village (+Attack, -Defense)" +
                "\n-->\tSmall Forest (Can't Attack, ++Defense)" +
                "\n(Press Enter to choose)");
        }

        // Rest
        public void Rest(int Turns)
        {
            int RestHP = 100;
            if (CurrentHealth + (RestHP * Turns) > MaxHealth) CurrentHealth = MaxHealth;
            else CurrentHealth += RestHP * Turns;

            int RestStamina = 30;
            if (CurrentStamina + (RestStamina * Turns) > BaseStamina) CurrentStamina = BaseStamina;
            else CurrentStamina += RestStamina * Turns;
            Log.PlayerRest(Turns, RestHP, RestStamina);
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
            Weapon, Location, Potions };
            return stats;
        }

        // Default Stats for Intro
        public string GetStats()
        {
            return "\n\n- Stats:" +
                $"\n\tHealth:         {MaxHealth}" +
                $"\n\tBase Attack:    {BaseAttack}" +
                $"\n\tBase Defense:   {BaseDefence}" +
                $"\n\tStamina:        {BaseStamina}" +
                $"\n\tHealth Potions: {Potions} (350hp)";
        }

        // Default Statistics for Intro - Initialization
        public static void BlankStats(int ChampNum)
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

    // The Individual Champion Classes with Inheritance
    class Magnus : Champion
    {
        public Magnus()
        {
            Init();
        }

        public override void Init()
        {
            CurrentHealth = 1200;
            MaxHealth = CurrentHealth;
            BaseAttack = 80;
            CurrentAttack = BaseAttack;
            BaseDefence = 120;
            CurrentDefence = BaseDefence;
            BaseStamina = 80;
            CurrentStamina = BaseStamina;
            Potions = 2;
            Weapon = 1;
            Location = 1;
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
            CurrentHealth = 900;
            MaxHealth = CurrentHealth;
            BaseAttack = 120;
            CurrentAttack = BaseAttack;
            BaseDefence = 80;
            CurrentDefence = BaseDefence;
            BaseStamina = 120;
            CurrentStamina = BaseStamina;
            Potions = 4;
            Weapon = 1;
            Location = 1;
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
            CurrentHealth = 600;
            MaxHealth = CurrentHealth;
            BaseAttack = 200;
            CurrentAttack = BaseAttack;
            BaseDefence = 40;
            CurrentDefence = BaseDefence;
            BaseStamina = 100;
            CurrentStamina = BaseStamina;
            Potions = 6;
            Weapon = 1;
            Location = 1;
        }
    }
}
