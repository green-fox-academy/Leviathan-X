using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    static class Intro
    {
        private static string Output = "";

        static Intro()
        {
            IntroPic();
            IntroText();
        }

        private static void Stars(int count)
        {
            for (int i = 0; i < count; ++i)
                Output += "*";
        }

        private static void Spaces(int count)
        {
            for (int i = 0; i < count; ++i)
                Output += " ";
        }

        private static void IntroPic()
        {
            int n = 8;
            for(int i = 0; i < n; ++i)
            {
                for (int j = 0; j < 70; j++)
                {
                    Output += " ";
                }
                Stars(i + 1);
                Spaces(n - i - 1);
                Stars(n - i + 1);
                Spaces(2 * i);
                Stars(n - i);
                Spaces(n - i - 1);
                Stars(i + 1);

                Output += Environment.NewLine;
            }
        }

        private static void IntroText()
        {
            Output += Environment.NewLine;
            for (int j = 0; j < 74; j++)
            {
                Output += " ";
            }
            Output += "-= Welcome to Rex Regio =-";
            Output += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            for (int j = 0; j < 67; j++)
            {
                Output += " ";
            }
            Output += "(Window fullscreen is advised, press F11)" + Environment.NewLine + 
                Environment.NewLine + Environment.NewLine + Environment.NewLine;
        }

        public static void Begin()
        {
            Console.WriteLine(Output);
        }
    }
}
