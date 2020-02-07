using System;
using System.Collections.Generic;
using System.Text;

namespace _10__PetrolStation
{
    class Station
    {
        private int GasAmount = 1000;

        public Station()
        {

        }

        public void Refill(Car car)
        {
            for (int i = 0; i < car.Capacity; i += 10)
            {
                car.GasAmount += 10;
                GasAmount -= 10;
                if(GasAmount == 0)
                {
                    Console.WriteLine("\nThe Station ran out of gas supply!");
                    Console.WriteLine($"\nStation Gas Amount remaining: {GasAmount}\nCar Capacity: {car.Capacity}\nCar Gas Amount: {car.GasAmount}");
                    break;
                }
                if (car.GasAmount == car.Capacity)
                {
                    Console.WriteLine("\nThe Station is done pumping gas, the capacity is full!");
                    Console.WriteLine($"\nStation Gas Amount remaining: {GasAmount}\nCar Capacity: {car.Capacity}\nCar Gas Amount: {car.GasAmount}");
                }
            }
        }

    }
}
