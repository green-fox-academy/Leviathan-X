using System;

namespace _07__Fleet_Of_Things
{
    class Program
    {
        static void Main(string[] args)
        {
            // - You have the `Thing` class
            // - You have the `Fleet` class
            // - You have the `FleetOfThings` class with a `Main` method
            // - Download those, use those
            // - In the Main method create a fleet
            // - Achieve this output:
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also


            Fleet pirates = new Fleet("Pirates");
            // var fleet = new Fleet();         - What's the difference, really?

            Thing num1 = new Thing("Get milk");
            pirates.Add(num1);

            Thing num2 = new Thing("Remove the obstacles");
            pirates.Add(num2);

            Thing num3 = new Thing("Stand up");
            pirates.Add(num3);

            Thing num4 = new Thing("Eat lunch");
            pirates.Add(num4);

            num3.Complete();
            num4.Complete();

            pirates.PrintThings();

        }
    }
}
