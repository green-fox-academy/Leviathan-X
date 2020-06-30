using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Protection
{
    class AnimalShelter
    {
        private List<Animal> animals;
        private List<string> adoptersName;
        private Random fate;
        private int budget;

        public AnimalShelter()
        {
            budget = 50;
        }

        public int Rescue(Animal animal)
        {
            animals.Add(animal);
            return animals.Count;
        }

        public int Heal()
        {
            int success = 0;
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].healthy() == false)
                {
                    if (budget >= animals[i].healingCost())
                    {
                        budget -= animals[i].healingCost();
                        animals[i].recover();
                        success = 1;
                    }
                    break;
                }
            }
            return success;
        }

        public void AddAdopter(string AdopterName)
        {
            adoptersName.Add(AdopterName);
        }

        public void FindNewOwner()
        {   
            foreach (var animal in animals)
            {
                if (animal.healthy())
                {
                    animals.Remove(animal);
                    adoptersName.RemoveAt(fate.Next(1, adoptersName.Count + 1));
                }
                break;
            }
        }

        public string EarnDonation(int amount)
        {
            budget += amount;
            return budget.ToString();
        }

        public void ToString()
        {
            Console.WriteLine($"\nBudget: {budget}€," +
                $"There are {animals.Count} animal(s) and {adoptersName.Count} potential adopter(s).");
            foreach (var animal in animals)
            {
                if (animal.healthy()) 
                    Console.WriteLine($"Animal {animal.GetName()} is healthy and adoptable.");
                else Console.WriteLine($"Animal {animal.GetName()} is not healthy" +
                    $"(Healing cost: {animal.healingCost()}€) and not adoptable.");
            }
        }
    }
}
