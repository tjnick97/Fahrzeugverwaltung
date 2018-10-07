using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class Parkplaetze
    {
        private int Parkplatz { get; set; }
        private int Stellplatztyp { get; set; }
        private string Kennzeichen { get; set; }
        
        public Parkplaetze(int Parkplatz, int Stellplatztyp)
        {
            this.Parkplatz = Parkplatz;
            this.Stellplatztyp = Stellplatztyp;
        }
        
        public void parkplatzZuweisen (string Kennzeichen)
        {
            this.Kennzeichen = Kennzeichen;
        }

        public void parkplatzZuweisungLöschen ()
        {
            Kennzeichen = "";
        }
        public string getKennzeichen()
        {
            return Kennzeichen;
        }
        public int getParkplatz()
        {
            return Parkplatz;
        }
    }
}
