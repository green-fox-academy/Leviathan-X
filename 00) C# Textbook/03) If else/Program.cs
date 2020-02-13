using System;

namespace _3__If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte svůj věk: ");
            int vek = Int32.Parse(Console.ReadLine());

            if (vek >= 18)
            {
                Console.WriteLine("Jste dospělí." + "\n");
            }


            Console.WriteLine("Kolik máte u sebe peněz: ");
            int penize = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Kolik stojí vaše oblíbená pizza: ");
            int pizza = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Má pizzerie otevřeno (ano/ne): ");
            string pizzerie = Console.ReadLine();

            if ((penize >= pizza) && (pizzerie == "ano"))
            {
                Console.WriteLine("Skvělé! Můžete si objednat svoji oblíbenou pizzu!" + "\n");
            } else
            {
                Console.WriteLine("Bohužel si nemůžete vaši pizzu objednat." + "\n");
            }


            Console.WriteLine("Kolik znáte cizích jazyků? ");
            int jazyky = Int32.Parse(Console.ReadLine());

            if (jazyky == 0)
            {
                Console.WriteLine("To je škoda. Je dobré umět aspoň jeden.");
            } else if (jazyky == 1)
            {
                Console.WriteLine("To není špatné! Ale nebylo by od věci se naučit ještě jeden.");
            } else if (jazyky == 2)
            {
                Console.WriteLine("Velmi dobře!");
            } else if (jazyky == 3 || jazyky == 4)
            {
                Console.WriteLine("Wow!");
            } else if (jazyky >= 5)
            {
                Console.WriteLine("Holy shit!");
            } else
            {
                Console.WriteLine("To je nějaké divné, hele.");
            }

        }
    }
}
