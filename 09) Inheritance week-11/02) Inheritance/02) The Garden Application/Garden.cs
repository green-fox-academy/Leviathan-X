using System;
using System.Collections.Generic;
using System.Text;

namespace _02__The_Garden_Application
{
    class Garden
    {
        private string name;
        List<Plant> plants;

        public Garden(string Name)
        {
            name = Name;
            plants = new List<Plant>();
        }
        
        public void Add(Plant plant)
        {
            plants.Add(plant);
        }
        public void StatusOfAll()
        {
            for (int i = 0; i < plants.Count; i++)
            {
                plants[i].Status();
            }
        }

        public void Watering(int waterInput)
        {
            Console.WriteLine($"\nWatering with {waterInput}");

            float waterDiv = waterInput / plants.Count;

            for (int i = 0; i < plants.Count; i++)
            {
                //plants[i].
            }
        }
    }
}
