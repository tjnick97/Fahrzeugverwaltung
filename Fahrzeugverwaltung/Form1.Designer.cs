namespace Fahrzeugverwaltung
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBoxKennzNum = new System.Windows.Forms.TextBox();
            this.tBoxKennzZus = new System.Windows.Forms.TextBox();
            this.tBoxKennzOrt = new System.Windows.Forms.TextBox();
            this.labKennz = new System.Windows.Forms.Label();
            this.Fahrzeugverwaltung = new System.Windows.Forms.MenuStrip();
            this.tSMFahrzeugSuche = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMStellplatzänderung = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMFahrzeugHinzufügen = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.Fahrzeugverwaltung.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tBoxKennzNum);
            this.panel2.Controls.Add(this.tBoxKennzZus);
            this.panel2.Controls.Add(this.tBoxKennzOrt);
            this.panel2.Controls.Add(this.labKennz);
            this.panel2.Location = new System.Drawing.Point(12, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 70);
            this.panel2.TabIndex = 0;
            // 
            // tBoxKennzNum
            // 
            this.tBoxKennzNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBoxKennzNum.Location = new System.Drawing.Point(355, 14);
            this.tBoxKennzNum.MaxLength = 4;
            this.tBoxKennzNum.Name = "tBoxKennzNum";
            this.tBoxKennzNum.Size = new System.Drawing.Size(67, 20);
            this.tBoxKennzNum.TabIndex = 3;
            this.tBoxKennzNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxKennzZus
            // 
            this.tBoxKennzZus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBoxKennzZus.Location = new System.Drawing.Point(282, 14);
            this.tBoxKennzZus.MaxLength = 2;
            this.tBoxKennzZus.Name = "tBoxKennzZus";
            this.tBoxKennzZus.Size = new System.Drawing.Size(67, 20);
            this.tBoxKennzZus.TabIndex = 2;
            this.tBoxKennzZus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxKennzOrt
            // 
            this.tBoxKennzOrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBoxKennzOrt.Location = new System.Drawing.Point(209, 14);
            this.tBoxKennzOrt.MaxLength = 3;
            this.tBoxKennzOrt.Name = "tBoxKennzOrt";
            this.tBoxKennzOrt.Size = new System.Drawing.Size(67, 20);
            this.tBoxKennzOrt.TabIndex = 1;
            this.tBoxKennzOrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labKennz
            // 
            this.labKennz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labKennz.AutoSize = true;
            this.labKennz.Location = new System.Drawing.Point(14, 16);
            this.labKennz.Name = "labKennz";
            this.labKennz.Size = new System.Drawing.Size(72, 13);
            this.labKennz.TabIndex = 0;
            this.labKennz.Text = "Kennzeichen:";
            this.labKennz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fahrzeugverwaltung
            // 
            this.Fahrzeugverwaltung.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.Fahrzeugverwaltung.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMFahrzeugSuche,
            this.tSMStellplatzänderung,
            this.tSMFahrzeugHinzufügen});
            this.Fahrzeugverwaltung.Location = new System.Drawing.Point(0, 0);
            this.Fahrzeugverwaltung.Name = "Fahrzeugverwaltung";
            this.Fahrzeugverwaltung.Size = new System.Drawing.Size(722, 24);
            this.Fahrzeugverwaltung.TabIndex = 1;
            // 
            // tSMFahrzeugSuche
            // 
            this.tSMFahrzeugSuche.Name = "tSMFahrzeugSuche";
            this.tSMFahrzeugSuche.Size = new System.Drawing.Size(98, 20);
            this.tSMFahrzeugSuche.Text = "Fahrzeugsuche";
            // 
            // tSMStellplatzänderung
            // 
            this.tSMStellplatzänderung.Name = "tSMStellplatzänderung";
            this.tSMStellplatzänderung.Size = new System.Drawing.Size(117, 20);
            this.tSMStellplatzänderung.Text = "Stellplatzänderung";
            // 
            // tSMFahrzeugHinzufügen
            // 
            this.tSMFahrzeugHinzufügen.Name = "tSMFahrzeugHinzufügen";
            this.tSMFahrzeugHinzufügen.Size = new System.Drawing.Size(130, 20);
            this.tSMFahrzeugHinzufügen.Text = "Fahrzeug hinzufügen";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(722, 666);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Fahrzeugverwaltung);
            this.MainMenuStrip = this.Fahrzeugverwaltung;
            this.Name = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Fahrzeugverwaltung.ResumeLayout(false);
            this.Fahrzeugverwaltung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labKennz;
        private System.Windows.Forms.TextBox tBoxKennzNum;
        private System.Windows.Forms.TextBox tBoxKennzZus;
        private System.Windows.Forms.TextBox tBoxKennzOrt;
        private System.Windows.Forms.MenuStrip Fahrzeugverwaltung;
        private System.Windows.Forms.ToolStripMenuItem tSMFahrzeugSuche;
        private System.Windows.Forms.ToolStripMenuItem tSMStellplatzänderung;
        private System.Windows.Forms.ToolStripMenuItem tSMFahrzeugHinzufügen;
    }
}

