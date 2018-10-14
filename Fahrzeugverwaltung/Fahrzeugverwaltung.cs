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

        // Erstellung des Fuhrparkobjektes. 
        Fuhrpark FP = new Fuhrpark();

        // Konstroktor, der die gespeicherten Textdateien lädt.
        public Fahrzeugverwaltung()
        {
            InitializeComponent();
            // Laden der bisherigen Daten, Fehlermeldung falls es keine bisherigen Dateien geben sollte.
            Fuhrpark fuhrpark = new Fuhrpark();
            try
            {
                FP.loadParkhaus();
                FP.loadFahrzeuge();
            }
            catch (Exception)
            {
                Console.WriteLine("No information found!");
            }
            clearWindow();
            hideFahrzeugInformationen();
        }

        private void resetFahrzeugInformationen()
        {
            hideFahrzeugInformationen();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
        }

        private void clearWindow()
        {
            //Clear all elements in curretn window
            pFahrzeugSuchen.Hide();
            pFahrzeugHinzufügen.Hide();
            pParkhausHinzufügen.Hide();
        }

        private void parkhausHinzufügen_Click(object sender, EventArgs e)
        {
            resetFahrzeugInformationen();
            clearWindow();
            pParkhausHinzufügen.BringToFront();
            pParkhausHinzufügen.Show();
        }

        private void fahrzeugHinzufügen_Click(object sender, EventArgs e)
        {
            resetFahrzeugInformationen();
            clearWindow();
            clearFahrzeugtyp();
            pParkhausHinzufügen.BringToFront();
            pFahrzeugHinzufügen.Show();

            cbH_Parkhaus.Items.Clear();
            List<Parkhaus> parkhaus = FP.getParkhaus();
            for (int i = 0; i < parkhaus.Count(); i++)
            {
                cbH_Parkhaus.Items.Add(i + 1);
            }
        }

        private void fahrzeugSuchen_Click(object sender, EventArgs e)
        {
            resetFahrzeugInformationen();
            clearWindow();
            pParkhausHinzufügen.BringToFront();
            pFahrzeugSuchen.Show();

            FP.loadParkhaus();
            FP.loadFahrzeuge();
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
                string textOutput = item.Kennzeichen + "\t" + (item.Parkhaus == 0 ? " " : item.Parkhaus.ToString() + "-" + item.Stellplatz) + "\t" + item.Herseller + "\t" + item.Modell;
                lBFahrzeugInformationen.Items.Add(textOutput);
            }
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
                tB_Zuladung_t.BringToFront();
                tB_AnzAchsen.Show();
                tB_Zuladung_t.Show();
            }
        }

        private void clearFahrzeugtyp()
        {
            tBM_Hubraum.Hide();
            tB_Hubraum.Hide();
            tB_Leistung.Hide();
            tB_AnzAchsen.Hide();
            tB_Zuladung_t.Hide();
            cBSchadstoffklasse.Hide();
            lblSchadstoff.Hide();
        }

        // Abspeichern eines neuangelegten Fahrzeugobjektes.
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
            int parkhaus = Convert.ToInt32(cbH_Parkhaus.Text);
            int stellplatz = Convert.ToInt32(cbH_Stellplatz.Text);

            // PKW
            if (cBFahrzeugTyp.Text == "PKW")
            {
                string hubraumA = tB_Hubraum.Text;
                string leistung = tB_Leistung.Text;
                string schadstoff = cBSchadstoffklasse.Text;
                FP.newFahrzeug(hersteller, modell, ken + "-" + zei + "-" + hen, Convert.ToInt32(erstzulassung), Convert.ToDouble(preis), parkhaus, stellplatz, Convert.ToInt32(hubraumA), Convert.ToInt32(leistung), Convert.ToInt32(schadstoff));
            }

            //Motorrad
            else if (cBFahrzeugTyp.Text == "Motorrad")
            {
                string hubraumM = tBM_Hubraum.Text;
                FP.newFahrzeug(hersteller, modell, ken + "-" + zei + "-" + hen, Convert.ToInt32(erstzulassung), Convert.ToInt32(preis), parkhaus, stellplatz, Convert.ToInt32(hubraumM));
            }

            //LKW
            else if (cBFahrzeugTyp.Text == "LKW")
            {
                string anzAchsen = tB_AnzAchsen.Text;
                string zuladung = tB_Zuladung_t.Text;
                FP.newFahrzeug(hersteller, modell, ken + "-" + zei + "-" + hen, Convert.ToInt32(erstzulassung), Convert.ToInt32(preis),parkhaus, stellplatz, Convert.ToInt32(anzAchsen), Convert.ToDouble(zuladung));
            }
        }

        // Abspeichen eines neuen Parkhausobjektes.
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

        private void loadParkplaetze(object sender, EventArgs e) 
        {
            FP.loadParkhaus();
            FP.loadFahrzeuge();

            ComboBox help;
            int id;
            if (((ComboBox)sender).Name.ToString() == "cBParkhaus")
            {
                 help = cBParkplatz;
                id = Convert.ToInt32(cBParkhaus.Text);
                cBParkplatz.Items.Clear();
            } else
            {
                help = cbH_Stellplatz;
                id = Convert.ToInt32(cbH_Parkhaus.Text);
                cbH_Stellplatz.Items.Clear();
            }

            List<Parkhaus> parkhaus = FP.getParkhaus();
            
            List<Parkplaetze> parkplatz = parkhaus[id-1].getParkplatz();

            //HIA Differenzierung, welcher Fahrzeugtyp das ausgewählte Kennzeichen in cbKennzeichen hat, fehlt noch. = pkw 1 motorrad 2 lkw
            foreach (var item in parkplatz)
            {
                help.Items.Add(item.getParkplatz() + 1);
            }
        }

        // Anzeige der Fahrzeugdaten.
        private void showExtendedFahrzeugInformations_Click(object sender, EventArgs e)
        {
            List<Parkhaus> parkhaus = FP.getParkhaus();
            System.IO.StreamReader file = new System.IO.StreamReader(@"Fahrzeuge.txt", true);
            string line;
            while ((line = Convert.ToString(file.ReadLine())) != null) //liest nur erste Zeile?
            {
                string[] splitchar = line.Split(';');
                string fahrzeugInformation = lBFahrzeugInformationen.SelectedItem.ToString();
                string[] kennzeichen = fahrzeugInformation.Split('\t');

                if (splitchar[2] == kennzeichen[0])
                {
                    label1.Text = splitchar[0];                 //Marke
                    label2.Text = splitchar[1];                 //Modell
                    label3.Text = splitchar[2];                 //Kennzeichen
                    label4.Text = splitchar[3];                 //Erstzulassung
                    label5.Text = splitchar[4];                 //Preis
                    label6.Text = splitchar[5];                 //Parkhaus
                    //--
                    label10.Text = splitchar[6];                //Stellplatz
                                                                // Steuer? bsp label14.Text = FP.steuerEinzeln(splitchar[2]);
                    label14.Text = (FP.steuerEinzeln(splitchar[2])).ToString(); // Steuer, von mir
                    label15.Text = FP.steuerAlle().ToString();
                    if (splitchar[5] != "")
                    {
                        Parkhaus parkhausObj = parkhaus[Convert.ToInt32(splitchar[5])-1];
                        
                        label7.Text = parkhausObj.Ort;              //Ort
                        label8.Text = parkhausObj.PLZ.ToString();   //PLZ
                        label9.Text = parkhausObj.Straße;           //Straße
                    } else
                    {
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    if (splitchar.Length == 8)
                    {
                        label11.Text = splitchar[7];
                        lblHubraum.Show();
                        lblZuladung.Hide();
                        lblAnzAchsen.Hide();
                        lblLeistung.Hide();
                        lblSchadstoffklasse.Hide();
                        label11.Show();
                        label12.Hide();
                        label13.Hide();
                        break;
                    }
                    else if (splitchar.Length == 9)
                    {
                        label11.Text = splitchar[7];
                        label12.Text = splitchar[8];
                        lblAnzAchsen.Show();
                        lblZuladung.Show();
                        lblHubraum.Hide();
                        lblLeistung.Hide();
                        lblSchadstoffklasse.Hide();
                        label11.Show();
                        label12.Show();
                        label13.Hide();
                        break;
                    }
                    else if (splitchar.Length == 10)
                    {
                        label11.Text = splitchar[7];
                        label12.Text = splitchar[8];
                        label13.Text = splitchar[9];
                        lblHubraum.Show();
                        lblLeistung.Show();
                        lblSchadstoffklasse.Show();
                        lblAnzAchsen.Hide();
                        lblZuladung.Hide();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        break;
                    }
                }
            }
            file.Close();
            showFahrzeugInformationen();

            cBParkhaus.Items.Clear();
            for (int i = 0; i < parkhaus.Count(); i++)
            {
                cBParkhaus.Items.Add(i+1);
            }
        }

        private void btnSaveParkplatz_Click(object sender, EventArgs e)
        {
            string selectedKennzeichen = lBFahrzeugInformationen.SelectedItem.ToString();
            string[] helper = selectedKennzeichen.Split('\t');


            FP.weiseStellplatzZu(helper[0], Convert.ToInt32(cBParkhaus.Text), Convert.ToInt32(cBParkplatz.Text));
            fillLabelBoxWithFahrzeuge();
        }

        private void ortFilterTextForLBFahrzeugInformationen(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                fillLabelBoxWithFahrzeuge();
            }

            List<string> FahrzeuginformationenOld = new List<string>();
            List<string> FahrzeuginformationenNew = new List<string>();
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

        public void hideFahrzeugInformationen()
        {
            lblHersteller.Hide();
            lblModell.Hide();
            lblKennzeichen.Hide();
            lblZulassung.Hide();
            lblPreis.Hide();
            lblHubraum.Hide();
            lblLeistung.Hide();
            lblSchadstoffklasse.Hide();
            lblAnzAchsen.Hide();
            lblZuladung.Hide();
            lblParkhaus.Hide();
            lblOrt.Hide();
            lblPLZ.Hide();
            lblStraße.Hide();
            lblStellplatz.Hide();
            lblSteuerFürDasFahrzeug.Hide();
            lblSteuerFürAlle.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            cBParkplatz.Hide();
            cBParkhaus.Hide();
            btnSaveParkplatz.Hide();
            lblStellplatzÄndern.Hide();
        }

        public void showFahrzeugInformationen()
        {
            lblHersteller.Show();
            lblModell.Show();
            lblKennzeichen.Show();
            lblZulassung.Show();
            lblPreis.Show();
            lblParkhaus.Show();
            lblOrt.Show();
            lblPLZ.Show();
            lblStraße.Show();
            lblStellplatz.Show();
            lblSteuerFürDasFahrzeug.Show();
            lblSteuerFürAlle.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label14.Show();
            label15.Show();
            cBParkplatz.Show();
            cBParkhaus.Show();
            btnSaveParkplatz.Show();
            lblStellplatzÄndern.Show();
        }
    }
}