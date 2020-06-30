using System;
using System.Collections.Generic;
using System.Text;

namespace _03__Instruments_To_Stringed_Instruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(int Strings = 6)
        {
            numberOfStrings = Strings;
        }

        public override string Sound()
        {
            string sound = "Twanng!";
            return sound;
        }

        public override void Play()
        {
            Console.WriteLine($"\nElectric Guitar, a {numberOfStrings}-stringed instrument that does \"{Sound()}\"");
        }
    }
}
