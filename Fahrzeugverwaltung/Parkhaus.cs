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
        private List<Parkplaetze> Parkplätze { get; set; }

        public Parkhaus(string Ort, int PLZ, string Straße, int anzPKW, int anzMotorrad, int anzLKW)
        {
            this.Ort = Ort;
            this.PLZ = PLZ;
            this.Straße = Straße;

            addFahrzeugeToParkplatz(anzPKW, anzMotorrad, anzLKW);
        }

        private void addFahrzeugeToParkplatz(int anzPKW, int anzMotorrad, int anzLKW)
        {
            for (int i = 0; i < anzLKW; i++)
            {
                Parkplätze.Add(new Parkplaetze(i, 2));
            }
            for (int i = 0; i < anzMotorrad; i++)
            {
                Parkplätze.Add(new Parkplaetze(i, 1));
            }
            for (int i = 0; i < anzPKW; i++)
            {
                Parkplätze.Add(new Parkplaetze(i, 0));
            }
        }
    }
}
