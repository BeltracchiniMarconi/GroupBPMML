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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // attivitàFisicabox
            // 
            this.attivitàFisicabox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attivitàFisicabox.FormattingEnabled = true;
            this.attivitàFisicabox.Items.AddRange(new object[] {
            "Lavoro sedentario(nessuna attività)",
            "Esercizio leggero(1-2 volte a settimana)",
            "Esercizio moderato(3-5 volte a settimana)",
            "Esercizio pesante(6-7 volte a settimana)",
            "Atleta(2 volte al giorno ogni giorno)"});
            this.attivitàFisicabox.Location = new System.Drawing.Point(707, 225);
            this.attivitàFisicabox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.attivitàFisicabox.Name = "attivitàFisicabox";
            this.attivitàFisicabox.Size = new System.Drawing.Size(180, 35);
            this.attivitàFisicabox.TabIndex = 0;
            this.attivitàFisicabox.SelectedIndexChanged += new System.EventHandler(this.attivitàFisicabox_SelectedIndexChanged);
            // 
            // sportBox
            // 
            this.sportBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.sportBox.Location = new System.Drawing.Point(707, 300);
            this.sportBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sportBox.Name = "sportBox";
            this.sportBox.Size = new System.Drawing.Size(180, 35);
            this.sportBox.TabIndex = 1;
            // 
            // sessoBox
            // 
            this.sessoBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessoBox.FormattingEnabled = true;
            this.sessoBox.Items.AddRange(new object[] {
            "Maschio",
            "Femmina"});
            this.sessoBox.Location = new System.Drawing.Point(707, 143);
            this.sessoBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sessoBox.Name = "sessoBox";
            this.sessoBox.Size = new System.Drawing.Size(180, 35);
            this.sessoBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Attività fisica";
            // 
            // altezzaBox
            // 
            this.altezzaBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altezzaBox.Location = new System.Drawing.Point(127, 297);
            this.altezzaBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.altezzaBox.Name = "altezzaBox";
            this.altezzaBox.Size = new System.Drawing.Size(180, 33);
            this.altezzaBox.TabIndex = 4;
            // 
            // pesoBox
            // 
            this.pesoBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoBox.Location = new System.Drawing.Point(127, 223);
            this.pesoBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pesoBox.Name = "pesoBox";
            this.pesoBox.Size = new System.Drawing.Size(180, 33);
            this.pesoBox.TabIndex = 4;
            // 
            // etàBox
            // 
            this.etàBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etàBox.Location = new System.Drawing.Point(127, 141);
            this.etàBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.etàBox.Name = "etàBox";
            this.etàBox.Size = new System.Drawing.Size(180, 33);
            this.etàBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(589, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sesso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Altezza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Età";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(599, 303);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sport";
            // 
            // salva
            // 
            this.salva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salva.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salva.Location = new System.Drawing.Point(137, 407);
            this.salva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salva.Name = "salva";
            this.salva.Size = new System.Drawing.Size(182, 58);
            this.salva.TabIndex = 5;
            this.salva.Text = "SALVA";
            this.salva.UseVisualStyleBackColor = true;
            this.salva.Click += new System.EventHandler(this.salva_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 365);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "Body fat (opzionale)";
            // 
            // bfBox
            // 
            this.bfBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfBox.Location = new System.Drawing.Point(707, 362);
            this.bfBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bfBox.Name = "bfBox";
            this.bfBox.Size = new System.Drawing.Size(180, 33);
            this.bfBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 250);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 27);
            this.label8.TabIndex = 8;
            this.label8.Text = "Metabolismo basale:";
            // 
            // basaleM
            // 
            this.basaleM.AutoSize = true;
            this.basaleM.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basaleM.Location = new System.Drawing.Point(327, 246);
            this.basaleM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.basaleM.Name = "basaleM";
            this.basaleM.Size = new System.Drawing.Size(0, 27);
            this.basaleM.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(500, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 27);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kcal consigliate:";
            // 
            // kcalC
            // 
            this.kcalC.AutoSize = true;
            this.kcalC.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcalC.Location = new System.Drawing.Point(717, 202);
            this.kcalC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kcalC.Name = "kcalC";
            this.kcalC.Size = new System.Drawing.Size(0, 27);
            this.kcalC.TabIndex = 9;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(412, 365);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 27);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "(?)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(572, 100);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 27);
            this.label10.TabIndex = 16;
            this.label10.Text = "Body fat:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(160, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 27);
            this.label11.TabIndex = 11;
            this.label11.Text = "Età:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(149, 64);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 27);
            this.label12.TabIndex = 12;
            this.label12.Text = "Peso:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(132, 106);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 27);
            this.label13.TabIndex = 13;
            this.label13.Text = "Altezza:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(600, 18);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 27);
            this.label14.TabIndex = 14;
            this.label14.Text = "Sesso:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(524, 58);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 27);
            this.label15.TabIndex = 15;
            this.label15.Text = "Attività fisica:";
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eLabel.Location = new System.Drawing.Point(303, 24);
            this.eLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(0, 27);
            this.eLabel.TabIndex = 17;
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLabel.Location = new System.Drawing.Point(303, 64);
            this.pLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(0, 27);
            this.pLabel.TabIndex = 17;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabel.Location = new System.Drawing.Point(303, 104);
            this.aLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(0, 27);
            this.aLabel.TabIndex = 17;
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabel.Location = new System.Drawing.Point(697, 17);
            this.sLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(0, 27);
            this.sLabel.TabIndex = 17;
            // 
            // afLabel
            // 
            this.afLabel.AutoSize = true;
            this.afLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afLabel.Location = new System.Drawing.Point(697, 58);
            this.afLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.afLabel.Name = "afLabel";
            this.afLabel.Size = new System.Drawing.Size(0, 27);
            this.afLabel.TabIndex = 17;
            // 
            // bfLabel
            // 
            this.bfLabel.AutoSize = true;
            this.bfLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfLabel.Location = new System.Drawing.Point(697, 100);
            this.bfLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bfLabel.Name = "bfLabel";
            this.bfLabel.Size = new System.Drawing.Size(0, 27);
            this.bfLabel.TabIndex = 17;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(51, 250);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(37, 27);
            this.linkLabel2.TabIndex = 18;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "(?)";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(62, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(190, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 55);
            this.button2.TabIndex = 19;
            this.button2.Text = "Mantenimento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(424, 26);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 55);
            this.button3.TabIndex = 19;
            this.button3.Text = "Bulk";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // spiegazioneBox
            // 
            this.spiegazioneBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.spiegazioneBox.AutoSize = true;
            this.spiegazioneBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spiegazioneBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spiegazioneBox.Location = new System.Drawing.Point(91, 344);
            this.spiegazioneBox.Margin = new System.Windows.Forms.Padding(0);
            this.spiegazioneBox.Name = "spiegazioneBox";
            this.spiegazioneBox.Size = new System.Drawing.Size(0, 25);
            this.spiegazioneBox.TabIndex = 20;
            // 
            // kcalS
            // 
            this.kcalS.AutoSize = true;
            this.kcalS.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcalS.Location = new System.Drawing.Point(149, 199);
            this.kcalS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kcalS.Name = "kcalS";
            this.kcalS.Size = new System.Drawing.Size(171, 27);
            this.kcalS.TabIndex = 20;
            this.kcalS.Text = "Kcal da seguire:";
            // 
            // nkcal
            // 
            this.nkcal.AutoSize = true;
            this.nkcal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nkcal.Location = new System.Drawing.Point(347, 199);
            this.nkcal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nkcal.Name = "nkcal";
            this.nkcal.Size = new System.Drawing.Size(0, 27);
            this.nkcal.TabIndex = 21;
            // 
            // kcaltoeat
            // 
            this.kcaltoeat.AutoSize = true;
            this.kcaltoeat.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcaltoeat.Location = new System.Drawing.Point(347, 199);
            this.kcaltoeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kcaltoeat.Name = "kcaltoeat";
            this.kcaltoeat.Size = new System.Drawing.Size(0, 27);
            this.kcaltoeat.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kcalS);
            this.panel1.Controls.Add(this.kcaltoeat);
            this.panel1.Controls.Add(this.nkcal);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.spiegazioneBox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.bfLabel);
            this.panel1.Controls.Add(this.kcalC);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.afLabel);
            this.panel1.Controls.Add(this.basaleM);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.sLabel);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.aLabel);
            this.panel1.Controls.Add(this.eLabel);
            this.panel1.Controls.Add(this.pLabel);
            this.panel1.Location = new System.Drawing.Point(241, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 490);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(383, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 115);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.altezzaBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.salva);
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pesoBox);
            this.panel3.Controls.Add(this.sportBox);
            this.panel3.Controls.Add(this.bfBox);
            this.panel3.Controls.Add(this.etàBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.attivitàFisicabox);
            this.panel3.Controls.Add(this.sessoBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(215, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1049, 537);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Chartreuse;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 647);
            this.panel4.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.ForestGreen;
            this.panel5.Location = new System.Drawing.Point(0, 210);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 62);
            this.panel5.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 62);
            this.button5.TabIndex = 1;
            this.button5.Text = "DIET";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 62);
            this.button4.TabIndex = 0;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Chartreuse;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(197, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1110, 18);
            this.panel6.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(15, 22);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(106, 158);
            this.panel7.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1308, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 20);
            this.label16.TabIndex = 28;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1273, 210);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 20);
            this.label17.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1304, 647);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

