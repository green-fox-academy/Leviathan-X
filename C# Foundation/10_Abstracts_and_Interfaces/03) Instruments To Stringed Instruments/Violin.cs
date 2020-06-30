using System;
using System.Collections.Generic;
using System.Text;

namespace _03__Instruments_To_Stringed_Instruments
{
    class Violin : StringedInstrument
    {
        public Violin(int Strings = 4)
        {
            numberOfStrings = Strings;
        }

        public override string Sound()
        {
            string sound = "Screeeech!";
            return sound;
        }

        public override void Play()
        {
            Console.WriteLine($"\nViolin, a {numberOfStrings}-stringed instrument that does \"{Sound()}\"");
        }
    }
}
