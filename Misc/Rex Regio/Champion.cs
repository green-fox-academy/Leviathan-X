using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    abstract class Champion
    {
        protected int Health;
        protected int Attack;
        protected int Defense;
        protected int Stamina;
        protected int Potions;

        public Champion()
        {

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
            Health = 800;
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
