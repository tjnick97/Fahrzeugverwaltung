using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class PKW : Fahrzeug
    {
        // Attribute.
        private int Hubraum { get; set; }
        private int Leistung { get; set; }
        private int Schadstoffklasse { get; set; }

        // Konstruktor, aufruf des Superkunstruktors von Fahrzeug.
        public PKW(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, int parkhaus, int stellplatz, int hubraum, int leistung, int schadstoffklasse) 
            : base(hersteller,  modell, kennzeichen, erstzulassung, preis, parkhaus, stellplatz)
        {
            this.Hubraum = hubraum;
            this.Leistung = leistung;
            this.Schadstoffklasse = schadstoffklasse;
        }

        // Methode zur Berechnung der Steuern.
        public override double berechneSteuer()
        {
            double Steuern = (Hubraum + 99) / 100 * 10 * (Schadstoffklasse + 1);
            return Steuern;
        }

        // Methode zur Ausgabe der PKWdaten.
        public override string ToString()
        {
             return "Hersteller: " + base.Herseller + ", Modell: " + base.Modell + ", Kennzeichen: " + base.Kennzeichen + ", Erstzulassung: " + base.jahrDerErstzulassung + ", Preis: " + base.Anschaffungspreis + ", Parkhaus: " + base.Parkhaus + ", Stellplatz: " + base.Stellplatz + ", Hubraum: " + Hubraum + ", Leistung in PS: " + Leistung + ", Schadstoffklasse: " + Schadstoffklasse;
        }
    }
}
