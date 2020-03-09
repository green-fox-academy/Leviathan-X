using System;
using System.Collections.Generic;
using System.Text;

namespace _03__Instruments_To_Stringed_Instruments
{
    abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings;

        public StringedInstrument()
        {
            numberOfStrings = 0;
        }

        public virtual string Sound()
        {
            string sound = "";
            return sound;
        }
    }
}
