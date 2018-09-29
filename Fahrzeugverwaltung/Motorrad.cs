using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class Motorrad : Fahrzeug
    {
        private int Hubraum { get; set; } 

        public Motorrad(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, bool steuer, int hubraum)
            : base (hersteller, modell, kennzeichen, erstzulassung, preis, steuer)
        {
            this.Hubraum = hubraum;
        }

        public override void berechneSteuer()
        {
            double Steuern = (Hubraum * 99) / 100 * 20;
            Console.WriteLine("Die Steuern für das Motorrad " + base.Kennzeichen + " betragen " + Steuern + " Euro.");
        }
    }
}
