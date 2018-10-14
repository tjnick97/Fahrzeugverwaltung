using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    abstract class Fahrzeug
    {
        // Attribute.
        public string Herseller {get; set;}
        public string Modell { get; set; }
        public string Kennzeichen { get; set; }
        public int jahrDerErstzulassung { get; set; }
        public double Anschaffungspreis { get; set; }
        // public bool steuerBezahlt { get; set; } //WEG
        public int Parkhaus { get; set; } //HINZU
        public int Stellplatz { get; set; } //HINZU

        // Konstruktor.
        public Fahrzeug(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, int parkhaus, int stellplatz)
        {
            this.Herseller = hersteller;
            this.jahrDerErstzulassung = erstzulassung;
            this.Modell = modell;
            this.Parkhaus = parkhaus;
            this.Stellplatz = stellplatz;
            this.Kennzeichen = kennzeichen;
            this.Anschaffungspreis = preis;
        }

        // Methode zur berechnung der Steuern (wird von allen erbenden Klassen überschrieben).
        public virtual double berechneSteuer()
        {
            return 0;
        }

        // Methode, die die Daten eines Fahrzeuges ausgibt.
        public virtual string ToString()
        {
            return "";
        }

        // Methode zur Rückgabe des Kennzeichens.
        public string kennzeichen()
        {
            return Kennzeichen;
        }

        // Methode zurÄnderung des Stellplatzes
        public void andererStellplatz(int parkhaus, int stellplatz)
        {
            this.Parkhaus = parkhaus;
            this.Stellplatz = stellplatz;
        }

        
    }
}
