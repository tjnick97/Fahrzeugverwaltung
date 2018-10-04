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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fahrzeugSuchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fahrzeugHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkhausHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fahrzeugartenAusgebenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überprüfeSteuerlastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labKennz = new System.Windows.Forms.Label();
            this.tBoxKennzOrt = new System.Windows.Forms.TextBox();
            this.tBoxKennzZus = new System.Windows.Forms.TextBox();
            this.tBoxKennzNum = new System.Windows.Forms.TextBox();
            this.pFahrzeugSuchen = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pFahrzeugHinzufügen = new System.Windows.Forms.Panel();
            this.lblParkplatz = new System.Windows.Forms.Label();
            this.lblParkhaus = new System.Windows.Forms.Label();
            this.cBParkplatz = new System.Windows.Forms.ComboBox();
            this.cBParkhaus = new System.Windows.Forms.ComboBox();
            this.btnSaveNewFahrzeug = new System.Windows.Forms.Button();
            this.pLKW = new System.Windows.Forms.Panel();
            this.Zuladung = new System.Windows.Forms.TextBox();
            this.tBAnzAchsen = new System.Windows.Forms.TextBox();
            this.pMotorrad = new System.Windows.Forms.Panel();
            this.tBHubraumMot = new System.Windows.Forms.TextBox();
            this.PPKW = new System.Windows.Forms.FlowLayoutPanel();
            this.tBHubraum = new System.Windows.Forms.TextBox();
            this.tBLeistung = new System.Windows.Forms.TextBox();
            this.cBSchadstoffklasse = new System.Windows.Forms.ComboBox();
            this.tBAnschaffungspreis = new System.Windows.Forms.TextBox();
            this.tBErstzulassung = new System.Windows.Forms.TextBox();
            this.tBModell = new System.Windows.Forms.TextBox();
            this.tBHersteller = new System.Windows.Forms.TextBox();
            this.cBFahrzeugTyp = new System.Windows.Forms.ComboBox();
            this.lblFahrzeugTyp = new System.Windows.Forms.Label();
            this.pParkhausHinzufügen = new System.Windows.Forms.Panel();
            this.tBStrasse = new System.Windows.Forms.TextBox();
            this.tBPLZ = new System.Windows.Forms.TextBox();
            this.tBOrt = new System.Windows.Forms.TextBox();
            this.btnParkhaus = new System.Windows.Forms.Button();
            this.lblAnzParkplätze = new System.Windows.Forms.Label();
            this.tBLKW = new System.Windows.Forms.TextBox();
            this.tBMotorrad = new System.Windows.Forms.TextBox();
            this.tBPKW = new System.Windows.Forms.TextBox();
            this.tBParkhaus = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.pFahrzeugSuchen.SuspendLayout();
            this.pFahrzeugHinzufügen.SuspendLayout();
            this.pLKW.SuspendLayout();
            this.pMotorrad.SuspendLayout();
            this.PPKW.SuspendLayout();
            this.pParkhausHinzufügen.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fahrzeugSuchenToolStripMenuItem,
            this.fahrzeugHinzufügenToolStripMenuItem,
            this.parkhausHinzufügenToolStripMenuItem,
            this.fahrzeugartenAusgebenToolStripMenuItem,
            this.überprüfeSteuerlastToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // fahrzeugSuchenToolStripMenuItem
            // 
            this.fahrzeugSuchenToolStripMenuItem.Name = "fahrzeugSuchenToolStripMenuItem";
            this.fahrzeugSuchenToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.fahrzeugSuchenToolStripMenuItem.Text = "Fahrzeug suchen";
            this.fahrzeugSuchenToolStripMenuItem.Click += new System.EventHandler(this.fahrzeugSuchen_Click);
            // 
            // fahrzeugHinzufügenToolStripMenuItem
            // 
            this.fahrzeugHinzufügenToolStripMenuItem.Name = "fahrzeugHinzufügenToolStripMenuItem";
            this.fahrzeugHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.fahrzeugHinzufügenToolStripMenuItem.Text = "Fahrzeug hinzufügen";
            this.fahrzeugHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.fahrzeugHinzufügen_Click);
            // 
            // parkhausHinzufügenToolStripMenuItem
            // 
            this.parkhausHinzufügenToolStripMenuItem.Name = "parkhausHinzufügenToolStripMenuItem";
            this.parkhausHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.parkhausHinzufügenToolStripMenuItem.Text = "Parkhaus hinzufügen";
            this.parkhausHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.ParkhausHinzufügen_Click);
            // 
            // fahrzeugartenAusgebenToolStripMenuItem
            // 
            this.fahrzeugartenAusgebenToolStripMenuItem.Name = "fahrzeugartenAusgebenToolStripMenuItem";
            this.fahrzeugartenAusgebenToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.fahrzeugartenAusgebenToolStripMenuItem.Text = "Fahrzeugarten ausgeben";
            this.fahrzeugartenAusgebenToolStripMenuItem.Click += new System.EventHandler(this.FahrzeugartenAusgeben_Click);
            // 
            // überprüfeSteuerlastToolStripMenuItem
            // 
            this.überprüfeSteuerlastToolStripMenuItem.Name = "überprüfeSteuerlastToolStripMenuItem";
            this.überprüfeSteuerlastToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.überprüfeSteuerlastToolStripMenuItem.Text = "Überprüfe Steuerlast";
            this.überprüfeSteuerlastToolStripMenuItem.Click += new System.EventHandler(this.ÜberprüfeSteuerlast_Click);
            // 
            // labKennz
            // 
            this.labKennz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labKennz.AutoSize = true;
            this.labKennz.Location = new System.Drawing.Point(14, 16);
            this.labKennz.Name = "labKennz";
            this.labKennz.Size = new System.Drawing.Size(94, 17);
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
            this.tBoxKennzOrt.Size = new System.Drawing.Size(67, 22);
            this.tBoxKennzOrt.TabIndex = 1;
            this.tBoxKennzOrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxKennzZus
            // 
            this.tBoxKennzZus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBoxKennzZus.Location = new System.Drawing.Point(348, 14);
            this.tBoxKennzZus.MaxLength = 2;
            this.tBoxKennzZus.Name = "tBoxKennzZus";
            this.tBoxKennzZus.Size = new System.Drawing.Size(67, 22);
            this.tBoxKennzZus.TabIndex = 2;
            this.tBoxKennzZus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxKennzNum
            // 
            this.tBoxKennzNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBoxKennzNum.Location = new System.Drawing.Point(421, 14);
            this.tBoxKennzNum.MaxLength = 4;
            this.tBoxKennzNum.Name = "tBoxKennzNum";
            this.tBoxKennzNum.Size = new System.Drawing.Size(67, 22);
            this.tBoxKennzNum.TabIndex = 3;
            this.tBoxKennzNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.pFahrzeugHinzufügen.Controls.Add(this.lblParkplatz);
            this.pFahrzeugHinzufügen.Controls.Add(this.lblParkhaus);
            this.pFahrzeugHinzufügen.Controls.Add(this.cBParkplatz);
            this.pFahrzeugHinzufügen.Controls.Add(this.cBParkhaus);
            this.pFahrzeugHinzufügen.Controls.Add(this.btnSaveNewFahrzeug);
            this.pFahrzeugHinzufügen.Controls.Add(this.pLKW);
            this.pFahrzeugHinzufügen.Controls.Add(this.pMotorrad);
            this.pFahrzeugHinzufügen.Controls.Add(this.PPKW);
            this.pFahrzeugHinzufügen.Controls.Add(this.tBAnschaffungspreis);
            this.pFahrzeugHinzufügen.Controls.Add(this.tBErstzulassung);
            this.pFahrzeugHinzufügen.Controls.Add(this.tBModell);
            this.pFahrzeugHinzufügen.Controls.Add(this.tBHersteller);
            this.pFahrzeugHinzufügen.Controls.Add(this.cBFahrzeugTyp);
            this.pFahrzeugHinzufügen.Controls.Add(this.lblFahrzeugTyp);
            this.pFahrzeugHinzufügen.Location = new System.Drawing.Point(12, 166);
            this.pFahrzeugHinzufügen.Name = "pFahrzeugHinzufügen";
            this.pFahrzeugHinzufügen.Size = new System.Drawing.Size(698, 401);
            this.pFahrzeugHinzufügen.TabIndex = 2;
            this.pFahrzeugHinzufügen.Visible = false;
            // 
            // lblParkplatz
            // 
            this.lblParkplatz.AutoSize = true;
            this.lblParkplatz.Location = new System.Drawing.Point(219, 113);
            this.lblParkplatz.Name = "lblParkplatz";
            this.lblParkplatz.Size = new System.Drawing.Size(71, 17);
            this.lblParkplatz.TabIndex = 15;
            this.lblParkplatz.Text = "Parkplatz:";
            this.lblParkplatz.Visible = false;
            // 
            // lblParkhaus
            // 
            this.lblParkhaus.AutoSize = true;
            this.lblParkhaus.Location = new System.Drawing.Point(220, 68);
            this.lblParkhaus.Name = "lblParkhaus";
            this.lblParkhaus.Size = new System.Drawing.Size(72, 17);
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
            this.cBParkplatz.Size = new System.Drawing.Size(121, 24);
            this.cBParkplatz.TabIndex = 13;
            this.cBParkplatz.Visible = false;
            // 
            // cBParkhaus
            // 
            this.cBParkhaus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBParkhaus.FormattingEnabled = true;
            this.cBParkhaus.Location = new System.Drawing.Point(406, 65);
            this.cBParkhaus.Name = "cBParkhaus";
            this.cBParkhaus.Size = new System.Drawing.Size(121, 24);
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
            this.pLKW.Controls.Add(this.Zuladung);
            this.pLKW.Controls.Add(this.tBAnzAchsen);
            this.pLKW.Location = new System.Drawing.Point(106, 237);
            this.pLKW.Name = "pLKW";
            this.pLKW.Size = new System.Drawing.Size(200, 100);
            this.pLKW.TabIndex = 10;
            this.pLKW.Visible = false;
            // 
            // Zuladung
            // 
            this.Zuladung.Location = new System.Drawing.Point(3, 53);
            this.Zuladung.Name = "Zuladung";
            this.Zuladung.Size = new System.Drawing.Size(180, 22);
            this.Zuladung.TabIndex = 7;
            this.Zuladung.Text = "Zuladung";
            this.Zuladung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBAnzAchsen
            // 
            this.tBAnzAchsen.Location = new System.Drawing.Point(0, 9);
            this.tBAnzAchsen.Name = "tBAnzAchsen";
            this.tBAnzAchsen.Size = new System.Drawing.Size(180, 22);
            this.tBAnzAchsen.TabIndex = 6;
            this.tBAnzAchsen.Text = "Anz Achsen";
            this.tBAnzAchsen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pMotorrad
            // 
            this.pMotorrad.Controls.Add(this.tBHubraumMot);
            this.pMotorrad.Location = new System.Drawing.Point(55, 237);
            this.pMotorrad.Name = "pMotorrad";
            this.pMotorrad.Size = new System.Drawing.Size(200, 56);
            this.pMotorrad.TabIndex = 9;
            this.pMotorrad.Visible = false;
            // 
            // tBHubraumMot
            // 
            this.tBHubraumMot.Location = new System.Drawing.Point(3, 9);
            this.tBHubraumMot.Name = "tBHubraumMot";
            this.tBHubraumMot.Size = new System.Drawing.Size(180, 22);
            this.tBHubraumMot.TabIndex = 5;
            this.tBHubraumMot.Text = "Hubraum";
            this.tBHubraumMot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PPKW
            // 
            this.PPKW.Controls.Add(this.tBHubraum);
            this.PPKW.Controls.Add(this.tBLeistung);
            this.PPKW.Controls.Add(this.cBSchadstoffklasse);
            this.PPKW.Location = new System.Drawing.Point(22, 237);
            this.PPKW.Name = "PPKW";
            this.PPKW.Size = new System.Drawing.Size(211, 139);
            this.PPKW.TabIndex = 8;
            this.PPKW.Visible = false;
            // 
            // tBHubraum
            // 
            this.tBHubraum.Location = new System.Drawing.Point(3, 3);
            this.tBHubraum.Name = "tBHubraum";
            this.tBHubraum.Size = new System.Drawing.Size(180, 22);
            this.tBHubraum.TabIndex = 4;
            this.tBHubraum.Text = "Hubraum";
            this.tBHubraum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBLeistung
            // 
            this.tBLeistung.Location = new System.Drawing.Point(3, 31);
            this.tBLeistung.Name = "tBLeistung";
            this.tBLeistung.Size = new System.Drawing.Size(180, 22);
            this.tBLeistung.TabIndex = 5;
            this.tBLeistung.Text = "Leistung";
            this.tBLeistung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cBSchadstoffklasse
            // 
            this.cBSchadstoffklasse.FormattingEnabled = true;
            this.cBSchadstoffklasse.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cBSchadstoffklasse.Location = new System.Drawing.Point(3, 59);
            this.cBSchadstoffklasse.Name = "cBSchadstoffklasse";
            this.cBSchadstoffklasse.Size = new System.Drawing.Size(180, 24);
            this.cBSchadstoffklasse.TabIndex = 6;
            this.cBSchadstoffklasse.Text = "Schadstoff";
            // 
            // tBAnschaffungspreis
            // 
            this.tBAnschaffungspreis.Location = new System.Drawing.Point(22, 193);
            this.tBAnschaffungspreis.Name = "tBAnschaffungspreis";
            this.tBAnschaffungspreis.Size = new System.Drawing.Size(183, 22);
            this.tBAnschaffungspreis.TabIndex = 6;
            this.tBAnschaffungspreis.Text = "Preis";
            this.tBAnschaffungspreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBErstzulassung
            // 
            this.tBErstzulassung.Location = new System.Drawing.Point(22, 149);
            this.tBErstzulassung.Name = "tBErstzulassung";
            this.tBErstzulassung.Size = new System.Drawing.Size(183, 22);
            this.tBErstzulassung.TabIndex = 5;
            this.tBErstzulassung.Text = "Erstzulassung";
            this.tBErstzulassung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBModell
            // 
            this.tBModell.Location = new System.Drawing.Point(22, 61);
            this.tBModell.Name = "tBModell";
            this.tBModell.Size = new System.Drawing.Size(183, 22);
            this.tBModell.TabIndex = 3;
            this.tBModell.Text = "Modell";
            this.tBModell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBHersteller
            // 
            this.tBHersteller.Location = new System.Drawing.Point(22, 17);
            this.tBHersteller.Name = "tBHersteller";
            this.tBHersteller.Size = new System.Drawing.Size(183, 22);
            this.tBHersteller.TabIndex = 2;
            this.tBHersteller.Text = "Hersteller";
            this.tBHersteller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.cBFahrzeugTyp.Size = new System.Drawing.Size(121, 24);
            this.cBFahrzeugTyp.TabIndex = 1;
            this.cBFahrzeugTyp.SelectedValueChanged += new System.EventHandler(this.ShowFahrzeugTypPanel);
            // 
            // lblFahrzeugTyp
            // 
            this.lblFahrzeugTyp.AutoSize = true;
            this.lblFahrzeugTyp.Location = new System.Drawing.Point(219, 20);
            this.lblFahrzeugTyp.Name = "lblFahrzeugTyp";
            this.lblFahrzeugTyp.Size = new System.Drawing.Size(91, 17);
            this.lblFahrzeugTyp.TabIndex = 0;
            this.lblFahrzeugTyp.Text = "Fahrzeugtyp:";
            // 
            // pParkhausHinzufügen
            // 
            this.pParkhausHinzufügen.Controls.Add(this.tBStrasse);
            this.pParkhausHinzufügen.Controls.Add(this.tBPLZ);
            this.pParkhausHinzufügen.Controls.Add(this.tBOrt);
            this.pParkhausHinzufügen.Controls.Add(this.btnParkhaus);
            this.pParkhausHinzufügen.Controls.Add(this.lblAnzParkplätze);
            this.pParkhausHinzufügen.Controls.Add(this.tBLKW);
            this.pParkhausHinzufügen.Controls.Add(this.tBMotorrad);
            this.pParkhausHinzufügen.Controls.Add(this.tBPKW);
            this.pParkhausHinzufügen.Controls.Add(this.tBParkhaus);
            this.pParkhausHinzufügen.Location = new System.Drawing.Point(34, 573);
            this.pParkhausHinzufügen.Name = "pParkhausHinzufügen";
            this.pParkhausHinzufügen.Size = new System.Drawing.Size(553, 297);
            this.pParkhausHinzufügen.TabIndex = 3;
            this.pParkhausHinzufügen.Visible = false;
            // 
            // tBStrasse
            // 
            this.tBStrasse.Location = new System.Drawing.Point(301, 177);
            this.tBStrasse.Name = "tBStrasse";
            this.tBStrasse.Size = new System.Drawing.Size(204, 22);
            this.tBStrasse.TabIndex = 8;
            this.tBStrasse.Text = "Straße";
            this.tBStrasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBPLZ
            // 
            this.tBPLZ.Location = new System.Drawing.Point(301, 133);
            this.tBPLZ.Name = "tBPLZ";
            this.tBPLZ.Size = new System.Drawing.Size(204, 22);
            this.tBPLZ.TabIndex = 7;
            this.tBPLZ.Text = "PLZ";
            this.tBPLZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBOrt
            // 
            this.tBOrt.Location = new System.Drawing.Point(301, 89);
            this.tBOrt.Name = "tBOrt";
            this.tBOrt.Size = new System.Drawing.Size(204, 22);
            this.tBOrt.TabIndex = 6;
            this.tBOrt.Text = "Ort";
            this.tBOrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.lblAnzParkplätze.Size = new System.Drawing.Size(151, 17);
            this.lblAnzParkplätze.TabIndex = 4;
            this.lblAnzParkplätze.Text = "Anzahl der Parkplätze:";
            // 
            // tBLKW
            // 
            this.tBLKW.Location = new System.Drawing.Point(82, 177);
            this.tBLKW.Name = "tBLKW";
            this.tBLKW.Size = new System.Drawing.Size(150, 22);
            this.tBLKW.TabIndex = 3;
            this.tBLKW.Text = "LKW";
            this.tBLKW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBMotorrad
            // 
            this.tBMotorrad.Location = new System.Drawing.Point(82, 133);
            this.tBMotorrad.Name = "tBMotorrad";
            this.tBMotorrad.Size = new System.Drawing.Size(150, 22);
            this.tBMotorrad.TabIndex = 2;
            this.tBMotorrad.Text = "Motorrad";
            this.tBMotorrad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBPKW
            // 
            this.tBPKW.Location = new System.Drawing.Point(82, 89);
            this.tBPKW.Name = "tBPKW";
            this.tBPKW.Size = new System.Drawing.Size(150, 22);
            this.tBPKW.TabIndex = 1;
            this.tBPKW.Text = "PKW";
            this.tBPKW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBParkhaus
            // 
            this.tBParkhaus.Location = new System.Drawing.Point(20, 13);
            this.tBParkhaus.Name = "tBParkhaus";
            this.tBParkhaus.ReadOnly = true;
            this.tBParkhaus.Size = new System.Drawing.Size(512, 22);
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
            this.Controls.Add(this.menuStrip1);
            this.Name = "Fahrzeugverwaltung";
            this.Text = "Fahrzeug suchen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label labKennz;
        private System.Windows.Forms.TextBox tBoxKennzOrt;
        private System.Windows.Forms.TextBox tBoxKennzZus;
        private System.Windows.Forms.TextBox tBoxKennzNum;
        private System.Windows.Forms.Panel pFahrzeugSuchen;
        private System.Windows.Forms.ToolStripMenuItem fahrzeugSuchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fahrzeugHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parkhausHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fahrzeugartenAusgebenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überprüfeSteuerlastToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel pFahrzeugHinzufügen;
        private System.Windows.Forms.ComboBox cBFahrzeugTyp;
        private System.Windows.Forms.Label lblFahrzeugTyp;
        private System.Windows.Forms.FlowLayoutPanel PPKW;
        private System.Windows.Forms.TextBox tBLeistung;
        private System.Windows.Forms.TextBox tBAnschaffungspreis;
        private System.Windows.Forms.TextBox tBErstzulassung;
        private System.Windows.Forms.TextBox tBModell;
        private System.Windows.Forms.TextBox tBHersteller;
        private System.Windows.Forms.ComboBox cBSchadstoffklasse;
        private System.Windows.Forms.Panel pLKW;
        private System.Windows.Forms.TextBox Zuladung;
        private System.Windows.Forms.TextBox tBAnzAchsen;
        private System.Windows.Forms.Panel pMotorrad;
        private System.Windows.Forms.TextBox tBHubraumMot;
        private System.Windows.Forms.TextBox tBHubraum;
        private System.Windows.Forms.Button btnSaveNewFahrzeug;
        private System.Windows.Forms.Label lblParkplatz;
        private System.Windows.Forms.Label lblParkhaus;
        private System.Windows.Forms.ComboBox cBParkplatz;
        private System.Windows.Forms.ComboBox cBParkhaus;
        private System.Windows.Forms.Panel pParkhausHinzufügen;
        private System.Windows.Forms.Label lblAnzParkplätze;
        private System.Windows.Forms.TextBox tBLKW;
        private System.Windows.Forms.TextBox tBMotorrad;
        private System.Windows.Forms.TextBox tBPKW;
        private System.Windows.Forms.TextBox tBParkhaus;
        private System.Windows.Forms.TextBox tBStrasse;
        private System.Windows.Forms.TextBox tBPLZ;
        private System.Windows.Forms.TextBox tBOrt;
        private System.Windows.Forms.Button btnParkhaus;
    }
}

