using System;

namespace MileToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it
            Console.Write("\nWelcome to the Mile to KM Convertor\nPlease enter the miles: ");
            double miles = Convert.ToDouble(Console.ReadLine());
            double kilometers = miles * 1.6;
            Console.WriteLine(miles + " miles is " + kilometers + " kilometers");
        }
    }
}
