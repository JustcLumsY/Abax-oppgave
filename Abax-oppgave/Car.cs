using System;

namespace Abax_oppgave
{
    public class Car : ITransportation
    {
        public string Regnr { get; set; }
        public int Effect { get; set; }
        public int Maxspeed { get; set; }

        public string Color { get; set; }

        public string LightOrHeavyCar;
        public Car(string regnr, int effect, int maxspeed, string color, string lightorheavycar)
        {
            Regnr = regnr;
            Effect = effect;
            Maxspeed = maxspeed;
            Color = color;
            LightOrHeavyCar = lightorheavycar;
        }

   

        public void Print()
        {
            Console.WriteLine($"Regnr: {Regnr}");
            Console.WriteLine($"Effect: {Effect} Kw");
            Console.WriteLine($"Maxspeed: {Maxspeed} Km/t");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"LightOrHeavyCar: {LightOrHeavyCar}");
        }

        //public void CheckCars()
        //{
            
        //    Console.WriteLine(Program.car1 == car2 ? "Same car" : "Not same car");
        //}
    }
}