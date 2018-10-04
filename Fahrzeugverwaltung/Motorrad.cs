using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class Motorrad : Fahrzeug
    {
        // Attribut
        private int Hubraum { get; set; }

        // Konstruktor, aufruf des Superkunstruktors von Fahrzeug
        public Motorrad(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, bool steuer, int hubraum)
            : base (hersteller, modell, kennzeichen, erstzulassung, preis, steuer)
        {
            this.Hubraum = hubraum;
        }

        // Methode zur Berechnung der Steuern
        public override void berechneSteuer()
        {
            double Steuern = (Hubraum * 99) / 100 * 20;
            Console.WriteLine("Die Steuern für das Motorrad " + base.Kennzeichen + " betragen " + Steuern + " Euro.");
        }

        // Methode zur Ausgabe der Motorraddaten
        public override void ToString()
        {
            Console.WriteLine("Hersteller: " + base.Herseller + ", Modell: " + base.Modell + ", Kennzeichen: " + base.Kennzeichen + ", Erstzulassung: " + base.jahrDerErstzulassung + ", Preis: " + base.Anschaffungspreis + ", Steuer bezahlt? " + base.steuerBezahlt + ", Hubraum: " + Hubraum);
        }
    }
}
