using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class Fuhrpark
    {
        private List<Fahrzeug> fahrzeuge = new List<Fahrzeug> { };
        private List<Parkhaus> parkhaeuser = new List<Parkhaus> { };

        public Fuhrpark()
        {
            //VW, Käfer, K - GS - 01, 1965, 9999, 1000, 30, 1 , Parkhaus 1, Stellplatz 100
            fahrzeuge.Add(new PKW("VW", "Käfer", "K - GS - 01", 1965, 9999, false, 1000, 30, 1));

            //Opel, Kadett, K - GS - 02, 1964, 12000, 1600, 60, 2, Parkhaus 1, Stellplatz 101
            fahrzeuge.Add(new PKW("Opel", "Kadett", "K - GS 02", 1964, 12000, false, 1600, 60, 2));

            // BMW, R1200r, K-GS-03, 1999, 6000, 1170, Parkhaus 1, Stellplatz 200

            // Mercedes, LG 315, K-GS-04, 1960, 23000, 2, 5.5t, Parkhaus 1, Stellplatz 300

            // Parkhaus1 (Ort, Plz, Straße): Köln, 51105, Westerwaldstr. 99
        }

        public void parkhausHinzufuegen(string ort, int plz, string straße, int anzPKW, int anzMotorrad, int anzLKW)
        {
            parkhaeuser.Add(new Parkhaus(ort, plz, straße, anzPKW, anzMotorrad, anzLKW));
        }
    }
}
