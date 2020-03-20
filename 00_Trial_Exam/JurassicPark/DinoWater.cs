using System;
using System.Collections.Generic;
using System.Text;

namespace JurassicPark
{
    class DinoWater : Dinosaur
    {
        public DinoWater(string Name)
            : base(Name)
        {
            name = Name;
            race = DinoRace.Plesioasurus;
        }
    }
}
