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
        Fuhrpark FP = new Fuhrpark();
        public Fahrzeugverwaltung()
        {
            // --sucheFahrzeug(string kennzeichen) rückgabe: string mit dem parkhaus und der nummer des stellplatzes

            // steuerEinzeln(string kennzeichen) rückgabe: string mit der zu zahlenden summe: (Die steuer beträgt xx Euro)

            // weiseStellplatzZu(string kennzeichen, int parkhaus, int stellplatz) rückgabe: nix

            // fahrzeugstelleInListe(string kennzeichen) rückgabe: stelle in der liste mit den fahrzeugen. hab ich für die steuer gemacht, falls du das noch brauchen solltest

            InitializeComponent();
            // Laden der bisherigen Daten
            Fuhrpark fuhrpark = new Fuhrpark();
            try
            {
                FP.loadParkhaus();
                FP.loadFahrzeuge();
            } catch (Exception e)
            {
                Console.WriteLine("No information found!");
            }
            //fuhrpark.loadFahrzeuge(fuhrpark);
            clearWindow();
        }

        private void clearWindow()
        {
            //Clear all elements in curretn window
            pFahrzeugSuchen.Hide();
            pFahrzeugHinzufügen.Hide();
            pParkhausHinzufügen.Hide();
        }

        private void fahrzeugartenAusgeben_Click(object sender, EventArgs e)
        {
            clearWindow();
        }

        private void parkhausHinzufügen_Click(object sender, EventArgs e)
        {
            clearWindow();
            pParkhausHinzufügen.BringToFront();
            pParkhausHinzufügen.Show();
        }

        private void fahrzeugHinzufügen_Click(object sender, EventArgs e)
        {
            clearWindow();
            pParkhausHinzufügen.BringToFront();
            pFahrzeugHinzufügen.Show();
        }

        private void fahrzeugSuchen_Click(object sender, EventArgs e)
        {
            clearWindow();
            pParkhausHinzufügen.BringToFront();
            pFahrzeugSuchen.Show();
        }

        private void überprüfeSteuerlast_Click(object sender, EventArgs e)
        {

        }

        private void fahrzeugZuweisen_Click(object sender, EventArgs e)
        {
            clearWindow();
            loadInformations();
            pFahrzeugZuweisen.BringToFront();
            pFahrzeugZuweisen.Show();
        }

        private void ShowFahrzeugTypPanel(object sender, EventArgs e)
        {
            if (cBFahrzeugTyp.Text == "PKW")
            {
                PPKW.BringToFront();
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
                pLKW.BringToFront();
                pLKW.Show();
            }
        }

        private void btnSaveNewFahrzeug_Click(object sender, EventArgs e)
        {
            //Call function to save input for new Vehicle
            string hersteller = tB_Hersteller.Text;
            string modell = tB_Modell.Text;
            string ken = tBK_Ken.Text;
            string zei = tBK_Zei.Text;
            string hen = tBK_Hen.Text;
            string erstzulassung = tB_Erstzulassung.Text;
            string preis = tB_Preis.Text;
            // PKW
            if (cBFahrzeugTyp.Text == "PKW")
            {
                string hubraumA = tB_Hubraum.Text;
                string leistung = tB_Leistung.Text;
                string schadstoff = cBSchadstoffklasse.Text;
                FP.newFahrzeug(hersteller, modell, ken + "-" + zei + "-" + hen, Convert.ToInt32(erstzulassung), Convert.ToInt32(preis), Convert.ToInt32(hubraumA), Convert.ToInt32(leistung), Convert.ToInt32(schadstoff));
            }
            //Motorrad
            else if (cBFahrzeugTyp.Text == "Motorrad")
            {
                string hubraumM = tBM_Hubraum.Text;
                FP.newFahrzeug(hersteller, modell, ken + "-" + zei + "-" + hen, Convert.ToInt32(erstzulassung), Convert.ToInt32(preis), Convert.ToInt32(hubraumM));
            }
            //LKW
            else if (cBFahrzeugTyp.Text == "LKW")
            {
                string anzAchsen = tB_AnzAchsen.Text;
                string zuladung = tB_Zuladung.Text;
                FP.newFahrzeug(hersteller, modell, ken + "-" + zei + "-" + hen, Convert.ToInt32(erstzulassung), Convert.ToInt32(preis), Convert.ToInt32(anzAchsen), Convert.ToInt32(zuladung));
            }
        }
        
        private void sucheFahrzeug_Click(object sender, EventArgs e)
        {
            string foundFahrzeug = FP.sucheFahrzeug(tbs_Ken.Text + "-" + tbs_Zei.Text + "-" + tbs_Hen.Text);

            rtbFahrzeugOutput.Text = foundFahrzeug;
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

            FP.newParkhaus(Ort, PLZ, Straße, anzPKW, anzMotorrad, anzLKW);
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

        private void loadInformations()
        {
            //Load info to ComboBoxes
            List<Fahrzeug> fahrzeug = FP.getFahrzeuge();
            List<Parkhaus> parkhaus = FP.getParkhaus();

            foreach (var item in fahrzeug)
            {
                cBKennzeichen.Items.Add(item.Kennzeichen);
            }

            for (int i = 0; i < parkhaus.Count(); i++)
            {
                cBParkhaus.Items.Add(i+1);
            }
        }

        private void loadParkplaetze(object sender, EventArgs e)
        {
            List<Parkhaus> parkhaus = FP.getParkhaus();
            int id = Convert.ToInt32(cBParkhaus.Text) - 1;
            List<Parkplaetze> parkplatz = parkhaus[id].getParkplatz();

            //Differenzierung, welcher Fahrzeugtyp das ausgewählte Kennzeichen in cbKennzeichen hat, fehlt noch.
            foreach (var item in parkplatz)
            {
                cBParkplatz.Items.Add(item.getParkplatz() + 1);
            }
        }
    }
}