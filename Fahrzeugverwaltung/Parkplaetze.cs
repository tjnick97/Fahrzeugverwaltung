using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class Parkplaetze
    {
        // Attribute
        private int ParkplatzID {get; set;}
        private string Parkplatztyp {get; set;}
        private string Kennzeichen{get; set;}

        // Kunstruktor
        public Parkplaetze(int parkplatzID, string parkplatztyp)
        {
            this.ParkplatzID = parkplatzID;
            this.Parkplatztyp = parkplatztyp;
        }

        // Konstruktor für die zuweisung eines Fahrzeuges für einen Stellplatz
        public Parkplaetze(string kennzeichen)
        {   
            this.Kennzeichen = kennzeichen;
        }           

    }
}
