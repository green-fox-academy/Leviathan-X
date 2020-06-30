using System;
using System.Collections.Generic;
using System.Text;

namespace _04__Animals_in_the_Zoo
{
    class Mammal : Animal
    {
        public Mammal(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return $"{Name}";
        }

        public override string WantChild()
        {
            return "wants a child from a uterus!";
        }

    }
}
