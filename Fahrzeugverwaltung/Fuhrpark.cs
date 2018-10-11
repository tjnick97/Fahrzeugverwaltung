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
            string line = ort + ";" + plz + ";" + straße + ";" + anzpkw + ";" + anzmotorrad + ";" + anzlkw;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Parkhaus.txt", true))
            {
                file.WriteLine(line);
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
            while ((line = Convert.ToString(file.ReadLine())) != null)
            {
                string[] splitchar = line.Split(';');
                // Ort, PLZ, Straße,  int anzPKW, int anzMotorrad, int anzLKW
                parkhaeuser.Add(new Parkhaus(splitchar[0], Convert.ToInt32(splitchar[1]), splitchar[2], Convert.ToInt32(splitchar[3]), Convert.ToInt32(splitchar[4]), Convert.ToInt32(splitchar[5])));
            }
            file.Close();

        }

        // Methode zur Erstellung neuer Fahrzeuge des Types PKW
        public void newFahrzeug(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, int hubraum, int leistung, int schadstoffklasse)
        {
            string line = hersteller + ";" + modell + ";" + kennzeichen + ";" + erstzulassung + ";" + preis + ";" + false + ";" + hubraum + ";" + leistung + ";" + schadstoffklasse;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Fahrzeuge.txt", true))
            {
                file.WriteLine(line);
            }
        }

        // Methode zur Erstellung neuer Fahrzeuge des Types LKW
        public void newFahrzeug(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, int achse, int nutzlast)
        {
            string line = hersteller + ";" + modell + ";" + kennzeichen + ";" + erstzulassung + ";" + preis + ";" + false + ";" + achse + ";" + nutzlast;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Fahrzeuge.txt", true))
            {
                file.WriteLine(line);
            }
        }

        // Methode zur Erstellung neuer Fahrzeuge des Types Motorrad
        public void newFahrzeug(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, int hubraum)
        {
            string line = hersteller + ";" + modell + ";" + kennzeichen + ";" + erstzulassung + ";" + preis + ";" + false + ";" + hubraum;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Fahrzeuge.txt", true))
            {
                file.WriteLine(line);
            }
        }

        // Methode zum Laden der gespeicherten Fahrzeuge
        public void loadFahrzeuge()
        {
            fahrzeuge.Clear();
            System.IO.StreamReader file = new System.IO.StreamReader(@"Fahrzeuge.txt", true);
            string line = "";
            while((line = Convert.ToString(file.ReadLine())) != null)
            {
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
            }
            file.Close();
        }

        // Methode für die Suche nach einem Fahrzeug
        public string sucheFahrzeug(string kennzeichen)
        {
            loadParkhaus();//init
            loadFahrzeuge();//init
            string ergebnis = "";
            string stellplatz = "";
            for(int i = 0; i < parkhaeuser.Count(); i++)
            {
                if((stellplatz = parkhaeuser[i].searchForFahrzeug(kennzeichen)) != null)
                {
                    ergebnis = "Parkhaus Nummer: " + i + " (" + parkhaeuser[i].toString() + ") " + stellplatz;
                    break;
                }
            }
            return ergebnis;
        }

        // Methode für die zu zahlende Steuer eines Fahrzeuges
        public string steuerEinzeln(string kennzeichen)
        {
            int stelle = fahrzeugstelleInListe(kennzeichen);
            return fahrzeuge[stelle].berechneSteuer();
        }
        // Methode zum durchsuchen der Fahrzeugliste mit einem Kennzeichen
        public int fahrzeugstelleInListe(string kennzeichen)
        {
            int stelle = 0;
            for(int i = 0; i < fahrzeuge.Count(); i++)
            {
                if(kennzeichen == fahrzeuge[i].kennzeichen())
                {
                    break;
                }
            }
            return stelle;
        }

        // Methode für das zuweisen eines Stellplatzes
        public void weiseStellplatzZu(string kennzeichen, int parkhaus, int stellplatz)
        {
            // Parkhaus wird intern mit 1 subtrahiert, wegen der Stelle in der Liste
            parkhaeuser[parkhaus - 1].weiseParkplatzZu(stellplatz, kennzeichen);
            return;
        }

        public List<Fahrzeug> getFahrzeuge()
        {
            loadFahrzeuge();
            return fahrzeuge;
        }

        public List<Parkhaus> getParkhaus()
        {
            loadParkhaus();
            return parkhaeuser;
        }

        public string getParkplatzParkhausForKennzeichen(string kennzeichen)
        {
            foreach(var item1 in parkhaeuser)
            {
                int count = 1;
                List<Parkplaetze> parkplaetze = item1.getParkplatz();
                foreach(var item2 in parkplaetze)
                {
                    if (kennzeichen == item2.getKennzeichen())
                    {
                        int helper = item2.getParkplatz();
                        return count.ToString() +"\t" + helper.ToString();
                    }
                }
                count++;
            }
            return "\t\t";
        }

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
