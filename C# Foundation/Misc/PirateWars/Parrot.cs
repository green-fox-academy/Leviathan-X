using System;
using System.Collections.Generic;
using System.Text;

namespace PirateWars
{
    class Parrot
    {
        Random randomValue = new Random();

        public Parrot()
        {
            Console.WriteLine("\nA drunk parrot lands on your shoulder!");
        }

        public void Blab()
        {
            int blabber = randomValue.Next(1, 5);
            switch (blabber)
            {
                case 1:
                    Console.WriteLine("Parrot: \"Ye don't know what yer doin', do ya? We're all gonna DIE!\"");
                    break;
                case 2:
                    Console.WriteLine("Parrot: \"Whhhhhat shall we do with the drunken sailor, whhhhhhat shall we do with the *HICK* sailor?\"");
                    break;
                case 3:
                    Console.WriteLine("Parrot: \"This life ain't for no stinkeeee LANDLUBBERS!\"");
                    break;
                case 4:
                    Console.WriteLine("\nYour parrot poops on your shoulder.\nParrot: \"*HICK* Whoops!\"");
                    break;
            }
        }
    }
}
