using System;

namespace _04__Animals_in_the_Zoo
{
    class Zoo
    {
        static void Main(string[] args)
        {
            var reptile = new Reptile("Crocodile");
            var mammal = new Mammal("Koala");
            var bird = new Bird("Parrot");

            Console.WriteLine("\nWho wants a baby?");
            Console.WriteLine($"{reptile.GetName()} {reptile.WantChild()}");
            Console.WriteLine($"{mammal.GetName()} {mammal.WantChild()}");
            Console.WriteLine($"{bird.GetName()} {bird.WantChild()}");
        }
    }
}
