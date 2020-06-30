using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    static class GameIntro
    {
        private static string Output = "";

        static GameIntro()
        {
            IntroLoading();
            IntroPic();
            IntroText();
        }

        private static void IntroLoading()
        {
            Console.WindowWidth = 140;

            Console.WriteLine(" Loading..");
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 2);
            
            for(int i = 0; i <= 100; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("█");
                }
                Console.Write(i + "/100");
                Console.SetCursorPosition(1, 2);
                System.Threading.Thread.Sleep(25);
            }

            Console.WriteLine("\n\n Press any key to continue");
            Console.ReadKey();
        }

        private static void IntroPic()
        {
            XL.LongSpace();
            XL.LongSpace();

            var pic = new[]
            {
                    @"                                                                    .:'                                  `:.   ",
                    @"                                                                   ::'                                    `::  ",
                    @"                                                                  :: :.                                  .: :: ",
                    @"                                                                   `:. `:.             .             .:'  .:'  ",
                    @"                                                                    `::. `::           !           ::' .::'    ",
                    @"                                                                        `::.`::.    .' ! `.    .::'.::'        ",
                    @"                                                                          `:.  `::::'':!:``::::'   ::'         ",
                    @"                                                                          :'*:::.  .:' ! `:.  .:::*`:          ",
                    @"                                                                         :: HHH::.   ` ! '   .::HHH ::         ",
                    @"                                                                        ::: `H TH::.  `!'  .::HT H' :::        ",
                    @"                                                                        ::..  `THHH:`:   :':HHHT'  ..::        ",
                    @"                                                                        `::      `T: `. .' :T'      ::'        ",
                    @"                                                                          `:. .   :         :   . .:'          ",
                    @"                                                                            `::'               `::'            ",
                    @"                                                                              :'  .`.  .  .'.  `:              ",
                    @"                                                                              :' ::.       .:: `:              ",
                    @"                                                                              :' `:::     :::' `:              ",
                    @"                                                                               `.  ``     ''  .'               ",
                    @"                                                                                :`...........':                ",
            };
            foreach (string line in pic)
            Console.WriteLine(line);
        }

        private static void IntroText()
        {
            Output += Environment.NewLine;
            for (int j = 0; j < 74; j++)
            {
                Output += " ";
            }
            Output += "-= Welcome to Rex Regio =-";
            Output += Environment.NewLine;
            for (int j = 0; j < 84; j++)
            {
                Output += " ";
            }
            Output += "v. 1.1";
            Output += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            for (int j = 0; j < 67; j++)
            {
                Output += " ";
            }
            Output += "(Window fullscreen is advised, press F11)" + Environment.NewLine + 
                Environment.NewLine;
        }

        public static void Begin()
        {
            Console.WriteLine(Output);
        }
    }
}