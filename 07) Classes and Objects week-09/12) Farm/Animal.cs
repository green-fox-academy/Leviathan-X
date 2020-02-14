using System;
using System.Collections.Generic;
using System.Text;

namespace _12__Farm
{
    class Animal
    {
        public int hunger = 50; 
        private int thirst = 50;
        public int Hunger
        {
            get { return hunger; }
            private set { }
        }

        public string name { get; set; }

        public Animal(string name)
        {
            this.name = name;
            Console.WriteLine($"\nName: {name}\nHunger = {hunger}\nThirst = {thirst}");

        }

        public void Eat()
        {
            hunger -= 10;
            Console.WriteLine($"\n{name} takes a bite.\nNew Hunger = {hunger}\nThirst = {thirst}");
        }
        public void Drink()
        {
            thirst -= 10;
            Console.WriteLine($"\n{name} takes a sip.\nHunger = {hunger}\nNew Thirst = {thirst}");
        }
        public void Play()
        {
            hunger += 10;
            thirst += 10;
            Console.WriteLine($"\n{name} plays a silly game.\nNew Hunger = {hunger}\nNew Thirst = {thirst}");
        }
    }
}
