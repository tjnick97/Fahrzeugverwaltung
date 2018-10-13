using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class Motorrad : Fahrzeug
    {
        // Attribut.
        private int Hubraum { get; set; }

        // Konstruktor, aufruf des Superkunstruktors von Fahrzeug.
        public Motorrad(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, int parkhaus, int stellplatz, int hubraum)
            : base (hersteller, modell, kennzeichen, erstzulassung, preis, parkhaus, stellplatz)
        {
            this.Hubraum = hubraum;
        }

        // Methode zur Berechnung der Steuern.
        public override double berechneSteuer()
        {
            double Steuern = (Hubraum * 99) / 100 * 20;
            return Steuern;
        }

        // Methode zur Ausgabe der Motorraddaten.
        public override string ToString()
        {
            return "Hersteller: " + base.Herseller + ", Modell: " + base.Modell + ", Kennzeichen: " + base.Kennzeichen + ", Erstzulassung: " + base.jahrDerErstzulassung + ", Preis: " + base.Anschaffungspreis + ", Parkhaus: " + base.Parkhaus + ", Stellplatz: " + base.Stellplatz + ", Hubraum: " + Hubraum;
        }
    }
}
