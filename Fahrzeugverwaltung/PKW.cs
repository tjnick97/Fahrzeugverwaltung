using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class PKW : Fahrzeug
    {
        // Attribute
        private int Hubraum { get; set; }
        private int Leistung { get; set; }
        private int Schadstoffklasse { get; set; }

        // Konstruktor, aufruf des Superkunstruktors von Fahrzeug
        public PKW(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, bool steuer, int hubraum, int leistung, int schadstoffklasse) 
            : base(hersteller,  modell, kennzeichen, erstzulassung, preis, steuer)
        {
            this.Hubraum = hubraum;
            this.Leistung = leistung;
            this.Schadstoffklasse = schadstoffklasse;
        }

        // Methode zur Berechnung der Steuern
        public override void berechneSteuer()
        {
            double Steuern = (Hubraum + 99) / 100 * 10 * (Schadstoffklasse + 1);
            Console.WriteLine("Die Steuern für den PKW " + base.Kennzeichen + " beträgt " + Steuern + " Euro.");
        }

        // Methode zur Ausgabe der PKWdaten
        public override void ToString()
        {
             Console.WriteLine("Hersteller: " + base.Herseller + ", Modell: " + base.Modell + ", Kennzeichen: " + base.Kennzeichen + ", Erstzulassung: " + base.jahrDerErstzulassung + ", Preis: " + base.Anschaffungspreis + ", Steuer bezahlt? " + base.steuerBezahlt + ", Hubraum: " + Hubraum + ", Leistung in PS: " + Leistung + ", Schadstoffklasse: " + Schadstoffklasse);
        }
    }
}
