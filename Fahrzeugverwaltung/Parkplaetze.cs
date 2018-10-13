using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class Parkplaetze
    {
        // Attribute.
        public int Parkplatz { get; set; }
        public int Stellplatztyp { get; set; }
        public string Kennzeichen { get; set; }
        
        // Konstruktor.
        public Parkplaetze(int Parkplatz, int Stellplatztyp)
        {
            this.Parkplatz = Parkplatz;
            this.Stellplatztyp = Stellplatztyp;
        }
        
        // Methode zur zuweisung eines Fahrzeuges zu dem Stellplatz.
        public void parkplatzZuweisen (string Kennzeichen)
        {
            this.Kennzeichen = Kennzeichen;
        }

        // Methode zur entfernung des aktuellen Fahrzeuges von dem Stellplatz.
        public void parkplatzZuweisungLöschen ()
        {
            Kennzeichen = "";
        }
        // Methode, die das Kennzeichen des Fahrzeuges, das diesen Stellplatz zugewiesen bekommen hat, zurückgibt.
        public string getKennzeichen()
        {
            return Kennzeichen;
        }
        // Rückgabe der Stellplatznummer.
        public int getParkplatz()
        {
            return Parkplatz;
        }
    }
}
