namespace Diet_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.attivitàFisicabox = new System.Windows.Forms.ComboBox();
            this.sportBox = new System.Windows.Forms.ComboBox();
            this.sessoBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.altezzaBox = new System.Windows.Forms.TextBox();
            this.pesoBox = new System.Windows.Forms.TextBox();
            this.etàBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.salva = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bfBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // attivitàFisicabox
            // 
            this.attivitàFisicabox.FormattingEnabled = true;
            this.attivitàFisicabox.Items.AddRange(new object[] {
            "Lavoro sedentario(nessuna attività)",
            "Esercizio leggero(1-2 volte a settimana)",
            "Esercizio moderato(3-5 volte a settimana)",
            "Esercizio pesante(6-7 volte a settimana)",
            "Atleta(2 volte al giorno ogni giorno)"});
            this.attivitàFisicabox.Location = new System.Drawing.Point(131, 132);
            this.attivitàFisicabox.Name = "attivitàFisicabox";
            this.attivitàFisicabox.Size = new System.Drawing.Size(121, 21);
            this.attivitàFisicabox.TabIndex = 0;
            // 
            // sportBox
            // 
            this.sportBox.FormattingEnabled = true;
            this.sportBox.Items.AddRange(new object[] {
            "Alpinismo",
            "Arrampicata",
            "Arti marziali",
            "Atletica leggera",
            "Badminton",
            "Bodybuilding",
            "Calisthenics",
            "Canottaggio",
            "Ciclismo",
            "Equitazione",
            "Ginnastica ",
            "Golf",
            "Nuoto",
            "Powerlifting",
            "Scherma",
            "Strongman"});
            this.sportBox.Location = new System.Drawing.Point(337, 132);
            this.sportBox.Name = "sportBox";
            this.sportBox.Size = new System.Drawing.Size(121, 21);
            this.sportBox.TabIndex = 1;
            // 
            // sessoBox
            // 
            this.sessoBox.FormattingEnabled = true;
            this.sessoBox.Items.AddRange(new object[] {
            "Maschio",
            "Femmina"});
            this.sessoBox.Location = new System.Drawing.Point(131, 105);
            this.sessoBox.Name = "sessoBox";
            this.sessoBox.Size = new System.Drawing.Size(121, 21);
            this.sessoBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Attività fisica";
            // 
            // altezzaBox
            // 
            this.altezzaBox.Location = new System.Drawing.Point(131, 79);
            this.altezzaBox.Name = "altezzaBox";
            this.altezzaBox.Size = new System.Drawing.Size(121, 20);
            this.altezzaBox.TabIndex = 4;
            // 
            // pesoBox
            // 
            this.pesoBox.Location = new System.Drawing.Point(131, 53);
            this.pesoBox.Name = "pesoBox";
            this.pesoBox.Size = new System.Drawing.Size(121, 20);
            this.pesoBox.TabIndex = 4;
            // 
            // etàBox
            // 
            this.etàBox.Location = new System.Drawing.Point(131, 27);
            this.etàBox.Name = "etàBox";
            this.etàBox.Size = new System.Drawing.Size(121, 20);
            this.etàBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sesso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Altezza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Età";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sport";
            // 
            // salva
            // 
            this.salva.Location = new System.Drawing.Point(131, 189);
            this.salva.Name = "salva";
            this.salva.Size = new System.Drawing.Size(121, 38);
            this.salva.TabIndex = 5;
            this.salva.Text = "Salva";
            this.salva.UseVisualStyleBackColor = true;
            this.salva.Click += new System.EventHandler(this.salva_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Body fat (opzionale)";
            // 
            // bfBox
            // 
            this.bfBox.Location = new System.Drawing.Point(131, 160);
            this.bfBox.Name = "bfBox";
            this.bfBox.Size = new System.Drawing.Size(121, 20);
            this.bfBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 553);
            this.Controls.Add(this.bfBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.salva);
            this.Controls.Add(this.etàBox);
            this.Controls.Add(this.pesoBox);
            this.Controls.Add(this.altezzaBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sessoBox);
            this.Controls.Add(this.sportBox);
            this.Controls.Add(this.attivitàFisicabox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox attivitàFisicabox;
        private System.Windows.Forms.ComboBox sportBox;
        private System.Windows.Forms.ComboBox sessoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox altezzaBox;
        private System.Windows.Forms.TextBox pesoBox;
        private System.Windows.Forms.TextBox etàBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button salva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bfBox;
    }
}

