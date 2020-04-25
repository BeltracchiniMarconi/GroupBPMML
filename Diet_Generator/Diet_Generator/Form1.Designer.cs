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
            this.label8 = new System.Windows.Forms.Label();
            this.basaleM = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.kcalC = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.eLabel = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.sLabel = new System.Windows.Forms.Label();
            this.afLabel = new System.Windows.Forms.Label();
            this.bfLabel = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.spiegazioneBox = new System.Windows.Forms.Label();
            this.kcalS = new System.Windows.Forms.Label();
            this.nkcal = new System.Windows.Forms.Label();
            this.kcaltoeat = new System.Windows.Forms.Label();
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
            this.attivitàFisicabox.SelectedIndexChanged += new System.EventHandler(this.attivitàFisicabox_SelectedIndexChanged);
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
            this.salva.Location = new System.Drawing.Point(131, 188);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Metabolismo basale:";
            // 
            // basaleM
            // 
            this.basaleM.AutoSize = true;
            this.basaleM.Location = new System.Drawing.Point(603, 213);
            this.basaleM.Name = "basaleM";
            this.basaleM.Size = new System.Drawing.Size(0, 13);
            this.basaleM.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(500, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kcal consigliate:";
            // 
            // kcalC
            // 
            this.kcalC.AutoSize = true;
            this.kcalC.Location = new System.Drawing.Point(603, 235);
            this.kcalC.Name = "kcalC";
            this.kcalC.Size = new System.Drawing.Size(0, 13);
            this.kcalC.TabIndex = 9;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(258, 167);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(19, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "(?)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(500, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Body fat:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(500, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Età:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(500, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Peso:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(500, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Altezza:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(500, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Sesso:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(500, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Attività fisica:";
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Location = new System.Drawing.Point(603, 34);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(0, 13);
            this.eLabel.TabIndex = 17;
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Location = new System.Drawing.Point(603, 60);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(0, 13);
            this.pLabel.TabIndex = 17;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(603, 86);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(0, 13);
            this.aLabel.TabIndex = 17;
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Location = new System.Drawing.Point(603, 113);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(0, 13);
            this.sLabel.TabIndex = 17;
            // 
            // afLabel
            // 
            this.afLabel.AutoSize = true;
            this.afLabel.Location = new System.Drawing.Point(603, 140);
            this.afLabel.Name = "afLabel";
            this.afLabel.Size = new System.Drawing.Size(0, 13);
            this.afLabel.TabIndex = 17;
            // 
            // bfLabel
            // 
            this.bfLabel.AutoSize = true;
            this.bfLabel.Location = new System.Drawing.Point(603, 167);
            this.bfLabel.Name = "bfLabel";
            this.bfLabel.Size = new System.Drawing.Size(0, 13);
            this.bfLabel.TabIndex = 17;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(484, 213);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(19, 13);
            this.linkLabel2.TabIndex = 18;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "(?)";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(603, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "Mantenimento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(698, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 36);
            this.button3.TabIndex = 19;
            this.button3.Text = "Bulk";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // spiegazioneBox
            // 
            this.spiegazioneBox.AutoSize = true;
            this.spiegazioneBox.Location = new System.Drawing.Point(503, 322);
            this.spiegazioneBox.Name = "spiegazioneBox";
            this.spiegazioneBox.Size = new System.Drawing.Size(0, 13);
            this.spiegazioneBox.TabIndex = 20;
            // 
            // kcalS
            // 
            this.kcalS.AutoSize = true;
            this.kcalS.Location = new System.Drawing.Point(503, 380);
            this.kcalS.Name = "kcalS";
            this.kcalS.Size = new System.Drawing.Size(83, 13);
            this.kcalS.TabIndex = 20;
            this.kcalS.Text = "Kcal da seguire:";
            // 
            // nkcal
            // 
            this.nkcal.AutoSize = true;
            this.nkcal.Location = new System.Drawing.Point(583, 380);
            this.nkcal.Name = "nkcal";
            this.nkcal.Size = new System.Drawing.Size(0, 13);
            this.nkcal.TabIndex = 21;
            // 
            // kcaltoeat
            // 
            this.kcaltoeat.AutoSize = true;
            this.kcaltoeat.Location = new System.Drawing.Point(583, 380);
            this.kcaltoeat.Name = "kcaltoeat";
            this.kcaltoeat.Size = new System.Drawing.Size(0, 13);
            this.kcaltoeat.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 451);
            this.Controls.Add(this.kcaltoeat);
            this.Controls.Add(this.nkcal);
            this.Controls.Add(this.kcalS);
            this.Controls.Add(this.spiegazioneBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.bfLabel);
            this.Controls.Add(this.afLabel);
            this.Controls.Add(this.sLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.kcalC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.basaleM);
            this.Controls.Add(this.label8);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label basaleM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label kcalC;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.Label afLabel;
        private System.Windows.Forms.Label bfLabel;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label spiegazioneBox;
        private System.Windows.Forms.Label kcalS;
        private System.Windows.Forms.Label nkcal;
        private System.Windows.Forms.Label kcaltoeat;
    }
}

