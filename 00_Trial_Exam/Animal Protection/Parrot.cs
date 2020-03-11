using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Protection
{
    class Parrot : Animal
    {
        public Parrot(string OwnerName, string Name = "Parrot")
            : base(OwnerName, Name)
        {
            ownerName = OwnerName;
            name = Name;
            healCost = fate.Next(4, 11);
        }
    }
}
