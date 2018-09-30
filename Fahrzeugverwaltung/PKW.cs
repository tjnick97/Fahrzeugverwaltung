using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class PKW : Fahrzeug
    {
        private int Hubraum { get; set; }
        private int Leistung { get; set; }
        private int Schadstoffklasse { get; set; }

        public PKW(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, bool steuer, int hubraum, int leistung, int schadstoffklasse) 
            : base(hersteller,  modell, kennzeichen, erstzulassung, preis, steuer)
        {
            this.Hubraum = hubraum;
            this.Leistung = leistung;
            this.Schadstoffklasse = schadstoffklasse;
        } //test

        public override void berechneSteuer()
        {
            double Steuern = (Hubraum + 99) / 100 * 10 * (Schadstoffklasse + 1);
            Console.WriteLine("Die Steuern für den PKW " + base.Kennzeichen + " beträgt " + Steuern + " Euro.");
        }
    }
}
