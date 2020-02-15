using System;

namespace _02__The_Garden_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden theGarden = new Garden("theGarden");
            
            Flower Fyellow = new Flower("yellow");
            theGarden.Add(Fyellow);
            Flower Fblue = new Flower("blue");
            theGarden.Add(Fblue);

            Tree Tpurple = new Tree("purple");
            theGarden.Add(Tpurple);
            Tree Torange = new Tree("orange");
            theGarden.Add(Torange);

            theGarden.StatusOfAll();
            
            theGarden.Watering(40);
            theGarden.StatusOfAll();

            theGarden.Watering(70);
            theGarden.StatusOfAll();

            Console.WriteLine("\nNazdar Dáňo");

        }
    }
}
