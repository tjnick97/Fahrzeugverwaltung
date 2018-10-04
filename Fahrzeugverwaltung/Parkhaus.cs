using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class Parkhaus
    {
        // Attribute
        private String Ort {get; set;}
        private String Straße {get; set;}
        private int PLZ {get; set;}
        private int ParkhausID {get; set;}
        private List<Parkplaetze> Parkplaetze = new List<Parkplaetze>{};
        private int anzahlDerParkplätzePKW = 500;
        private int anzahlDerParkplätzeMotorrad = 50;
        private int anzahlDerParkplätzeLKW = 25;

        // Konstruktor
        public Parkhaus(string ort, string straße, int plz, int parkhausID)
        {
            this.Ort = ort;
            this.Straße = straße;
            this.PLZ = plz;
            this.ParkhausID = parkhausID;

            // Erstellung der Parkplätze des Parkhauses
            for(int zaehler = 1; zaehler <= anzahlDerParkplätzePKW; zaehler++)
            {   
                Parkplaetze.Add(new Fahrzeugverwaltung.Parkplaetze(zaehler, "PKW"));
            }
            for(zaehler; zaehler < anzahlDerParkplätzePKW + anzahlDerParkplätzeMotorrad; zaehler++)
            {   
                Parkplaetze.Add(new Fahrzeugverwaltung.Parkplaetze(zaehler, "Motorrad"));
            }
            for(zaehler; zaehler < anzahlDerParkplätzePKW + anzahlDerParkplätzeMotorrad + anzahlDerParkplätzeLKW; zaehler++)
            {   
                Parkplaetze.Add(new Fahrzeugverwaltung.Parkplaetze(zaehler, "LKW"));
            }
        }

    }
}
