using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    abstract class Fahrzeug
    {
        // Attribute
        public string Herseller {get; set;}
        public string Modell { get; set; }
        public string Kennzeichen { get; set; }
        public int jahrDerErstzulassung { get; set; }
        public double Anschaffungspreis { get; set; }
        public bool steuerBezahlt { get; set; }

        // Konstruktor
        public Fahrzeug(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, bool steuer)
        {
            this.Herseller = hersteller;
            this.jahrDerErstzulassung = erstzulassung;
            this.Modell = modell;
            this.steuerBezahlt = steuer;
            this.Kennzeichen = kennzeichen;
            this.Anschaffungspreis = preis;
        }

        // Methode zur berechnung der Steuern (wird von allen erbenden Klassen überschrieben)
        public virtual void berechneSteuer()
        {

        }

        // Methode, die die Daten eines Fahrzeuges ausgibt
        public virtual void ToString()
        {   

        }


        
    }
}
