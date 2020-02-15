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

        public void Watering(int waterInput)
        {
            float waterDiv = waterInput / plants.Count;
            
            if ()
        }
    }
}
