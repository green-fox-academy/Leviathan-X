using System;
using System.Collections.Generic;

namespace _06__Reservations
{
    class Program
    {
        static void Main(string[] args)
        {
            // int i = 90;
            // char y = Convert.ToChar(i);

            // Console.WriteLine(y);

            Console.WriteLine("\nList of new Reservations:\n");
            List<Reservation> reservationSpam = new List<Reservation>();

            for (int i = 0; i < 10; i++)
            {
                reservationSpam.Add(new Reservation());
            }

            foreach (var res in reservationSpam)
            {
                Console.WriteLine($"Booking #{res.GetCodeBooking()} for {res.GetDowBooking()}");
            }

        }
    }
}
