using System;

namespace _9__Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nNapište počet čísel, a tento program najde to největší a to nejmenší z nich.\nVáš počet: ");
            int pocetCisel = Int32.Parse(Console.ReadLine());

            int[] poleCisel = new int[pocetCisel];

            for (int i = 0; i < pocetCisel; i++)
            {
                Console.Write("{0}. Číslo: ", i + 1);
                poleCisel[i] = Int32.Parse(Console.ReadLine());
            }

            int min = poleCisel[0];
            for (int i = 0; i < poleCisel.GetLength(0); i++)
            {
                if (poleCisel[i] < min)
                {
                    min = poleCisel[i];
                }
            }
            int max = poleCisel[0];
            for (int i = 0; i < poleCisel.GetLength(0); i++)
            {
                if (poleCisel[i] > max)
                {
                    max = poleCisel[i];
                }
            }

            Console.WriteLine("Nejmenší číslo je: " + min);
            Console.WriteLine("Největší číslo je: " + max);

        }
    }
}
