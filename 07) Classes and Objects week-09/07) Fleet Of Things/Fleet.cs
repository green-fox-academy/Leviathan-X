using System;
using System.Collections.Generic;
using System.Text;

namespace _07__Fleet_Of_Things
{
    class Fleet
    {
        private List<Thing> things;
        private string name;

        public Fleet(string name)
        {
            things = new List<Thing>();
            this.name = name;
            Console.WriteLine($"\nArr! There's a new fleet of {name} over the horizon!");
        }

        public void Add(Thing thing)
        {
            things.Add(thing);
        }

        public void PrintThings()
        {
            Console.WriteLine($"\nHere's all the things that {name} have to do!");
            for (int i = 0; i < things.Count; i++)
            {
                Console.WriteLine($"{i + 1}. [] {things[i].ToString()}");
            }
        }
    }
}
