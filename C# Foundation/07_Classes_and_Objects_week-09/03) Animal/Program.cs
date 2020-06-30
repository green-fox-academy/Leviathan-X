using System;

namespace _03__Animal
{
    class Animal
    {
        private int hunger = 50;
        private int thirst = 50;

        public string name { get; set; }
        
        public Animal (string name)
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
    class Program
    {
        static void Main(string[] args)
        {
            Animal boris = new Animal("Boris");
            Animal dodger = new Animal("Dodger");

            boris.Eat();
            boris.Drink();
            boris.Drink();
            dodger.Play();
            boris.Drink();
            dodger.Drink();

        }
    }
}
