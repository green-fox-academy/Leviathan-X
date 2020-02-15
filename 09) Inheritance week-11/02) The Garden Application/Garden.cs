using System;
using System.Collections.Generic;
using System.Text;

namespace _02__The_Garden_Application
{
    class Garden
    {
        List<Plant> plants;

        public Garden()
        {
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

        public void Watering(int WaterInput)
        {
            Console.WriteLine($"\n\nWatering with {WaterInput}");

            float waterDiv = (float) WaterInput / plants.Count;

            for (int i = 0; i < plants.Count; i++)
            {
                if(plants[i].Fed() == false)
                {
                    plants[i].Feed(waterDiv);
                }
            }
        }

    }
}
