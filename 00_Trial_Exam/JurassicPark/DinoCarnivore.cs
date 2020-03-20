using System;
using System.Collections.Generic;
using System.Text;

namespace JurassicPark
{
    class DinoCarnivore : Dinosaur
    {
        public DinoCarnivore(string Name) 
            : base(Name)
        {
            name = Name;
            race = DinoRace.Tyranosaurus;
        }
    }
}
