using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class Parkhaus
    {
        private string Ort { get; set; }
        private int PLZ { get; set; }
        private string Straße { get; set; }
        List<Parkplaetze> parkplaetze = new List<Parkplaetze>();

        public Parkhaus(string Ort, int PLZ, string Straße, int anzPKW, int anzMotorrad, int anzLKW)
        {
            this.Ort = Ort;
            this.PLZ = PLZ;
            this.Straße = Straße;

            addFahrzeugeToParkplatz(anzPKW, anzMotorrad, anzLKW);
        }

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

        public string searchForFahrzeug(string kennzeichen)
        {
            string result = null;
            foreach(Parkplaetze parkplatz in parkplaetze)
            {
                if(kennzeichen == parkplatz.getKennzeichen())
                {
                    result = "Parkplatz Nummer: " + parkplatz.getParkplatz();
                    break;
                }
            }
            return result;
        }

        public string toString()
        {
            return Straße + ", " + PLZ + " " + Ort;
        }

        public void weiseParkplatzZu(int parkplatznummer, string kennzeichen)
        {
            // Die Parkplatznummer wird interm mit 1 subtrahiert, wegen der position in der Liste
            parkplaetze[parkplatznummer - 1].parkplatzZuweisen(kennzeichen);
            return;
        }

        public List<Parkplaetze> getParkplatz ()
        {
            return parkplaetze;
        }
    }
}
