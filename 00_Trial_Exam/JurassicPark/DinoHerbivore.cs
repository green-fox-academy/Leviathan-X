using System;
using System.Collections.Generic;
using System.Text;

namespace JurassicPark
{
    class DinoHerbivore : Dinosaur
    {
        public DinoHerbivore(string Name)
            : base(Name)
        {
            name = Name;
            race = DinoRace.Brontosaurus;
        }
    }
}
