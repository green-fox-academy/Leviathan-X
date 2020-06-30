using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Protection
{
    class Dog : Animal
    {
        public Dog(string OwnerName, string Name = "Dog")
            : base(OwnerName, Name)
        {
            ownerName = OwnerName;
            name = Name;
            healCost = fate.Next(1, 8);
        }
    }
}
