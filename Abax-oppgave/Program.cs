using System;
using System.Collections.Generic;

namespace Abax_oppgave
{
     class Program
    {
        static void Main(string[] args)
        {

            List<ITransportation> transport = new List<ITransportation>();
            //CAR
            var car1 = new Car("NF123456", 147, 200, "Green", "Light Car");
            var car2 = new Car("NF654321", 150, 195, "Blue", "Light Car");
            Console.WriteLine(car1 == car2 ? "Same car" : "Not same car");

            //PLANE
            var plane1 = new Plane("LN1234", 1000, 30, 2000, 10000, true);

            //BOAT
            var boat1 = new Boat("ABC123", 100, 30, 500);

            transport.Add(car1);
            transport.Add(car2);
            transport.Add(plane1);
            transport.Add(boat1);
            foreach (var vehicles in transport)
            {
                vehicles.Print();
                BreakLine();
            }
        }

        private static void BreakLine()
        {
            Console.WriteLine("------------------------------");
        }

      

        //    Konsollprogrammet skal be flyet om å fly og printe dette i konsollet.
        //    Konsollprogrammet skal be bil 1 om å kjøre og printe dette I konsollet


      
    }
}
