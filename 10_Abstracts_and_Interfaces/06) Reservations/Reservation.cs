using System;
using System.Collections.Generic;
using System.Text;

namespace _06__Reservations
{
    class Reservation : IReservationy
    {
        private string CodeBooking;
        private string DowBooking;

        public Reservation()
        {
            CodeBooking = RandomCode();
            DowBooking = RandomDay();
        }

        private string RandomCode()
        {
            List<char> codeLetters = new List<char>();
            string finalCode = "";

            for (int i = 48; i < 58; i++)
            {
                codeLetters.Add(Convert.ToChar(i));
            }

            for (int i = 65; i < 91; i++)
            {
                codeLetters.Add(Convert.ToChar(i));
            }

            for (int i = 0; i < 8; i++)
            {
                finalCode += codeLetters[new Random().Next(codeLetters.Count)];
            }

            return finalCode;
        }

        private string RandomDay()
        {
            List<string> weekDays = new List<string>() { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };
            return weekDays[new Random().Next(weekDays.Count)];
        }


        public string GetCodeBooking()
        {
            return CodeBooking;
        }

        public string GetDowBooking()
        {
            return DowBooking;
        }
    }
}
