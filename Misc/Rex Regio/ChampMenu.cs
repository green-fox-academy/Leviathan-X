using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    static class ChampMenu
    {
        public static int Status = 0;
        public static int ChampChoiceOutput = 0;

        static ChampMenu()
        {
        }

        public static void Input()
        {
            Console.CursorVisible = false;
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
                        XL.LongSpace();
                        MagnusBio();
                        XL.ShortSpace();
                        userInput = Console.ReadKey().Key;
                        activeBio1 = false;
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
                                XL.LongSpace();
                                LegibusBio();
                                XL.ShortSpace();
                                userInput = Console.ReadKey().Key;
                                activeBio2 = false;
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
                                        XL.LongSpace();
                                        MysterioBio();
                                        XL.ShortSpace();
                                        userInput = Console.ReadKey().Key;
                                        activeBio3 = false;
                                    } while (activeBio3 == true);
                                }
                                else if (userInput == ConsoleKey.UpArrow) activeArrow2 = false;
                            } while (activeArrow2 == true);
                        }
                    } while (activeArrow1 == true && twiceNestedLoop == true);
                } 
            } while (selectReady == false);

            Console.CursorVisible = true;
            bool spelling = false;
            do
            {
                XL.LongSpace();
                Console.Write("\n_Choose your champion!\n(Write the name of Magnus/Legibus/Mysterio): ");
                string champName = Console.ReadLine();

                if (champName.ToLower() == "magnus")
                {
                    Console.WriteLine("\n\n-- You have chosen the Bear of the North --\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------\n");
                    spelling = true;
                    ChampChoiceOutput = 1;
                }
                else if (champName.ToLower() == "legibus")
                {
                    Console.WriteLine("\n\n-- You have chosen the Viper of the West --\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------\n");
                    spelling = true;
                    ChampChoiceOutput = 2;
                }
                else if (champName.ToLower() == "mysterio")
                {
                    Console.WriteLine("\n\n-- You have chosen the Owl of the South. --\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------\n");
                    spelling = true;
                    ChampChoiceOutput = 3;
                }
                else
                {
                    Console.WriteLine("\nInvalid name!\nPlease check the spelling of your champion choice.");
                }
            } while (spelling == false);
        }
       
        private static void MagnusArrow()
        {
            XL.LongSpace();
            Console.WriteLine("\n\t----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(
                "\n\t--> \t-= Magnus the Wild" +
                "\n\t\tA burly and an experienced warrior, who came for what is rightfully his." +

                "\n\n\t\t-= Legibus II" +
                "\n\t\tAn ambitious young prince from a neighbouring kingdom, he seeks to prove " +
                "himself and to defy his father." +

                "\n\n\t\t-= Mysterio Dark Eyes" +
                "\n\t\tAn enchanter from lands unknown, carrying a strange, humming amulet. Nobody knows his true motivations." +

                "\n\n\t(Use Arrow Keys to move through the selection)" +
                "\n\t(Press Enter for details)" +
                "\n\t(Press Escape to choose your champion)");
            Console.WriteLine("\n\t----------------------------------------------------------------------------------------------------------------");
            XL.ShortSpace();
            Status = 1;
        }

        private static void LegibusArrow()
        {
            XL.LongSpace();
            Console.WriteLine("\n\t----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(
                "\n\t\t-= Magnus the Wild" +
                "\n\t\tA burly and an experienced warrior, who came for what is rightfully his." +

                "\n\n\t--> \t-= Legibus II" +
                "\n\t\tAn ambitious young prince from a neighbouring kingdom, he seeks to prove " +
                "himself and to defy his father." +

                "\n\n\t\t-= Mysterio Dark Eyes" +
                "\n\t\tAn enchanter from lands unknown, carrying a strange, humming amulet. Nobody knows his true motivations." +

                "\n\n\t(Use Arrow Keys to move through the selection)" +
                "\n\t(Press Enter for details)" +
                "\n\t(Press Escape to choose your champion)");
            Console.WriteLine("\n\t----------------------------------------------------------------------------------------------------------------");
            XL.ShortSpace();
            Status = 2;
        }

        private static void MysterioArrow()
        {
            XL.LongSpace();
            Console.WriteLine("\n\t----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(
                "\n\t\t-= Magnus the Wild" +
                "\n\t\tA burly and an experienced warrior, who came for what is rightfully his." +

                "\n\n\t\t-= Legibus II" +
                "\n\t\tAn ambitious young prince from a neighbouring kingdom, he seeks to prove " +
                "himself and to defy his father." +

                "\n\n\t--> \t-= Mysterio Dark Eyes" +
                "\n\t\tAn enchanter from lands unknown, carrying a strange, humming amulet. Nobody knows his true motivations." +

                "\n\n\t(Use Arrow Keys to move through the selection)" +
                "\n\t(Press Enter for details)" +
                "\n\t(Press Escape to choose your champion)");
            Console.WriteLine("\n\t----------------------------------------------------------------------------------------------------------------");
            XL.ShortSpace();
            Status = 3;
        }

        private static void MagnusBio()
        {
            Console.WriteLine(
                "\n-= Magnus the Wild" +
                "\n\n- Bio: " +
                "\nThis mountain of flesh towers over lesser men. Whenever he enters, a smell of " +
                "blood and sweat fills the room.\nWith long brown hair and a braided beard, he looks around " +
                "calmly, scanning his surroundings constantly. He wears a heavily plated armor, with a manly " +
                "skirt, \nstains of blood decorate this angel of death. They say his clan are the descendants of " +
                "a family with a rightful claim to the throne, yet they had to unjustly \nflee the kingdom and hide from " +
                "persecution in the darkest woods. They say that those, who have survived the many dangers, became nothing " +
                "but feral beasts, \nbarely clinging onto their last shreds of humanity. The eyes of Magnus radiate " +
                "coldness, yet there are hints of sadness within. \nThis man has seen much, and he knows loss.");
            Champion.blankStats(1);
            Console.WriteLine("\n\n(Press any key to continue)");
        }

        private static void LegibusBio()
        {
            Console.WriteLine(
            "\n-= Legibus II" +
                "\n\n- Bio: " +
                "\nAcross the western mountains lies a kingdom that spreads far and wide. " +
                "The old king, Legibus I, is famed for his military genius and his love of further expansion. \n" +
                "Long had he wished to set his vast armies east, and now, when he can claim an entire " +
                "kingdom just by the death of one dragon, he does not hesitate. \nHe sends his most " +
                "promising son to do the deed. A slender, broad shouldered young man, with blonde hair and " +
                "a wild spark in his blue eyes. \nBut Legibus the II has other plans. He witnessed how the armies " +
                "of his father plundered and ravaged villages and cities, he has seen what his father condones. \nHe " +
                "wishes to put an end to all of this. But he can't do so alone. He needs a kingdom to have behind " +
                "his back, in order to have the slightest chance against his cruel father. \nWhen it comes to battle, " +
                "he wishes to prove he has his father's talent. But he chooses to fight for something he believes in, " +
                "no matter the slim chance. \nOtherwise, he wouldn't be able to live at all.");
            Champion.blankStats(2);
            Console.WriteLine("\n\n(Press any key to continue)");
        }

        private static void MysterioBio()
        {
            Console.WriteLine(
                "\n-= Mysterio Dark Eyes" +
                "\n\n- Bio: " +
                "\nThe south is a land of mystery and conjecture. Nobody trusts the southerners. It is the place " +
                "where Mysterio claims he comes from. \nBlack hair, shady eyes, short stubble, he doesn't like to talk much, " +
                "he'd much rather do something, as he says. He has demonstrated great feats of wizardry, \nand although some believe " +
                "that these are nothing but cheap tricks, he does inspire awe and admiration. His only true passion is knowledge, " +
                "which he is sometimes \ninclined to share with councilmen, whispering in their ear. Many would see him banished, " +
                "but it seems he holds favor amongst the most influential people in the kingdom, \nwho hold a protective hand over him, " +
                "for he is practical, and he is useful, especially to those, who know how to reward him. He wears a peculiar amulet " +
                "around his neck. \nSometimes it glows with a faint red light, and Mysterio seems to clench it with pain. Some say it is the " +
                "amulet of the Dark Gods, which was stolen from \nthe Forbidden Temple in the south a few short years ago. " +
                "Nobody knows, nobody wants to know.");
            Champion.blankStats(3);
            Console.WriteLine("\n\n(Press any key to continue)");
        }
    }
}
