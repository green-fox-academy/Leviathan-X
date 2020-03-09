using System;
using System.Collections.Generic;
using System.Text;

namespace _1__Zoo
{
    class Animal
    {
        string Name;
        int Weight;
        int Age;

        public Animal(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public void AnimalStats()
        {
            Console.WriteLine($"\nName: {Name}\nAge: {Age}\nWeight: {Weight}");
        }
    }
}
