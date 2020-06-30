using System;

namespace _10__PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Station and Car classes
            // Station
            //    GasAmount
            //    Refill(car)->decreases the gasAmount by the capacity of the car and increases the cars gasAmount
            // Car
            //    GasAmount
            //    Capacity
            //    create constructor for Car where:
            //        initialize gasAmount-> 0
            //        initialize capacity-> 100

            Station Shell = new Station();
            Car Tatra = new Car(50, 1200);

            Shell.Refill(Tatra);

        }
    }
}
