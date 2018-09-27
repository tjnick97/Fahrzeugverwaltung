using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class LKW : Fahrzeug
    {
        private int anzahlDerAchsen { get; set; }
        private double zuladungInTonnen { get; set; }

        public LKW(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, bool steuer, int achsen, double nutzlast)
            : base(hersteller, modell, kennzeichen, erstzulassung, preis, steuer)
        {
            this.zuladungInTonnen = nutzlast;
            this.anzahlDerAchsen = achsen;
        }

        public override void berechneSteuer()
        {
            double Steuern = zuladungInTonnen * 100;
            Console.WriteLine("Die Steuern für den LKW " + base.Kennzeichen + " betragen " + Steuern + " Euro.");
        }
    }
}
