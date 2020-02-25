using System;
using System.Collections.Generic;
using System.Text;

namespace _03__Instruments_To_Stringed_Instruments
{
    class BassGuitar : StringedInstrument
    {

        public BassGuitar(int Strings = 4)
        {
            numberOfStrings = Strings;
        }

        public override string Sound()
        {
            string sound = "Duum-duum-duum!";
            return sound;
        }

        public override void Play()
        {
            Console.WriteLine($"\nBass Guitar, a {numberOfStrings}-stringed instrument that does \"{Sound()}\"");
        }
    }
}
