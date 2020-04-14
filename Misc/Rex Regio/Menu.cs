using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    abstract class Menu
    {
    }

    static class ChampIntroMenu
    {
        public static int Status = 0;
        public static int ChampChoice = 0;

        public static void Input()
        {
            bool selectReady = false;
            do
            {
                MagnusArrow();
                var userInput = Console.ReadKey().Key;
                if (userInput == ConsoleKey.Escape) selectReady = true;
                else if (userInput == ConsoleKey.Enter) 
                {
                    bool activeBio1 = true;
                    do
                    {
                        MagnusBio();
                        userInput = Console.ReadKey().Key;
                        if (userInput == ConsoleKey.Enter) activeBio1 = false;
                    } while (activeBio1 == true);
                }
                else if (userInput == ConsoleKey.DownArrow)
                {
                    bool activeArrow1 = true;
                    bool twiceNestedLoop = true;
                    do
                    {
                        LegibusArrow();
                        userInput = Console.ReadKey().Key;
                        if (userInput == ConsoleKey.Escape)
                        {
                            selectReady = true;
                            break;
                        }
                        else if (userInput == ConsoleKey.Enter)
                        {
                            bool activeBio2 = true;
                            do
                            {
                                LegibusBio();
                                userInput = Console.ReadKey().Key;
                                if (userInput == ConsoleKey.Enter) activeBio2 = false;
                            } while (activeBio2 == true);
                        }
                        else if (userInput == ConsoleKey.UpArrow) activeArrow1 = false;
                        else if (userInput == ConsoleKey.DownArrow)
                        {
                            bool activeArrow2 = true;
                            do
                            {
                                MysterioArrow();
                                userInput = Console.ReadKey().Key;
                                if (userInput == ConsoleKey.Escape) 
                                {
                                    selectReady = true;
                                    twiceNestedLoop = false;
                                    break;
                                } 
                                else if (userInput == ConsoleKey.Enter)
                                {
                                    bool activeBio3 = true;
                                    do
                                    {
                                        MysterioBio();
                                        userInput = Console.ReadKey().Key;
                                        if (userInput == ConsoleKey.Enter) activeBio3 = false;
                                    } while (activeBio3 == true);
                                }
                                else if (userInput == ConsoleKey.UpArrow) activeArrow2 = false;
                            } while (activeArrow2 == true);
                        }
                    } while (activeArrow1 == true && twiceNestedLoop == true);
                } 
            } while (selectReady == false);

            bool spelling = false;
            do
            {
                Console.Write("\n_Choose your champion!\n(Magnus/Legibus/Mysterio): ");
                string champName = Console.ReadLine();

                if (champName == "Magnus" || champName == "magnus")
                {
                    Console.WriteLine("\n\n-- You have chosen the Bear of the North --\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------\n");
                    spelling = true;
                    ChampChoice = 1;
                }
                else if ((champName == "Legibus") || (champName == "legibus"))
                {
                    Console.WriteLine("\n\n-- You have chosen the Viper of the West --\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------\n");
                    spelling = true;
                    ChampChoice = 2;
                }
                else if ((champName == "Mysterio") || (champName == "mysterio"))
                {
                    Console.WriteLine("\n\n-- You have chosen the Owl of the South. --\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------\n");
                    spelling = true;
                    ChampChoice = 3;
                }
                else
                {
                    Console.WriteLine("\nInvalid name!\nPlease check the spelling of your champion choice.");
                }
            } while (spelling == false);
        }

        private static void MagnusArrow()
        {
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(
                "\n--> \t-= Magnus the Wild" +
                "\n\tA burly and an experienced warrior, who came for what is rightfully his." +

                "\n\n\t-= Legibus II" +
                "\n\tAn ambitious young prince from a neighbouring kingdom, he seeks to prove " +
                "himself and to defy his father." +

                "\n\n\t-= Mysterio Dark Eyes" +
                "\n\tAn enchanter from lands unknown, carrying a strange, humming amulet. Nobody knows his true motivations." +

                "\n\n(Use Arrow Keys to move through the selection)" +
                "\n(Press Enter for details)" +
                "\n(Press Escape to choose your champion)");
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------");
            Status = 1;
        }
        private static void LegibusArrow()
        {
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(
                "\n\t-= Magnus the Wild" +
                "\n\tA burly and an experienced warrior, who came for what is rightfully his." +

                "\n\n--> \t-= Legibus II" +
                "\n\tAn ambitious young prince from a neighbouring kingdom, he seeks to prove " +
                "himself and to defy his father." +

                "\n\n\t-= Mysterio Dark Eyes" +
                "\n\tAn enchanter from lands unknown, carrying a strange, humming amulet. Nobody knows his true motivations." +

                "\n\n(Use Arrow Keys to move through the selection)" +
                "\n(Press Enter for details)" +
                "\n(Press Escape to choose your champion)");
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------");
            Status = 2;
        }
        private static void MysterioArrow()
        {
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(
                "\n\t-= Magnus the Wild" +
                "\n\tA burly and an experienced warrior, who came for what is rightfully his." +

                "\n\n\t-= Legibus II" +
                "\n\tAn ambitious young prince from a neighbouring kingdom, he seeks to prove " +
                "himself and to defy his father." +

                "\n\n--> \t-= Mysterio Dark Eyes" +
                "\n\tAn enchanter from lands unknown, carrying a strange, humming amulet. Nobody knows his true motivations." +

                "\n\n(Use Arrow Keys to move through the selection)" +
                "\n(Press Enter for details)" +
                "\n(Press Escape to choose your champion)");
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------");
            Status = 3;
        }
        private static void MagnusBio()
        {
            Console.WriteLine(
                "\n-= Magnus the Wild" +
                "\n\n- Bio: " +
                "\n\tThis mountain of flesh towers over lesser men. Whenever he enters, a smell of " +
                "blood and sweat fills the room.\n\tWith long brown hair and a braided beard, he looks around " +
                "sternly, scanning his surroundings constantly. He wears a heavily plated armor, with a manly " +
                "skirt, \n\tstains of blood decorate this angel of death. They say his clan are the descendants of " +
                "a family with a rightful claim to the throne, yet they had to unjustly \n\tflee the kingdom and hide from " +
                "persecution in the darkest woods. They say that those, who have survived the many dangers, became nothing " +
                "but feral beasts, \n\tbarely clinging onto their last shreds of humanity. The eyes of Magnus radiate " +
                "coldness, yet there are hints of sadness within. \n\tThis man has seen much, and he knows loss." +
                "\n\n- Stats:" +
                "\n\tHealth:         1.200hp" +
                "\n\tAttack:         80%" +
                "\n\tDefense:        120%" +
                "\n\tStamina:        80%" +
                "\n\tHealth Potions: 2 (350hp)" +
                "\n\n(Press Enter to continue)");
        }
        private static void LegibusBio()
        {
            Console.WriteLine(
                "\n\n-= Legibus II" +
                "\n\n- Bio: " +
                "\n\t" +
                "\n- Stats:" +
                "\nHealth:         1.000hp" +
                "\nAttack:         120%" +
                "\nDefense:        80%" +
                "\nStamina:        120%" +
                "\nHealth Potions: 4 (350hp)");
        }
        private static void MysterioBio()
        {
            Console.WriteLine(
                "\n\n-= Mysterio Dark Eyes" +
                "\n\n- Bio: " +
                "\n\t" +
                "\n-Stats:" +
                "\nHealth:         450hp" +
                "\nAttack:         200%" +
                "\nDefense:        40%" +
                "\nStamina:        100%" +
                "\nHealth Potions: 6 (350hp)");
        }
    }
}
