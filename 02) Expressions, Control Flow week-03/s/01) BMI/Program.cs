using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the BMI calculator.");
            Console.Write("\nPlease enter your Mass in Kilograms: ");
            string stringMass = Console.ReadLine();
            double dobMass = Double.Parse(stringMass);
            Console.Write("Please enter your Height in Centimeters: ");
            string stringHeight = Console.ReadLine();
            double dobHeight = Double.Parse(stringHeight);
            dobHeight /= 100;

            double bmi = dobMass / (dobHeight * dobHeight);
            Console.WriteLine("\nYour BMI result is: " + bmi);
            
            if (bmi < 18.5)
            {
                Console.WriteLine("You need to grab a sandwich!");
            } 
            else if (bmi >= 18.5 && bmi <= 25)
            {
                Console.WriteLine("Your weight is ideal, good job!");
            } 
            else if (bmi > 25)
            {
                Console.WriteLine("You need to put down that sandwich!");
            } 
            else
            {
                Console.WriteLine("Error!");
            }


        }
    }
}
