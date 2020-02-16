using System;

namespace _03__Aircraft_Carrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrier carrier1 = new Carrier("Fat Boy", 2000);

            Aircraft plane1 = new Aircraft(TypeOfAircraft.F16);
            carrier1.Add(plane1);
            Aircraft plane2 = new Aircraft(TypeOfAircraft.F16);
            carrier1.Add(plane2);
            Aircraft plane3 = new Aircraft(TypeOfAircraft.F35);
            carrier1.Add(plane3);
            Aircraft plane4 = new Aircraft(TypeOfAircraft.F35);
            carrier1.Add(plane4);
            Aircraft plane5 = new Aircraft(TypeOfAircraft.F35);
            carrier1.Add(plane5);

            carrier1.GetStatus();

            Carrier carrier2 = new Carrier("Yakuza", 80000);
            Aircraft plane6 = new Aircraft(TypeOfAircraft.F16);
            carrier2.Add(plane6);

            carrier1.Fight(carrier2);

            carrier1.Fill();

            carrier1.Fight(carrier2);

            carrier2.GetStatus();

        }
    }
}
