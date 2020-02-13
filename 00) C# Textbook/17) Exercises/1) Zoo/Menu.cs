using System;
using System.Collections.Generic;
using System.Text;

namespace _1__Zoo
{
    class Menu
    {
        public Menu()
        {

        }
        public static void StartMenu()
        {
            string consent = "n";
            do
            {
                Console.Write("\n-- Main Menu --\n\t1 - Add new animal\n\t2 - See list of animals\n\t3 - Exit program\n\nYour choice: ");
                int choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    
                }
                else if (choice == 2)
                {

                }
                else if (choice == 3)
                {
                    Console.Write("\n-Exit program-\nAre you sure? (y/n): ");
                    consent = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nError!");
                }
            } while (consent == "n" || consent == "N");          
        }
    }
}
