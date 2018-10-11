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
            } catch (Exception)
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
            clearFahrzeugtyp();
            pParkhausHinzufügen.BringToFront();
            pFahrzeugHinzufügen.Show();
        }

        private void fahrzeugSuchen_Click(object sender, EventArgs e)
        {
            clearWindow();
            pParkhausHinzufügen.BringToFront();
            pFahrzeugSuchen.Show();

            FP.loadFahrzeuge();
            FP.loadParkhaus();
            //List<Fahrzeug> fahrzeuge = FP.getFahrzeuge();
            //List<Parkhaus> parkhaus = FP.getParkhaus();
            fillLabelBoxWithFahrzeuge();
        }

        private void fillLabelBoxWithFahrzeuge()
        {
            lBFahrzeugInformationen.Items.Clear();
            List<Fahrzeug> fahrzeuge = FP.getFahrzeuge();
            foreach (var item in fahrzeuge)
            {
                string stellplatz = FP.getParkplatzParkhausForKennzeichen(item.Kennzeichen);
                string textOutput = item.Kennzeichen + "\t" + stellplatz + "\t" + item.Herseller + "\t" + item.Modell;
                lBFahrzeugInformationen.Items.Add(textOutput);
            }
        }

        private void überprüfeSteuerlast_Click(object sender, EventArgs e)
        {

        }

        private void fahrzeugZuweisen_Click(object sender, EventArgs e)
        {
            clearWindow();
            loadInformations();
        }

        private void ShowFahrzeugTypPanel(object sender, EventArgs e)
        {
            if (cBFahrzeugTyp.Text == "PKW")
            {
                clearFahrzeugtyp();
                tB_Hubraum.BringToFront();
                tB_Leistung.BringToFront();
                tB_Hubraum.Show();
                tB_Leistung.Show();
                lblSchadstoff.Show();
                cBSchadstoffklasse.Show();
            }
            else if (cBFahrzeugTyp.Text == "Motorrad")
            {
                clearFahrzeugtyp();
                tBM_Hubraum.BringToFront();
                tBM_Hubraum.Show();
            }
            else if (cBFahrzeugTyp.Text == "LKW")
            {
                clearFahrzeugtyp();
                tB_AnzAchsen.BringToFront();
                tB_Zuladung.BringToFront();
                tB_AnzAchsen.Show();
                tB_Zuladung.Show();
            }
        }

        private void clearFahrzeugtyp()
        {
            tBM_Hubraum.Hide();
            tB_Hubraum.Hide();
            tB_Leistung.Hide();
            tB_AnzAchsen.Hide();
            tB_Zuladung.Hide();
            cBSchadstoffklasse.Hide();
            lblSchadstoff.Hide();
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
                FP.newFahrzeug(hersteller, modell, ken + "-" + zei + "-" + hen, Convert.ToInt32(erstzulassung), Convert.ToDouble(preis), 0, 0, Convert.ToInt32(hubraumA), Convert.ToInt32(leistung), Convert.ToInt32(schadstoff));
            }
            //Motorrad
            else if (cBFahrzeugTyp.Text == "Motorrad")
            {
                string hubraumM = tBM_Hubraum.Text;
                FP.newFahrzeug(hersteller, modell, ken + "-" + zei + "-" + hen, Convert.ToInt32(erstzulassung), Convert.ToInt32(preis),0,0, Convert.ToInt32(hubraumM));
            }
            //LKW
            else if (cBFahrzeugTyp.Text == "LKW")
            {
                string anzAchsen = tB_AnzAchsen.Text;
                string zuladung = tB_Zuladung.Text;
                FP.newFahrzeug(hersteller, modell, ken + "-" + zei + "-" + hen, Convert.ToInt32(erstzulassung), Convert.ToInt32(preis),0,0, Convert.ToInt32(anzAchsen), Convert.ToDouble(zuladung));
            }
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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
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
            List<Parkhaus> parkhaus = FP.getParkhaus();
            
            for (int i = 0; i < parkhaus.Count(); i++)
            {
                cBParkhaus.Items.Add(i+1);
            }
        }

        private void loadParkplaetze(object sender, EventArgs e)
        {
            FP.loadFahrzeuge();
            FP.loadParkhaus();

            cBParkplatz.Items.Clear();
            List<Parkhaus> parkhaus = FP.getParkhaus();
            int id = Convert.ToInt32(cBParkhaus.Text) - 1;
            List<Parkplaetze> parkplatz = parkhaus[id].getParkplatz();

            //Differenzierung, welcher Fahrzeugtyp das ausgewählte Kennzeichen in cbKennzeichen hat, fehlt noch.
            foreach (var item in parkplatz)
            {
                cBParkplatz.Items.Add(item.getParkplatz() + 1);
            }
        }

        private void changeStellplatz_Click(object sender, EventArgs e)
        {
            cBParkhaus.Show();
            cBParkplatz.Show();
            btnSaveParkplatz.Show();

            List<Parkhaus> parkhaus = FP.getParkhaus();
            for (int i = 0; i < parkhaus.Count(); i++)
            {
                cBParkhaus.Items.Add(i + 1);
            }
        }

        private void btnSaveParkplatz_Click(object sender, EventArgs e)
        {
            cBParkhaus.Hide();
            cBParkplatz.Hide();
            btnSaveParkplatz.Hide();
            string selectedKennzeichen = lBFahrzeugInformationen.SelectedItem.ToString();
            string[] helper = selectedKennzeichen.Split('\t');
            selectedKennzeichen = helper[0];

            FP.weiseStellplatzZu(selectedKennzeichen, Convert.ToInt32(cBParkhaus.Text), Convert.ToInt32(cBParkplatz.Text));
            loadInformations();
            //MessageBox.Show(lBFahrzeugInformationen.SelectedItem.ToString());
            //lBFahrzeugInformationen.SelectedItem.ToString()

            //FP.weiseStellplatzZu(((ListBox)sender).SelectedItem.ToString());
        }

        private void ortFilterTextForLBFahrzeugInformationen(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                fillLabelBoxWithFahrzeuge();
            }

            List<String> FahrzeuginformationenOld = new List<string>();
            List<String> FahrzeuginformationenNew = new List<string>();
            for (int i = 0; i < lBFahrzeugInformationen.Items.Count; i++)
            {
                string cbFahrzeugInformationen = lBFahrzeugInformationen.Items[i].ToString();
                FahrzeuginformationenOld.Add(cbFahrzeugInformationen);
            }
            string filterTextBox = "";
            int count;
            if (((TextBox)sender) == tbs_Ken)
            {
                filterTextBox = tbs_Ken.Text;
                count = 0;
            } else if (((TextBox)sender) == tbs_Zei)
            {
                filterTextBox = tbs_Zei.Text;
                count = 1;
            } else {
                filterTextBox = tbs_Hen.Text;
                count = 2;
            }
            foreach (var item in FahrzeuginformationenOld)
            {
                int charCount = filterTextBox.Length;
                string[] help = item.Split('-');
                if (help[count].Length >= charCount)
                {
                    if (filterTextBox.ToString() == help[count].Substring(0, charCount))
                    {
                        FahrzeuginformationenNew.Add(item);
                    }
                }
            }
            lBFahrzeugInformationen.Items.Clear();
            foreach (var item in FahrzeuginformationenNew)
            {
                lBFahrzeugInformationen.Items.Add(item);
            }
        }
    }
}