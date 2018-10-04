using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrzeugverwaltung
{
    public partial class Fahrzeugverwaltung : Form
    {
        public Fahrzeugverwaltung()
        {
            InitializeComponent();
            clearWindow();
        }

        private void clearWindow()
        {
            //Clear all elements in curretn window
            pFahrzeugSuchen.Hide();
            pFahrzeugHinzufügen.Hide();
            pParkhausHinzufügen.Hide();
        }

        private void FahrzeugartenAusgeben_Click(object sender, EventArgs e)
        {
            clearWindow();
        }

        private void ParkhausHinzufügen_Click(object sender, EventArgs e)
        {
            clearWindow();
            pParkhausHinzufügen.Show();
        }

        private void fahrzeugHinzufügen_Click(object sender, EventArgs e)
        {
            clearWindow();
            pFahrzeugHinzufügen.Show();
        }

        private void fahrzeugSuchen_Click(object sender, EventArgs e)
        {
            clearWindow();
            pFahrzeugSuchen.Show();
        }

        private void ÜberprüfeSteuerlast_Click(object sender, EventArgs e)
        {

        }

        private void ShowFahrzeugTypPanel(object sender, EventArgs e)
        {
            if (cBFahrzeugTyp.Text == "PKW")
            {
                PPKW.Show();
                pMotorrad.Hide();
                pLKW.Hide();
            }
            else if (cBFahrzeugTyp.Text == "Motorrad")
            {
                PPKW.Hide();
                pMotorrad.Show();
                pLKW.Hide();
            }
            else if (cBFahrzeugTyp.Text == "LKW")
            {
                PPKW.Hide();
                pMotorrad.Hide();
                pLKW.Show();
            }

            if (cBFahrzeugTyp.Text != "")
            {
                lblParkhaus.Show();
                cBParkhaus.Show();
            }

            if (cBParkhaus.Text != "")
            {
                lblParkplatz.Show();
                cBParkplatz.Show();
            }
        }

        private void btnSaveNewFahrzeug_Click(object sender, EventArgs e)
        {
            //Call function to save input for new Vehicle
        }

        private void btnParkhaus_Click(object sender, EventArgs e)
        {
            /** 
             *  Parkplatzverbrauch: Auto (1), Motorrad (0,5), LKW (6)
             *  LKW im Erdgeschoss max. 10
             *  Parkplätze p. Etage = AnzLKW * 6 (Wenn keine LKW, dann 60)
            **/

            //Call function to save input for new Parkhaus
            string Ort = tBOrt.Text;
            int PLZ = Convert.ToInt32(tBPLZ.Text);
            string Straße = tBStrasse.Text;
            int anzPKW = Convert.ToInt32(tBPKW.Text);
            int anzMotorrad = Convert.ToInt32(tBMotorrad.Text);
            int anzLKW = Convert.ToInt32(tBLKW.Text);


        }        
    }
}

/**
 * Kennzeichen in 3 Teile splitten -> einfachere Überprüfung. 
 * Dabei nach 2 bzw. 3 chars in das nächste Feld skippen
 * 
 * Erstellung einer übergeordneten Klasse, um bei der geEntered TextBox den Text zu löschen.
 * 
 * Genereller Filter für die Textboxen einbauen, auf Buchstaben & Zahlen
 * 
 * --> Dateispeicherung. Parkhaus, Fahrzeuge
 * Bei Start der Anwendung alle Dateien laden und in GUI füllen.
 * 
 * Erstellung der Parkhäuser über GUI
 * 
 * Hinzufügen von Fahrzeugen
 * 
 * Fahrzeug zu Parkplatz hinzufügen (eigenes Panel/Menu)
 * 
 * 
 **/ 