using System;

namespace _13__Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nNajít čísla dělitelná třemi v zadaném intervalu.\nDolní hranice intervalu: ");
            int dolni = Int32.Parse(Console.ReadLine());
            Console.Write("Horní hranice intervalu: ");
            int horni = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            int pocetPrvku = horni - dolni + 1;
            int[] interval = new int[pocetPrvku];

            for (int i = 0; i < pocetPrvku; i++)
            {
                interval[i] = i + dolni;
            }
            foreach (int prvek in interval)
            {
                if (prvek % 3 == 0)
                {
                    Console.WriteLine(prvek);
                }
            }

            Console.Write("\nNačtení seznamu jmen zaměstnanců firmy, poté načtení seznamu nově příchozích, dále sečtení všech dohromady.\nAktuální počet zaměstnanců: ");
            int aktualniPocet = Int32.Parse(Console.ReadLine());
            string[] aktualniZamestnanci = new string[aktualniPocet];

            for (int i = 0; i < aktualniPocet; i++)
            {
                Console.Write("{0}. zaměstnanec: ", i + 1);
                aktualniZamestnanci[i] = Console.ReadLine();
            }


            Console.Write("\nPočet nových zaměstnanců: ");
            int novyPocet = Int32.Parse(Console.ReadLine());
            string[] noviZamestnanci = new string[novyPocet];

            for (int i = 0; i < novyPocet; i++)
            {
                Console.Write("{0}. zaměstnanec: ", i + 1);
                noviZamestnanci[i] = Console.ReadLine();
            }

            string[] vsichniZamestnanci = new string[aktualniPocet + novyPocet];
            int citac = 0;

            foreach (string zamestnanec in aktualniZamestnanci)
            {
                vsichniZamestnanci[citac] = zamestnanec;
                citac++;
            }
            foreach (string zamestanec in noviZamestnanci) 
            {
                vsichniZamestnanci[citac] = zamestanec;
                citac++;
            }

            Console.WriteLine("\n-= Výpis všech zaměstnanců =-");
            foreach (string zamestnanec in vsichniZamestnanci)
            {
                Console.WriteLine(zamestnanec);
            }

        }
    }
}
