using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    class Dragon
    {
        private int Health;
        private int Attack;
        private int Defense;
        private int Stamina;
        private int Anger;
        private string Stance;
        private string Location;

        public Dragon()
        {
            Health = 2500;
            Attack = 140;
            Defense = 140;
            Stamina = 150;
            Anger = 0;
        }

        public void ChangeLocation(string Input)
        {
            Location = Input;
        }
    }
}
