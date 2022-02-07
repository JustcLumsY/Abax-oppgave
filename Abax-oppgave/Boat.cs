using System;

namespace Abax_oppgave
{
    internal class Boat : ITransportation
    {
        public string Regnr { get; set; }
        public int Effect { get; set; }
        public int Maxspeed { get; set; }
        public string Color { get; set; }
        public int Grosstonnage;

        public Boat(string regnr, int effect, int maxspeed, int grosstonnage)
        {
            Regnr = regnr;
            Effect = effect;
            Maxspeed = maxspeed;
            Grosstonnage = grosstonnage;
        }

    

        public void Print()
        {
            Console.WriteLine($"Regnr: {Regnr}");
            Console.WriteLine($"Effect: {Effect} Kw");
            Console.WriteLine($"Maxspeed: {Maxspeed} Km/t");
            Console.WriteLine($"Grosstonnage: {Grosstonnage} Kg");
        }
    }
}
