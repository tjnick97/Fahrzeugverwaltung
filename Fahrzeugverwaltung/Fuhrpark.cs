using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fahrzeugverwaltung
{
    class Fuhrpark
    {
        // Listen mit den Parkhäusern und der Fahrzeuge.
        private List<Fahrzeug> fahrzeuge = new List<Fahrzeug> { };
        private List<Parkhaus> parkhaeuser = new List<Parkhaus> { };

        // Konstruktor, der die txt Dokumente mit den vorgegebenen Anfangsdaten füllt, sollten diese noch nicht vorhanden sein.
        public Fuhrpark()
        {
            erstelleAnfangsDaten(); //-BUGGY

        }

        // Methode zum erstellen der am Anfang enthaltenen Fahrzeuge und Parkhüuser.
        private void erstelleAnfangsDaten()
        {
            if((File.Exists(@"Fahrzeuge.txt") && File.Exists(@"Parkhaus.txt")) == false)
            {
                string[] fahrzeuge = new string[4];
                fahrzeuge[0] = "VW;Käfer;K-GS-01;1965;9999;1;151;1000;30;1";
                fahrzeuge[1] = "Opel;Kadett;K-GS-02;1964;12000;1;152;1600;60;2";
                fahrzeuge[2] = "BMW;R1200r;K-GS-03;1999;6000;1;51;1170";
                fahrzeuge[3] = "Mercedes;LG 315;K-GS-04;1960;23000;1;1;2;5,5";

                

                //string[] parkhaus = new string[1];
                //parkhaus[0] = "Köln;51105;Westerwaldstr. 99;500;100;50";

                string[] parkhaus = new string[1];
                parkhaus[0] = "Köln;51105;Westerwaldstr. 99;500;100;50";
                File.WriteAllLines(@"Fahrzeuge.txt", fahrzeuge);
                //File.WriteAllLines(@"Parkhaus.txt", parkhaus); // voher war es writealltext, jetzt macht es probleme
                File.WriteAllLines(@"Parkhaus.txt", parkhaus);

                // Zuweisund der Stellplätze und des Parkhauses in den Anfangsobjekten
                loadParkhaus();
                loadFahrzeuge();
                zuweisenDerStellplätzeNachLadenAusDatei(fahrzeuge);
            }
        }
  
        // Methode, die die Stellplätze nach dem neuladen aus der txt Datei zuweisen
        public void zuweisenDerStellplätzeNachLadenAusDatei(string [] fahrzeugdaten)
        {
            foreach (string s in fahrzeugdaten)
            {
                string[] splitstring = s.Split(';');
                parkhaeuser[Convert.ToInt32(splitstring[5]) - 1].weiseParkplatzZu(Convert.ToInt32(splitstring[6]), splitstring[2]);
            }
        }
        
        public void newParkhaus(string ort, int plz, string straße, int anzpkw, int anzmotorrad, int anzlkw)
        {
            string line = ort + ";" + plz + ";" + straße + ";" + anzpkw + ";" + anzmotorrad + ";" + anzlkw;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Parkhaus.txt", true))
            {
                file.WriteLine(line);
            }
            loadParkhaus();
        }


        // Methode zum Laden der gespeicherten Parkhäuser. Laden funktioniert nicht
        public void loadParkhaus()
        {
            /*fahrzeuge.Clear();
            System.IO.StreamReader file = new System.IO.StreamReader(@"Fahrzeuge.txt", true);
            string line = "";
            while((line = Convert.ToString(file.ReadLine())) != null)
            {
            string[] splitchar = line.Split(';'); */

            //clear for init
            parkhaeuser.Clear();

            System.IO.StreamReader file = new System.IO.StreamReader(@"Parkhaus.txt", true);
            string line = "";
            while ((line = Convert.ToString(file.ReadLine())) != null)
            {
                string[] splitchar = line.Split(';');
                //string s = splitchar[0];
                //int i = Convert.ToInt32(splitchar[1]); // Außerhalb des bereiches
                // string s2 = splitchar[2]; // außerbalb des Bereiches
                //int i2 = Convert.ToInt32(splitchar[3]);// außerbalb des Bereiches
                //int i3 = Convert.ToInt32(splitchar[4]);// außerbalb des Bereiches
                // int i4 = Convert.ToInt32(splitchar[5]); // außerbalb des Bereiches
                // Ort, PLZ, Straße,  int anzPKW, int anzMotorrad, int anzLKW Aktuell ein Problem // Hat das falsche Formataußerhalb des Arraybereichens
                parkhaeuser.Add(new Parkhaus(splitchar[0], Convert.ToInt32(splitchar[1]), splitchar[2], Convert.ToInt32(splitchar[3]), Convert.ToInt32(splitchar[4]), Convert.ToInt32(splitchar[5]))); 
            }
            file.Close();
            loadFahrzeuge();
        }

        // Methode zur Erstellung neuer Fahrzeuge des Types PKW.
        public void newFahrzeug(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, int parkhaus, int stellplatz, int hubraum, int leistung, int schadstoffklasse)
        {
            string line = hersteller + ";" + modell + ";" + kennzeichen + ";" + erstzulassung + ";" + preis + ";" + parkhaus + ";" + stellplatz + ";" + hubraum + ";" + leistung + ";" + schadstoffklasse;
            // fehler wegen eienm anderen zugriff
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Fahrzeuge.txt", true))
            {
                file.WriteLine(line);
            }
            /*
            StreamWriter f = new StreamWriter(@"fahrzeuge.txt", true);
            f.WriteLine(line, true);
            f.Close();
            */
        }

        // Methode zur Erstellung neuer Fahrzeuge des Types LKW.
        public void newFahrzeug(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, int parkhaus, int stellplatz, int achse, double nutzlast)
        {
            string line = hersteller + ";" + modell + ";" + kennzeichen + ";" + erstzulassung + ";" + preis + ";" + parkhaus + ";" + stellplatz + ";" + achse + ";" + nutzlast;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Fahrzeuge.txt", true))
            {
                file.WriteLine(line);
            }
        }

        // Methode zur Erstellung neuer Fahrzeuge des Types Motorrad.
        public void newFahrzeug(string hersteller, string modell, string kennzeichen, int erstzulassung, double preis, int parkhaus, int stellplatz, int hubraum)
        {
            string line = hersteller + ";" + modell + ";" + kennzeichen + ";" + erstzulassung + ";" + preis + ";" + parkhaus + ";" + stellplatz + ";" + hubraum;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Fahrzeuge.txt", true))
            {
                file.WriteLine(line);
            }
        }

        // Methode zum Laden der gespeicherten Fahrzeuge.
        public void loadFahrzeuge()
        {
            fahrzeuge.Clear();
            System.IO.StreamReader file = new System.IO.StreamReader(@"Fahrzeuge.txt", true);
            string line = "";
            while((line = Convert.ToString(file.ReadLine())) != null)
            {
                string[] splitchar = line.Split(';');

                if (splitchar.Length == 8)
                {
                    fahrzeuge.Add(new Motorrad(splitchar[0], splitchar[1], splitchar[2], Convert.ToInt32(splitchar[3]), Convert.ToDouble(splitchar[4]), splitchar[5] != "" ? Convert.ToInt32(splitchar[5]) : Convert.ToInt32(null), splitchar[6] != "" ? Convert.ToInt32(splitchar[6]) : Convert.ToInt32(null), Convert.ToInt32(splitchar[7])));
                }
                else if (splitchar.Length == 9) 
                {
                    fahrzeuge.Add(new LKW(splitchar[0], splitchar[1], splitchar[2], Convert.ToInt32(splitchar[3]), Convert.ToDouble(splitchar[4]), splitchar[5] != "" ? Convert.ToInt32(splitchar[5]) : Convert.ToInt32(null), splitchar[6] != "" ? Convert.ToInt32(splitchar[6]) : Convert.ToInt32(null), Convert.ToInt32(splitchar[7]), Convert.ToDouble(splitchar[8])));
                }
                else if (splitchar.Length == 10)
                {
                    fahrzeuge.Add(new PKW(splitchar[0], splitchar[1], splitchar[2], Convert.ToInt32(splitchar[3]), Convert.ToDouble(splitchar[4]), splitchar[5] != "" ? Convert.ToInt32(splitchar[5]) : Convert.ToInt32(null), splitchar[6] != "" ? Convert.ToInt32(splitchar[6]) : Convert.ToInt32(null), Convert.ToInt32(splitchar[7]), Convert.ToInt32(splitchar[8]), Convert.ToInt32(splitchar[9])));
                }
                parkhaeuser[Convert.ToInt32(splitchar[5]) - 1].weiseParkplatzZu(Convert.ToInt32(splitchar[6]), splitchar[2]); // Zuweisung des Stellplatzes beim Laden des Fahrzeuges
            }
            file.Close();
        }

        // Methode für die Suche nach einem Fahrzeug.
        public string sucheFahrzeug(string kennzeichen)
        {
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

        // Methode für die zu zahlende Steuer eines Fahrzeuges.
        public double steuerEinzeln(string kennzeichen)
        {
            //int stelle = fahrzeugstelleInListe(kennzeichen);
            //return fahrzeuge[stelle].berechneSteuer();
            double steuer = 0;
            foreach(Fahrzeug f in fahrzeuge)
            {
                if(f.kennzeichen() == kennzeichen)
                {
                    steuer = f.berechneSteuer();
                }
            }
            return steuer;
        }

        // Methode zur berechnung aller Steuern für alle Fahrzeuge.
        public double steuerAlle()
        {
            double steuer = 0;
            foreach(Fahrzeug f in fahrzeuge)
            {
                steuer += f.berechneSteuer();
            }
            return steuer;
        }

        // Methode für das zuweisen eines Stellplatzes.
        public void weiseStellplatzZu(string kennzeichen, int parkhaus, int stellplatz)
        {
            // Parkhaus wird intern mit 1 subtrahiert, wegen der Stelle in der Liste.
            parkhaeuser[parkhaus-1].weiseParkplatzZu(stellplatz, kennzeichen);

            foreach (Fahrzeug f in fahrzeuge)
            {
                if (f.kennzeichen() == kennzeichen)
                {
                    f.andererStellplatz(parkhaus, stellplatz);
                    break;
                }
            }
            //HIA
            System.IO.StreamReader file = new System.IO.StreamReader(@"Fahrzeuge.txt", true);
            string line = "";
            List<string> lines = new List<string>(); 
            while ((line = Convert.ToString(file.ReadLine())) != null)
            {
                var help = line.Split(';');
                if (help[2] == kennzeichen)
                {
                    help[5] = parkhaus.ToString();
                    help[6] = stellplatz.ToString();
                    line = "";
                    for (int i = 0; i < help.Length; i++)
                    {
                        if (i != help.Length - 1)
                        {
                            line += help[i] + ";";
                        } else
                        {
                            line += help[i];
                        }
                    }
                }
                lines.Add(line);
            }
            file.Close();
            File.WriteAllLines(@"Fahrzeuge.txt", lines);
            return;
        }

        public List<Fahrzeug> getFahrzeuge()
        {
            return fahrzeuge;
        }

        public List<Parkhaus> getParkhaus()
        {
            return parkhaeuser;
        }

        // Methode 
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
    }
}
