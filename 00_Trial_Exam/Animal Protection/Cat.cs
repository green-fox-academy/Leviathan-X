using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Protection
{
    class Cat : Animal
    {
        public Cat(string OwnerName, string Name = "Cat") 
            : base(OwnerName, Name)
        {
            ownerName = OwnerName;
            name = Name;
            healCost = fate.Next(0, 7);
        }


    }
}
