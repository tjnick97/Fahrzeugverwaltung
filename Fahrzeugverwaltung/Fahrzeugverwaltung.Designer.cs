namespace Fahrzeugverwaltung
{
    partial class Fahrzeugverwaltung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labKennz = new System.Windows.Forms.Label();
            this.tBoxKennzOrt = new System.Windows.Forms.TextBox();
            this.tBoxKennzZus = new System.Windows.Forms.TextBox();
            this.tBoxKennzNum = new System.Windows.Forms.TextBox();
            this.pFahrzeugSuchen = new System.Windows.Forms.Panel();
            this.pFahrzeugHinzufügen = new System.Windows.Forms.Panel();
            this.tBK_Hen = new System.Windows.Forms.TextBox();
            this.tBK_Zei = new System.Windows.Forms.TextBox();
            this.tBK_Ken = new System.Windows.Forms.TextBox();
            this.lblParkplatz = new System.Windows.Forms.Label();
            this.lblParkhaus = new System.Windows.Forms.Label();
            this.cBParkplatz = new System.Windows.Forms.ComboBox();
            this.cBParkhaus = new System.Windows.Forms.ComboBox();
            this.btnSaveNewFahrzeug = new System.Windows.Forms.Button();
            this.pLKW = new System.Windows.Forms.Panel();
            this.tB_Zuladung = new System.Windows.Forms.TextBox();
            this.tB_AnzAchsen = new System.Windows.Forms.TextBox();
            this.pMotorrad = new System.Windows.Forms.Panel();
            this.tBM_Hubraum = new System.Windows.Forms.TextBox();
            this.PPKW = new System.Windows.Forms.FlowLayoutPanel();
            this.tB_Hubraum = new System.Windows.Forms.TextBox();
            this.tB_Leistung = new System.Windows.Forms.TextBox();
            this.cBSchadstoffklasse = new System.Windows.Forms.ComboBox();
            this.tB_Preis = new System.Windows.Forms.TextBox();
            this.tB_Erstzulassung = new System.Windows.Forms.TextBox();
            this.tB_Modell = new System.Windows.Forms.TextBox();
            this.tB_Hersteller = new System.Windows.Forms.TextBox();
            this.cBFahrzeugTyp = new System.Windows.Forms.ComboBox();
            this.lblFahrzeugTyp = new System.Windows.Forms.Label();
            this.pParkhausHinzufügen = new System.Windows.Forms.Panel();
            this.tB_Strasse = new System.Windows.Forms.TextBox();
            this.tB_PLZ = new System.Windows.Forms.TextBox();
            this.tB_Ort = new System.Windows.Forms.TextBox();
            this.btnParkhaus = new System.Windows.Forms.Button();
            this.lblAnzParkplätze = new System.Windows.Forms.Label();
            this.tB_LKW = new System.Windows.Forms.TextBox();
            this.tB_Motorrad = new System.Windows.Forms.TextBox();
            this.tB_PKW = new System.Windows.Forms.TextBox();
            this.tBParkhaus = new System.Windows.Forms.TextBox();
            this.pFahrzeugSuchen.SuspendLayout();
            this.pFahrzeugHinzufügen.SuspendLayout();
            this.pLKW.SuspendLayout();
            this.pMotorrad.SuspendLayout();
            this.PPKW.SuspendLayout();
            this.pParkhausHinzufügen.SuspendLayout();
            this.SuspendLayout();
            // 
            // labKennz
            // 
            this.labKennz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labKennz.AutoSize = true;
            this.labKennz.Location = new System.Drawing.Point(14, 16);
            this.labKennz.Name = "labKennz";
            this.labKennz.Size = new System.Drawing.Size(189, 32);
            this.labKennz.TabIndex = 0;
            this.labKennz.Text = "Kennzeichen:";
            this.labKennz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBoxKennzOrt
            // 
            this.tBoxKennzOrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBoxKennzOrt.Location = new System.Drawing.Point(275, 14);
            this.tBoxKennzOrt.MaxLength = 3;
            this.tBoxKennzOrt.Name = "tBoxKennzOrt";
            this.tBoxKennzOrt.Size = new System.Drawing.Size(67, 38);
            this.tBoxKennzOrt.TabIndex = 1;
            this.tBoxKennzOrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxKennzOrt.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tBoxKennzOrt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingString);
            // 
            // tBoxKennzZus
            // 
            this.tBoxKennzZus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBoxKennzZus.Location = new System.Drawing.Point(348, 14);
            this.tBoxKennzZus.MaxLength = 2;
            this.tBoxKennzZus.Name = "tBoxKennzZus";
            this.tBoxKennzZus.Size = new System.Drawing.Size(67, 38);
            this.tBoxKennzZus.TabIndex = 2;
            this.tBoxKennzZus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxKennzZus.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tBoxKennzZus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingString);
            // 
            // tBoxKennzNum
            // 
            this.tBoxKennzNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBoxKennzNum.Location = new System.Drawing.Point(421, 14);
            this.tBoxKennzNum.MaxLength = 4;
            this.tBoxKennzNum.Name = "tBoxKennzNum";
            this.tBoxKennzNum.Size = new System.Drawing.Size(67, 38);
            this.tBoxKennzNum.TabIndex = 3;
            this.tBoxKennzNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxKennzNum.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tBoxKennzNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingDigits);
            // 
            // pFahrzeugSuchen
            // 
            this.pFahrzeugSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pFahrzeugSuchen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pFahrzeugSuchen.Controls.Add(this.tBoxKennzNum);
            this.pFahrzeugSuchen.Controls.Add(this.tBoxKennzZus);
            this.pFahrzeugSuchen.Controls.Add(this.tBoxKennzOrt);
            this.pFahrzeugSuchen.Controls.Add(this.labKennz);
            this.pFahrzeugSuchen.Location = new System.Drawing.Point(12, 52);
            this.pFahrzeugSuchen.Name = "pFahrzeugSuchen";
            this.pFahrzeugSuchen.Size = new System.Drawing.Size(830, 92);
            this.pFahrzeugSuchen.TabIndex = 0;
            this.pFahrzeugSuchen.Visible = false;
            // 
            // pFahrzeugHinzufügen
            // 
            this.pFahrzeugHinzufügen.Controls.Add(this.tBK_Hen);
            this.pFahrzeugHinzufügen.Controls.Add(this.tBK_Zei);
            this.pFahrzeugHinzufügen.Controls.Add(this.tBK_Ken);
            this.pFahrzeugHinzufügen.Controls.Add(this.lblParkplatz);
            this.pFahrzeugHinzufügen.Controls.Add(this.lblParkhaus);
            this.pFahrzeugHinzufügen.Controls.Add(this.cBParkplatz);
            this.pFahrzeugHinzufügen.Controls.Add(this.cBParkhaus);
            this.pFahrzeugHinzufügen.Controls.Add(this.btnSaveNewFahrzeug);
            this.pFahrzeugHinzufügen.Controls.Add(this.pLKW);
            this.pFahrzeugHinzufügen.Controls.Add(this.pMotorrad);
            this.pFahrzeugHinzufügen.Controls.Add(this.PPKW);
            this.pFahrzeugHinzufügen.Controls.Add(this.tB_Preis);
            this.pFahrzeugHinzufügen.Controls.Add(this.tB_Erstzulassung);
            this.pFahrzeugHinzufügen.Controls.Add(this.tB_Modell);
            this.pFahrzeugHinzufügen.Controls.Add(this.tB_Hersteller);
            this.pFahrzeugHinzufügen.Controls.Add(this.cBFahrzeugTyp);
            this.pFahrzeugHinzufügen.Controls.Add(this.lblFahrzeugTyp);
            this.pFahrzeugHinzufügen.Location = new System.Drawing.Point(12, 166);
            this.pFahrzeugHinzufügen.Name = "pFahrzeugHinzufügen";
            this.pFahrzeugHinzufügen.Size = new System.Drawing.Size(698, 401);
            this.pFahrzeugHinzufügen.TabIndex = 2;
            this.pFahrzeugHinzufügen.Visible = false;
            // 
            // tBK_Hen
            // 
            this.tBK_Hen.Location = new System.Drawing.Point(144, 105);
            this.tBK_Hen.MaxLength = 4;
            this.tBK_Hen.Name = "tBK_Hen";
            this.tBK_Hen.Size = new System.Drawing.Size(61, 38);
            this.tBK_Hen.TabIndex = 17;
            this.tBK_Hen.Text = "hen";
            this.tBK_Hen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBK_Hen.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tBK_Hen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingDigits);
            this.tBK_Hen.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // tBK_Zei
            // 
            this.tBK_Zei.Location = new System.Drawing.Point(92, 105);
            this.tBK_Zei.MaxLength = 2;
            this.tBK_Zei.Name = "tBK_Zei";
            this.tBK_Zei.Size = new System.Drawing.Size(46, 38);
            this.tBK_Zei.TabIndex = 16;
            this.tBK_Zei.Text = "zei";
            this.tBK_Zei.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBK_Zei.TextChanged += new System.EventHandler(this.changeFocusToTBKZahl);
            this.tBK_Zei.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tBK_Zei.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingString);
            this.tBK_Zei.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // tBK_Ken
            // 
            this.tBK_Ken.Location = new System.Drawing.Point(22, 105);
            this.tBK_Ken.MaxLength = 3;
            this.tBK_Ken.Name = "tBK_Ken";
            this.tBK_Ken.Size = new System.Drawing.Size(63, 38);
            this.tBK_Ken.TabIndex = 4;
            this.tBK_Ken.Text = "Ken";
            this.tBK_Ken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBK_Ken.TextChanged += new System.EventHandler(this.changeFocusToTBKZusatz);
            this.tBK_Ken.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tBK_Ken.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingString);
            this.tBK_Ken.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // lblParkplatz
            // 
            this.lblParkplatz.AutoSize = true;
            this.lblParkplatz.Location = new System.Drawing.Point(219, 113);
            this.lblParkplatz.Name = "lblParkplatz";
            this.lblParkplatz.Size = new System.Drawing.Size(142, 32);
            this.lblParkplatz.TabIndex = 15;
            this.lblParkplatz.Text = "Parkplatz:";
            this.lblParkplatz.Visible = false;
            // 
            // lblParkhaus
            // 
            this.lblParkhaus.AutoSize = true;
            this.lblParkhaus.Location = new System.Drawing.Point(220, 68);
            this.lblParkhaus.Name = "lblParkhaus";
            this.lblParkhaus.Size = new System.Drawing.Size(143, 32);
            this.lblParkhaus.TabIndex = 14;
            this.lblParkhaus.Text = "Parkhaus:";
            this.lblParkhaus.Visible = false;
            // 
            // cBParkplatz
            // 
            this.cBParkplatz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBParkplatz.FormattingEnabled = true;
            this.cBParkplatz.Location = new System.Drawing.Point(406, 110);
            this.cBParkplatz.Name = "cBParkplatz";
            this.cBParkplatz.Size = new System.Drawing.Size(121, 39);
            this.cBParkplatz.TabIndex = 13;
            this.cBParkplatz.Visible = false;
            // 
            // cBParkhaus
            // 
            this.cBParkhaus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBParkhaus.FormattingEnabled = true;
            this.cBParkhaus.Location = new System.Drawing.Point(406, 65);
            this.cBParkhaus.Name = "cBParkhaus";
            this.cBParkhaus.Size = new System.Drawing.Size(121, 39);
            this.cBParkhaus.TabIndex = 12;
            this.cBParkhaus.Visible = false;
            // 
            // btnSaveNewFahrzeug
            // 
            this.btnSaveNewFahrzeug.Location = new System.Drawing.Point(350, 254);
            this.btnSaveNewFahrzeug.Name = "btnSaveNewFahrzeug";
            this.btnSaveNewFahrzeug.Size = new System.Drawing.Size(314, 113);
            this.btnSaveNewFahrzeug.TabIndex = 11;
            this.btnSaveNewFahrzeug.Text = "Fahrzeug speichern";
            this.btnSaveNewFahrzeug.UseVisualStyleBackColor = true;
            this.btnSaveNewFahrzeug.Click += new System.EventHandler(this.btnSaveNewFahrzeug_Click);
            // 
            // pLKW
            // 
            this.pLKW.Controls.Add(this.tB_Zuladung);
            this.pLKW.Controls.Add(this.tB_AnzAchsen);
            this.pLKW.Location = new System.Drawing.Point(106, 237);
            this.pLKW.Name = "pLKW";
            this.pLKW.Size = new System.Drawing.Size(200, 100);
            this.pLKW.TabIndex = 10;
            this.pLKW.Visible = false;
            // 
            // tB_Zuladung
            // 
            this.tB_Zuladung.Location = new System.Drawing.Point(3, 53);
            this.tB_Zuladung.Name = "tB_Zuladung";
            this.tB_Zuladung.Size = new System.Drawing.Size(180, 38);
            this.tB_Zuladung.TabIndex = 7;
            this.tB_Zuladung.Text = "Zuladung";
            this.tB_Zuladung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_Zuladung.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tB_Zuladung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingDigits);
            this.tB_Zuladung.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // tB_AnzAchsen
            // 
            this.tB_AnzAchsen.Location = new System.Drawing.Point(0, 9);
            this.tB_AnzAchsen.MaxLength = 1;
            this.tB_AnzAchsen.Name = "tB_AnzAchsen";
            this.tB_AnzAchsen.Size = new System.Drawing.Size(180, 38);
            this.tB_AnzAchsen.TabIndex = 6;
            this.tB_AnzAchsen.Text = "Anz Achsen";
            this.tB_AnzAchsen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_AnzAchsen.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tB_AnzAchsen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingDigits);
            this.tB_AnzAchsen.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // pMotorrad
            // 
            this.pMotorrad.Controls.Add(this.tBM_Hubraum);
            this.pMotorrad.Location = new System.Drawing.Point(55, 237);
            this.pMotorrad.Name = "pMotorrad";
            this.pMotorrad.Size = new System.Drawing.Size(200, 56);
            this.pMotorrad.TabIndex = 9;
            this.pMotorrad.Visible = false;
            // 
            // tBM_Hubraum
            // 
            this.tBM_Hubraum.Location = new System.Drawing.Point(3, 9);
            this.tBM_Hubraum.Name = "tBM_Hubraum";
            this.tBM_Hubraum.Size = new System.Drawing.Size(180, 38);
            this.tBM_Hubraum.TabIndex = 5;
            this.tBM_Hubraum.Text = "Hubraum";
            this.tBM_Hubraum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBM_Hubraum.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tBM_Hubraum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingDigits);
            this.tBM_Hubraum.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // PPKW
            // 
            this.PPKW.Controls.Add(this.tB_Hubraum);
            this.PPKW.Controls.Add(this.tB_Leistung);
            this.PPKW.Controls.Add(this.cBSchadstoffklasse);
            this.PPKW.Location = new System.Drawing.Point(22, 237);
            this.PPKW.Name = "PPKW";
            this.PPKW.Size = new System.Drawing.Size(211, 139);
            this.PPKW.TabIndex = 8;
            this.PPKW.Visible = false;
            // 
            // tB_Hubraum
            // 
            this.tB_Hubraum.Location = new System.Drawing.Point(3, 3);
            this.tB_Hubraum.Name = "tB_Hubraum";
            this.tB_Hubraum.Size = new System.Drawing.Size(180, 38);
            this.tB_Hubraum.TabIndex = 4;
            this.tB_Hubraum.Text = "Hubraum";
            this.tB_Hubraum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_Hubraum.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tB_Hubraum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingDigits);
            this.tB_Hubraum.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // tB_Leistung
            // 
            this.tB_Leistung.Location = new System.Drawing.Point(3, 47);
            this.tB_Leistung.Name = "tB_Leistung";
            this.tB_Leistung.Size = new System.Drawing.Size(180, 38);
            this.tB_Leistung.TabIndex = 5;
            this.tB_Leistung.Text = "Leistung";
            this.tB_Leistung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_Leistung.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tB_Leistung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingDigits);
            this.tB_Leistung.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // cBSchadstoffklasse
            // 
            this.cBSchadstoffklasse.FormattingEnabled = true;
            this.cBSchadstoffklasse.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cBSchadstoffklasse.Location = new System.Drawing.Point(3, 91);
            this.cBSchadstoffklasse.MaxLength = 1;
            this.cBSchadstoffklasse.Name = "cBSchadstoffklasse";
            this.cBSchadstoffklasse.Size = new System.Drawing.Size(180, 39);
            this.cBSchadstoffklasse.TabIndex = 6;
            this.cBSchadstoffklasse.Text = "Schadstoff";
            // 
            // tB_Preis
            // 
            this.tB_Preis.Location = new System.Drawing.Point(22, 193);
            this.tB_Preis.Name = "tB_Preis";
            this.tB_Preis.Size = new System.Drawing.Size(183, 38);
            this.tB_Preis.TabIndex = 6;
            this.tB_Preis.Text = "Preis";
            this.tB_Preis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_Preis.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tB_Preis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingDigits);
            this.tB_Preis.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // tB_Erstzulassung
            // 
            this.tB_Erstzulassung.Location = new System.Drawing.Point(22, 149);
            this.tB_Erstzulassung.Name = "tB_Erstzulassung";
            this.tB_Erstzulassung.Size = new System.Drawing.Size(183, 38);
            this.tB_Erstzulassung.TabIndex = 5;
            this.tB_Erstzulassung.Text = "Erstzulassung";
            this.tB_Erstzulassung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_Erstzulassung.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tB_Erstzulassung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingDigits);
            this.tB_Erstzulassung.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // tB_Modell
            // 
            this.tB_Modell.Location = new System.Drawing.Point(22, 61);
            this.tB_Modell.Name = "tB_Modell";
            this.tB_Modell.Size = new System.Drawing.Size(183, 38);
            this.tB_Modell.TabIndex = 3;
            this.tB_Modell.Text = "Modell";
            this.tB_Modell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_Modell.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tB_Modell.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // tB_Hersteller
            // 
            this.tB_Hersteller.Location = new System.Drawing.Point(22, 17);
            this.tB_Hersteller.Name = "tB_Hersteller";
            this.tB_Hersteller.Size = new System.Drawing.Size(183, 38);
            this.tB_Hersteller.TabIndex = 2;
            this.tB_Hersteller.Text = "Hersteller";
            this.tB_Hersteller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_Hersteller.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tB_Hersteller.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingString);
            this.tB_Hersteller.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // cBFahrzeugTyp
            // 
            this.cBFahrzeugTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBFahrzeugTyp.FormattingEnabled = true;
            this.cBFahrzeugTyp.Items.AddRange(new object[] {
            "PKW",
            "Motorrad",
            "LKW"});
            this.cBFahrzeugTyp.Location = new System.Drawing.Point(406, 20);
            this.cBFahrzeugTyp.Name = "cBFahrzeugTyp";
            this.cBFahrzeugTyp.Size = new System.Drawing.Size(121, 39);
            this.cBFahrzeugTyp.TabIndex = 1;
            this.cBFahrzeugTyp.SelectedValueChanged += new System.EventHandler(this.ShowFahrzeugTypPanel);
            // 
            // lblFahrzeugTyp
            // 
            this.lblFahrzeugTyp.AutoSize = true;
            this.lblFahrzeugTyp.Location = new System.Drawing.Point(219, 20);
            this.lblFahrzeugTyp.Name = "lblFahrzeugTyp";
            this.lblFahrzeugTyp.Size = new System.Drawing.Size(181, 32);
            this.lblFahrzeugTyp.TabIndex = 0;
            this.lblFahrzeugTyp.Text = "Fahrzeugtyp:";
            // 
            // pParkhausHinzufügen
            // 
            this.pParkhausHinzufügen.Controls.Add(this.tB_Strasse);
            this.pParkhausHinzufügen.Controls.Add(this.tB_PLZ);
            this.pParkhausHinzufügen.Controls.Add(this.tB_Ort);
            this.pParkhausHinzufügen.Controls.Add(this.btnParkhaus);
            this.pParkhausHinzufügen.Controls.Add(this.lblAnzParkplätze);
            this.pParkhausHinzufügen.Controls.Add(this.tB_LKW);
            this.pParkhausHinzufügen.Controls.Add(this.tB_Motorrad);
            this.pParkhausHinzufügen.Controls.Add(this.tB_PKW);
            this.pParkhausHinzufügen.Controls.Add(this.tBParkhaus);
            this.pParkhausHinzufügen.Location = new System.Drawing.Point(34, 573);
            this.pParkhausHinzufügen.Name = "pParkhausHinzufügen";
            this.pParkhausHinzufügen.Size = new System.Drawing.Size(553, 297);
            this.pParkhausHinzufügen.TabIndex = 3;
            this.pParkhausHinzufügen.Visible = false;
            // 
            // tB_Strasse
            // 
            this.tB_Strasse.Location = new System.Drawing.Point(301, 177);
            this.tB_Strasse.Name = "tB_Strasse";
            this.tB_Strasse.Size = new System.Drawing.Size(204, 38);
            this.tB_Strasse.TabIndex = 8;
            this.tB_Strasse.Text = "Straße";
            this.tB_Strasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_Strasse.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tB_Strasse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingString);
            this.tB_Strasse.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // tB_PLZ
            // 
            this.tB_PLZ.Location = new System.Drawing.Point(301, 133);
            this.tB_PLZ.Name = "tB_PLZ";
            this.tB_PLZ.Size = new System.Drawing.Size(204, 38);
            this.tB_PLZ.TabIndex = 7;
            this.tB_PLZ.Text = "PLZ";
            this.tB_PLZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_PLZ.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tB_PLZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingDigits);
            this.tB_PLZ.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // tB_Ort
            // 
            this.tB_Ort.Location = new System.Drawing.Point(301, 89);
            this.tB_Ort.Name = "tB_Ort";
            this.tB_Ort.Size = new System.Drawing.Size(204, 38);
            this.tB_Ort.TabIndex = 6;
            this.tB_Ort.Text = "Ort";
            this.tB_Ort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_Ort.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tB_Ort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingString);
            this.tB_Ort.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // btnParkhaus
            // 
            this.btnParkhaus.Location = new System.Drawing.Point(13, 233);
            this.btnParkhaus.Name = "btnParkhaus";
            this.btnParkhaus.Size = new System.Drawing.Size(519, 47);
            this.btnParkhaus.TabIndex = 5;
            this.btnParkhaus.Text = "Parkhaus hinzufügen";
            this.btnParkhaus.UseVisualStyleBackColor = true;
            this.btnParkhaus.Click += new System.EventHandler(this.btnParkhaus_Click);
            // 
            // lblAnzParkplätze
            // 
            this.lblAnzParkplätze.AutoSize = true;
            this.lblAnzParkplätze.Location = new System.Drawing.Point(14, 54);
            this.lblAnzParkplätze.Name = "lblAnzParkplätze";
            this.lblAnzParkplätze.Size = new System.Drawing.Size(301, 32);
            this.lblAnzParkplätze.TabIndex = 4;
            this.lblAnzParkplätze.Text = "Anzahl der Parkplätze:";
            // 
            // tB_LKW
            // 
            this.tB_LKW.Location = new System.Drawing.Point(82, 177);
            this.tB_LKW.Name = "tB_LKW";
            this.tB_LKW.Size = new System.Drawing.Size(150, 38);
            this.tB_LKW.TabIndex = 3;
            this.tB_LKW.Text = "LKW";
            this.tB_LKW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_LKW.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tB_LKW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingDigits);
            this.tB_LKW.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // tB_Motorrad
            // 
            this.tB_Motorrad.Location = new System.Drawing.Point(82, 133);
            this.tB_Motorrad.Name = "tB_Motorrad";
            this.tB_Motorrad.Size = new System.Drawing.Size(150, 38);
            this.tB_Motorrad.TabIndex = 2;
            this.tB_Motorrad.Text = "Motorrad";
            this.tB_Motorrad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_Motorrad.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tB_Motorrad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingDigits);
            this.tB_Motorrad.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // tB_PKW
            // 
            this.tB_PKW.Location = new System.Drawing.Point(82, 89);
            this.tB_PKW.Name = "tB_PKW";
            this.tB_PKW.Size = new System.Drawing.Size(150, 38);
            this.tB_PKW.TabIndex = 1;
            this.tB_PKW.Text = "PKW";
            this.tB_PKW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_PKW.Enter += new System.EventHandler(this.deleteTextOnClick);
            this.tB_PKW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIncomingDigits);
            this.tB_PKW.Leave += new System.EventHandler(this.setPreviousTextIfEmpty);
            // 
            // tBParkhaus
            // 
            this.tBParkhaus.Location = new System.Drawing.Point(20, 13);
            this.tBParkhaus.Name = "tBParkhaus";
            this.tBParkhaus.ReadOnly = true;
            this.tBParkhaus.Size = new System.Drawing.Size(512, 38);
            this.tBParkhaus.TabIndex = 0;
            this.tBParkhaus.Text = "Parkhaus ";
            this.tBParkhaus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Fahrzeugverwaltung
            // 
            this.ClientSize = new System.Drawing.Size(854, 928);
            this.Controls.Add(this.pParkhausHinzufügen);
            this.Controls.Add(this.pFahrzeugHinzufügen);
            this.Controls.Add(this.pFahrzeugSuchen);
            this.Name = "Fahrzeugverwaltung";
            this.Text = "Fahrzeug suchen";
            this.pFahrzeugSuchen.ResumeLayout(false);
            this.pFahrzeugSuchen.PerformLayout();
            this.pFahrzeugHinzufügen.ResumeLayout(false);
            this.pFahrzeugHinzufügen.PerformLayout();
            this.pLKW.ResumeLayout(false);
            this.pLKW.PerformLayout();
            this.pMotorrad.ResumeLayout(false);
            this.pMotorrad.PerformLayout();
            this.PPKW.ResumeLayout(false);
            this.PPKW.PerformLayout();
            this.pParkhausHinzufügen.ResumeLayout(false);
            this.pParkhausHinzufügen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labKennz;
        private System.Windows.Forms.TextBox tBoxKennzOrt;
        private System.Windows.Forms.TextBox tBoxKennzZus;
        private System.Windows.Forms.TextBox tBoxKennzNum;
        private System.Windows.Forms.Panel pFahrzeugSuchen;
        private System.Windows.Forms.Panel pFahrzeugHinzufügen;
        private System.Windows.Forms.ComboBox cBFahrzeugTyp;
        private System.Windows.Forms.Label lblFahrzeugTyp;
        private System.Windows.Forms.FlowLayoutPanel PPKW;
        private System.Windows.Forms.TextBox tB_Leistung;
        private System.Windows.Forms.TextBox tB_Preis;
        private System.Windows.Forms.TextBox tB_Erstzulassung;
        private System.Windows.Forms.TextBox tB_Modell;
        private System.Windows.Forms.TextBox tB_Hersteller;
        private System.Windows.Forms.ComboBox cBSchadstoffklasse;
        private System.Windows.Forms.Panel pLKW;
        private System.Windows.Forms.TextBox tB_Zuladung;
        private System.Windows.Forms.TextBox tB_AnzAchsen;
        private System.Windows.Forms.Panel pMotorrad;
        private System.Windows.Forms.TextBox tBM_Hubraum;
        private System.Windows.Forms.TextBox tB_Hubraum;
        private System.Windows.Forms.Button btnSaveNewFahrzeug;
        private System.Windows.Forms.Label lblParkplatz;
        private System.Windows.Forms.Label lblParkhaus;
        private System.Windows.Forms.ComboBox cBParkplatz;
        private System.Windows.Forms.ComboBox cBParkhaus;
        private System.Windows.Forms.Panel pParkhausHinzufügen;
        private System.Windows.Forms.Label lblAnzParkplätze;
        private System.Windows.Forms.TextBox tB_LKW;
        private System.Windows.Forms.TextBox tB_Motorrad;
        private System.Windows.Forms.TextBox tB_PKW;
        private System.Windows.Forms.TextBox tBParkhaus;
        private System.Windows.Forms.TextBox tB_Strasse;
        private System.Windows.Forms.TextBox tB_PLZ;
        private System.Windows.Forms.TextBox tB_Ort;
        private System.Windows.Forms.Button btnParkhaus;
        private System.Windows.Forms.TextBox tBK_Hen;
        private System.Windows.Forms.TextBox tBK_Zei;
        private System.Windows.Forms.TextBox tBK_Ken;
    }
}

