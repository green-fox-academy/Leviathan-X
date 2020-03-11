using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Protection
{
    abstract class Animal
    {
        protected string ownerName;
        protected string name;
        protected bool isHealthy;
        protected int healCost;
        protected Random fate;

        public Animal(string OwnerName = "", string Name = "Animal")
        {
            ownerName = OwnerName;
            name = Name;
        }
        
        public virtual bool isAdpotable()
        {
            return false;
        }

        public virtual bool healthy()
        {
            return isHealthy;
        }

        public virtual int healingCost()
        {
            return healCost;
        }

        public virtual void recover()
        {
            isHealthy = true;
            Console.WriteLine($"\nAnimal {name} is healed!");
        }

        public virtual string toString()
        {
            if(isHealthy)
            {
                return $"Animal {name} is healthy and adoptable.";
            }
            else
            {
                return $"Animal {name} is not healthy ({healCost}€), and not adoptable.";
            }
        }

        public virtual string GetName()
        {
            return name;
        }
    }
}
