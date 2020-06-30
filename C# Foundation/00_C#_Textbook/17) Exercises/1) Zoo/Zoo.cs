using System;
using System.Collections.Generic;
using System.Text;

namespace _1__Zoo
{
    class Zoo
    {
        List<Animal> ZooAnimals;

        public Zoo()
        {
            ZooAnimals = new List<Animal>();
        }

        public void AddAnimal(string name, int age, int weight)
        {
            Animal animal = new Animal(name, age, weight);
            ZooAnimals.Add(animal);
        }
    }
}
