using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class LKW : Fahrzeug
    {
        // Attribute.
        private int anzahlDerAchsen { get; set; }
        private double zuladungInTonnen { get; set; }

        // Konstruktor, aufruf des Superkunstruktors von Fahrzeug.
        public LKW(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, int parkhaus, int stellplatz, int achsen, double nutzlast)
            : base(hersteller, modell, kennzeichen, erstzulassung, preis, parkhaus, stellplatz)
        {
            this.zuladungInTonnen = nutzlast;
            this.anzahlDerAchsen = achsen;
        }

        // Methode zur Berechnung der Steuern.
        public override double berechneSteuer()
        {
            double Steuern = zuladungInTonnen * 100;
            return Steuern;
        }

        // Methode zur Ausgabe der LKWdaten.
        public override string ToString()
        {
             return "Hersteller: " + base.Herseller + ", Modell: " + base.Modell + ", Kennzeichen: " + base.Kennzeichen + ", Erstzulassung: " + base.jahrDerErstzulassung + ", Preis: " + base.Anschaffungspreis + ", Parkhaus: " + base.Parkhaus + ", Stellplatz: " + base.Stellplatz + ", Anzahl der Achsen: " + anzahlDerAchsen + ", Nutzlast in Tonnen: "  + zuladungInTonnen;
        }
    }
}
