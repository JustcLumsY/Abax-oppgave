
using System;

namespace Abax_oppgave
{
    internal interface ITransportation
    {
        string Regnr { get; set; }
        int Effect { get; set; }
        int Maxspeed { get; set; }
        string Color { get; set; }

        void Print();

    }
}
