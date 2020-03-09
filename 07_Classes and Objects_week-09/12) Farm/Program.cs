using System;

namespace _12__Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reuse your Animal class
            // Create a Farm class
            // it has list of Animals
            // it has slots which defines the number of free places for animals
            // Breed() -> creates a new animal if there's place for it
            // Slaughter() -> removes the least hungry animal

            Farm theFarm = new Farm();
            Console.WriteLine("\nWelcome to the Pig Farm!\nYou are the pig farmer, the lord of pigs and their fate.");

            Animal fatso = new Animal("Fatso");
            theFarm.Breed(fatso);
            Animal dodger = new Animal("Dodger");
            theFarm.Breed(dodger);

            Animal oinker = new Animal("Oinker");
            theFarm.Breed(oinker);

            fatso.Eat();
            dodger.Play();
            dodger.Drink();

            Animal snout = new Animal("Snout");
            theFarm.Breed(snout);

            theFarm.Slaughter();

            theFarm.Breed(snout);

        }
    }
}
