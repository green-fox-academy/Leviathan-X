using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _12__Farm
{
    class Farm
    {
        List<Animal> AnimalsList;
        int Freespace = 3;

        public Farm()
        {
            AnimalsList = new List<Animal>();
        }
        
        public void Breed(Animal animal)
        {
            if (AnimalsList.Count < Freespace)
            {
            AnimalsList.Add(animal);
            Console.WriteLine($"\nNew animal added to the farm - {animal.name}.");
            } 
            else
            {
                Console.WriteLine($"\nThere's no more space to breed! The new piggo {animal.name} can't stay!");
            }
        }
        public void Slaughter()
        {
            // IMPORTANT: How to sort list of objects by a property (LINQ needed)

            List<Animal> newList = AnimalsList.OrderBy(x => x.Hunger).ToList();

            for (int i = 0; i < AnimalsList.Count; i++)
            {
                if (AnimalsList[i] == newList[0])
                {
                Console.WriteLine($"\nThe least hungry animal slaughtered - {AnimalsList[i].name}. Rest in pieces.");
                AnimalsList.RemoveAt(i); 
                }
            }
        }
    }
}
