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

            //Opel, Kadett, K - GS - 02, 1964, 12000, 1600, 60, 2, Parkhaus 1, Stellplatz 101

            // BMW, R1200r, K-GS-03, 1999, 6000, 1170, Parkhaus 1, Stellplatz 200

            // Mercedes, LG 315, K-GS-04, 1960, 23000, 2, 5.5t, Parkhaus 1, Stellplatz 300

            // Parkhaus1 (Ort, Plz, Straße): Köln, 51105, Westerwaldstr. 99
        }

        // Methode zum Erstellen und Speichern von neuangelgegten Parkhäusern
        public void newParkhaus(string ort, int plz, string straße, int anzpkw, int anzmotorrad, int anzlkw)
        {
            //parkhaeuser.Add(new Parkhaus(ort, plz, straße, anzpkw, anzmotorrad, anzlkw));
            string line = ort + ";" + plz + ";" + straße + ";" + anzpkw + ";" + anzmotorrad + ";" + anzlkw;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Parkhaus.txt",true))
            {
                file.WriteLine(line);
                //Test
            }
        }


        // Methode zum Laden der gespeicherten Parkhäuser
        public void loadParkhaus()
        {
            //clear for init
            parkhaeuser.Clear();
            // Dateipfad noch ändern
            System.IO.StreamReader file = new System.IO.StreamReader(@"Parkhaus.txt", true);
            string line = "";
            while((line = Convert.ToString(file.ReadLine())) != null)
            {
                string[] splitchar = line.Split(';');
                // Ort, PLZ, Straße,  int anzPKW, int anzMotorrad, int anzLKW
                parkhaeuser.Add(new Parkhaus(splitchar[0], Convert.ToInt32(splitchar[1]), splitchar[2], Convert.ToInt32(splitchar[3]), Convert.ToInt32(splitchar[4]), Convert.ToInt32(splitchar[5])));
            }
            
        }

        // Methode zum Laden der gespeicherten Fahrzeuge
        /*public void loadFahrzeuge(Fuhrpark fuhrpark)
        {
            // Dateipfad noch ändern
            System.IO.StreamReader file = new System.IO.StreamReader(@"Fahrzeugverwaltung\Fahrzeugverwaltung\Daten_Fahrzeug.txt");
            string line = Convert.ToString(file.ReadLine());
            string[] splitchar = line.Split(';');

            if (splitchar.Length == 7)
            {
                fahrzeuge.Add(new Motorrad(splitchar[0], splitchar[1], splitchar[2], Convert.ToInt32(splitchar[3]), Convert.ToDouble(splitchar[4]), Convert.ToBoolean(splitchar[5]), Convert.ToInt32(splitchar[6])));
            }
            else if (splitchar.Length == 8)
            {
                 fahrzeuge.Add(new LKW(splitchar[0], splitchar[1], splitchar[2], Convert.ToInt32(splitchar[3]), Convert.ToDouble(splitchar[4]), Convert.ToBoolean(splitchar[5]), Convert.ToInt32(splitchar[6]), Convert.ToDouble(splitchar[7])));
            }
            else
            {
                fahrzeuge.Add(new PKW(splitchar[0], splitchar[1], splitchar[2], Convert.ToInt32(splitchar[3]), Convert.ToDouble(splitchar[4]), Convert.ToBoolean(splitchar[5]), Convert.ToInt32(splitchar[6]), Convert.ToInt32(splitchar[7]), Convert.ToInt32(splitchar[8])));
            }
        }*/

        // Methode für die Suche nach einem Fahrzeug
        /*public string sucheFahrzeug(string kennzeichen)
        {
            string ergebnis = "";
            foreach(Parkhaus parkhaus in parkhaeuser)
            {
                foreach(Parkplaetze parkplatz in parkhaus.)
            }
        }*/
        /*
        // Methode zur Erstellung der Parkhäuser
        private void parkhausHinzufuegen(string ort, int plz, string straße, int anzPKW, int anzMotorrad, int anzLKW)
        {
            parkhaeuser.Add(new Parkhaus(ort, plz, straße, anzPKW, anzMotorrad, anzLKW));
        }

        // Methoden zur Erstellung der Fahrzeuge
        private void fahrzeugHinzufügen(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, bool steuer, int hubraum)
        {
            fahrzeuge.Add(new Motorrad(hersteller, modell, kennzeichen, erstzulassung, preis, steuer, hubraum));
        }
        public void fahrzeugHinzufügen(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, bool steuer, int achsen, double nutzlast)
        {
            fahrzeuge.Add(new LKW(hersteller, modell, kennzeichen, erstzulassung, preis, steuer, achsen, nutzlast));
        }
        public void fahrzeugHinzufügen(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, bool steuer, int hubraum, int leistung, int schadstoffklasse)
        {
            fahrzeuge.Add(new PKW(hersteller, modell, kennzeichen, erstzulassung, preis, steuer, hubraum, leistung, schadstoffklasse));
        }*/
    }
}
