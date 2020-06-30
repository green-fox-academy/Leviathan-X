using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JurassicPark
{
    class JurassicPark
    {
        private bool parkOpen;
        private List<Dinosaur> dinosaurs;

        public void GetSpecies()
        {
            string species = "\nThe Jurassic Park contains races of: ";

            foreach (var dino in dinosaurs)
            {
                if (dino.GetRace() == DinoRace.Tyranosaurus)
                {
                    species += "[Tyranosaurus] ";
                }
                else if (dino.GetRace() == DinoRace.Brontosaurus)
                {
                    species += "[Brontosaurus] ";
                }
                else if (dino.GetRace() == DinoRace.Plesioasurus)
                {
                    species += "[Plesiosaurus]";
                }
            }
        }

        public void Visit()
        {
            if (parkOpen)
            {
                int numOfTyran = 0;
                int numOfBronto = 0;
                int numOfPlesio = 0;

                foreach (var dino in dinosaurs)
                {
                    if (dino.GetRace() == DinoRace.Tyranosaurus)
                    {
                        numOfTyran++;
                    }
                    else if (dino.GetRace() == DinoRace.Brontosaurus)
                    {
                        numOfBronto++;
                    }
                    else if (dino.GetRace() == DinoRace.Plesioasurus)
                    {
                        numOfPlesio++;
                    }
                }

                Console.WriteLine($"\n--Number of Dinosaurs in the Park:" +
                    $"\nTyranosaurus: {numOfTyran}\nBrontosaurus: {numOfBronto}" +
                    $"\nPlesiosaurus: {numOfPlesio}");
            }
            else 
            {
                Console.WriteLine("\nThe Park is closed.");
            }
        }

        public void Statistics()
        {
            var sortedDinos = dinosaurs.OrderBy(x => x.GetRace().ToString()).ThenBy(y => y.GetWeight());

            Console.WriteLine("\n-- Jurassic Park Statistics --" +
                "\n\nSorted by name, then by weight:");
            foreach (var dino in sortedDinos)
            {
                Console.WriteLine($"[{dino.GetRace()} {dino.GetName()}] Weight: {dino.GetWeight()}kg.");
            }
        }

        public void Adopt(Dinosaur dino)
        {
            dinosaurs.Add(dino);
            Console.WriteLine($"\n{dino.GetRace()} {dino.GetName()} has been added to the Park.");
        }

        public void Deport(string Name)
        {
            foreach (var dino in dinosaurs)
            {
                if(Name == dino.GetName())
                {
                    dinosaurs.Remove(dino);
                    Console.WriteLine($"\n{dino.GetRace()} {dino.GetName()} has been deported back to Mexico.");
                }
            }
        }
    }
}
