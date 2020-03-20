using System;
using System.Collections.Generic;
using System.Text;

namespace JurassicPark
{
    public enum DinoRace
    {
        Tyranosaurus,
        Brontosaurus,
        Plesioasurus
    }

    public enum DinoDiet
    {
        carnivore,
        herbivore,
        water
    }

    abstract class Dinosaur
    {
        protected string name;
        protected DinoRace race;
        protected DinoDiet diet;
        protected int weight;

        public Dinosaur(string Name)
        {
            name = Name;
            Random roll = new Random();
            weight = roll.Next(1000, 2501);

            if (race == DinoRace.Tyranosaurus)
            {
                diet = DinoDiet.carnivore;
            }
            else if (race == DinoRace.Brontosaurus)
            {
                diet = DinoDiet.herbivore;
            }
            else if (race == DinoRace.Plesioasurus)
            {
                diet = DinoDiet.water;
            }
            else
            {
                throw new Exception("\nWhat the fuck!");
            }
        }

        public Dinosaur(string Name, int Weight)
        {
            name = Name;
            weight = Weight;

            if(race == DinoRace.Tyranosaurus)
            {
                diet = DinoDiet.carnivore;
            }
            else if(race == DinoRace.Brontosaurus)
            {
                diet = DinoDiet.herbivore;
            }
            else if(race == DinoRace.Plesioasurus)
            {
                diet = DinoDiet.water;
            }
            else
            {
                throw new Exception("\nWhat the fuck!");
            }
        }

        public DinoRace GetRace()
        {
            return race;
        }

        public int GetWeight()
        {
            return weight;
        }

        public string GetName()
        {
            return name;
        }

        public void Roar()
        {
            if (diet == DinoDiet.carnivore || diet == DinoDiet.herbivore)
            {
                Console.WriteLine($"\nThe dino {name} goes \"ROAAAAR!\"");
            }
            else if (diet == DinoDiet.water)
            {
                Console.WriteLine($"\nThe dino {name} goes \"Glo glo glo!\"");
            }
        }

        public void Pet()
        {
            if (diet == DinoDiet.water || diet == DinoDiet.herbivore)
            {
                Console.WriteLine($"\nThe dino {name} almost purrs as you try to pet him.");
            }
            else if (diet == DinoDiet.carnivore)
            {
                Console.WriteLine($"\nThe dino {name} bites your hand off as you try to pet him.");
            }
        }
    }
}
