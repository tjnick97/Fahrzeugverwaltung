using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    abstract class Fahrzeug
    {
        public string Herseller {get; set;}
        public string Modell { get; set; }
        public string Kennzeichen { get; set; }
        public int jahrDerErstzulassung { get; set; }
        public double Anschaffungspreis { get; set; }
        public bool steuerBezahlt { get; set; }

        public Fahrzeug(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, bool steuer)
        {
            this.Herseller = hersteller;
            this.jahrDerErstzulassung = erstzulassung;
            this.Modell = modell;
            this.steuerBezahlt = steuer;
            this.Kennzeichen = kennzeichen;
            this.Anschaffungspreis = preis;
        }

        public virtual void berechneSteuer()
        {

        }


        
    }
}
