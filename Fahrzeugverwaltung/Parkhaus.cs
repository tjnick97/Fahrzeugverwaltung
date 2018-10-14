using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class Parkhaus
    {
        // Attrubute.
        public string Ort { get; set; }
        public int PLZ { get; set; }
        public string Straße { get; set; }
        public List<Parkplaetze> parkplaetze = new List<Parkplaetze>();

        // Konstruktor.
        public Parkhaus(string Ort, int PLZ, string Straße, int anzPKW, int anzMotorrad, int anzLKW)
        {
            this.Ort = Ort;
            this.PLZ = PLZ;
            this.Straße = Straße;

            addFahrzeugeToParkplatz(anzPKW, anzMotorrad, anzLKW);
        }

        // Methode zur Erstellung der Parkplätze.
        private void addFahrzeugeToParkplatz(int anzPKW, int anzMotorrad, int anzLKW)
        {
            int helper = 0;
            for (int i = 0; i < anzLKW; i++)
            {
                parkplaetze.Add(new Parkplaetze(helper, 2)); //LKW
                helper++;
            }
            for (int i = 0; i < anzMotorrad; i++)
            {
                parkplaetze.Add(new Parkplaetze(helper, 1)); //Motorrad
                helper++;
            }
            for (int i = 0; i < anzPKW; i++)
            {
                parkplaetze.Add(new Parkplaetze(helper, 0)); //PKW
                helper++;
            }
        }

        // Methode zur Suche nach einem Fahrzeug in dem Parkhaus.
        public string searchForFahrzeug(string kennzeichen)
        {
            string result = null;
            foreach(Parkplaetze parkplatz in parkplaetze)
            {
                if(kennzeichen == parkplatz.getKennzeichen())
                {
                    result = parkplatz.getParkplatz().ToString();
                    break;
                }
            }
            return result;
        }

        // Ausgabe der Parkhausdaten.
        public string toString()
        {
            return Straße + ", " + PLZ + " " + Ort;
        }

        // Methode zur zuweisung eines Parkplatzes.
        public void weiseParkplatzZu(int parkplatznummer, string kennzeichen)
        {
            parkplaetze[parkplatznummer-1].parkplatzZuweisen(kennzeichen);
            return;
        }

        public List<Parkplaetze> getParkplatz ()
        {
            return parkplaetze;
        }
    }
}
