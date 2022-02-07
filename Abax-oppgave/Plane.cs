using System;

namespace Abax_oppgave 
{
    internal class Plane : ITransportation
    {
        public string Regnr { get; set; }
        public int Effect { get; set; }
        public int Maxspeed { get; set; }
        public string Color { get; set; }
        public int Wingspan;
        public int Loadcapacity;
        public int Deadweight;
        public bool JetplaneOrNot;


        public Plane(string regnr, int effect, int wingspan, int loadingcapacity, int deadweight, bool jetplaneornot)
        {
            Regnr = regnr;
            Effect = effect;
            Wingspan = wingspan;
            Loadcapacity = loadingcapacity;
            Deadweight = deadweight;
            JetplaneOrNot = jetplaneornot;
        }

      

        public void Print()
        {

            Console.WriteLine($"Regnr: {Regnr}");
            Console.WriteLine($"Effect: {Effect} Kw");
            Console.WriteLine($"Wingspan: {Wingspan} Meter");
            Console.WriteLine($"Loadcapacity: {Loadcapacity} Kg");
            Console.WriteLine($"Deadweight: {Deadweight} Kg");
            Console.WriteLine($"JetplaneOrNot: {JetplaneOrNot}");

        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
