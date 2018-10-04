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
            // Laden der bisherigen Daten
            Fuhrpark fuhrpark = new Fuhrpark();
            fuhrpark.loadParkhaus(fuhrpark);
            fuhrpark.loadFahrzeuge(fuhrpark);
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
            string Ort = tB_Ort.Text;
            int PLZ = Convert.ToInt32(tB_PLZ.Text);
            string Straße = tB_Strasse.Text;
            int anzPKW = Convert.ToInt32(tB_PKW.Text);
            int anzMotorrad = Convert.ToInt32(tB_Motorrad.Text);
            int anzLKW = Convert.ToInt32(tB_LKW.Text);


        }

        private void changeFocusToTBKZusatz(object sender, EventArgs e)
        {
            if (tBK_Ken.Text.Length == 3)
            {
                tBK_Zei.Focus();
            }
        }

        private void changeFocusToTBKZahl(object sender, EventArgs e)
        {
            if (tBK_Zei.Text.Length == 2)
            {
                tBK_Hen.Focus();
            }
        }

        private void deleteTextOnClick(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
        }

        private void filterIncomingString(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)  
            {
                e.Handled = true;
            } 
        }

        private void filterIncomingDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void setPreviousTextIfEmpty(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                string[] help = ((TextBox)sender).Name.Split('_');
                ((TextBox)sender).Text = help[1];
            }
        }
    }
}

/**
 * -Kennzeichen in 3 Teile splitten -> einfachere Überprüfung. 
 * -Dabei nach 2 bzw. 3 chars in das nächste Feld skippen
 * 
 * -Erstellung einer übergeordneten Klasse, um bei der geEntered TextBox den Text zu löschen.
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