using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diet_Generator
{
    public partial class Form1 : Form
    {
        Utente user = new Utente();
        public Form1()
        {
            InitializeComponent();
            sportBox.Hide();
            label6.Hide();
            kcalS.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
        }

        private void salva_Click(object sender, EventArgs e)
        {
            #region combos
            try
            {
                
                    string sesso = "";
                    string aF = "";
                    string sport = "";
                    switch (sessoBox.SelectedItem.ToString().Trim())
                    {
                        case "Maschio":
                            {
                                sesso = "Maschio";
                                break;
                            }
                        case "Femmina":
                            {
                                sesso = "Femmina";
                                break;
                            }
                    }
                    switch (attivitàFisicabox.SelectedItem.ToString().Trim())
                    {
                        case "Lavoro sedentario(nessuna attività)":
                            {
                                aF = "Lavoro sedentario(nessuna attività)";
                                break;
                            }
                        case "Esercizio leggero(1-2 volte a settimana)":
                            {
                                aF = "Esercizio leggero(1-2 volte a settimana)";
                                break;
                            }
                        case "Esercizio moderato(3-5 volte a settimana)":
                            {
                                aF = "Esercizio moderato(3-5 volte a settimana)";
                                break;
                            }
                        case "Esercizio pesante(6-7 volte a settimana)":
                            {
                                aF = "Esercizio pesante(6-7 volte a settimana)";
                                break;
                            }
                        case "Atleta(2 volte al giorno ogni giorno)":
                            {
                                aF = "Atleta(2 volte al giorno ogni giorno)";
                                break;
                            }
                    }
                    if (aF != "Lavoro sedentario(nessuna attività)")
                    {
                        switch (sportBox.SelectedItem.ToString().Trim())
                        {
                            case "Alpinismo":
                                {
                                    sport = "Alpinismo";
                                    break;
                                }
                            case "Arrampicita":
                                {
                                    sport = "Arrampicata";
                                    break;
                                }
                            case "Arti marziali":
                                {
                                    sport = "Arti marziali";
                                    break;
                                }
                            case "Atletica leggera":
                                {
                                    sport = "Atletica leggera";
                                    break;
                                }
                            case "Badminton":
                                {
                                    sport = "Badminton";
                                    break;
                                }
                            case "Bodybuilding":
                                {
                                    sport = "Bodybuilding";
                                    break;
                                }
                            case "Calisthenics":
                                {
                                    sport = "Calisthenics";
                                    break;
                                }
                            case "Canottaggio":
                                {
                                    sport = "Canottaggio";
                                    break;
                                }
                            case "Ciclismo":
                                {
                                    sport = "Ciclismo";
                                    break;
                                }
                            case "Equitazione":
                                {
                                    sport = "Equitazione";
                                    break;
                                }
                            case "Ginnastica":
                                {
                                    sport = "Ginnastica";
                                    break;
                                }
                            case "Golf":
                                {
                                    sport = "Golf";
                                    break;
                                }
                            case "Nuoto":
                                {
                                    sport = "Nuoto";
                                    break;
                                }
                            case "Powerlifting":
                                {
                                    sport = "Powerlifting";
                                    break;
                                }
                            case "Scherma":
                                {
                                    sport = "Scherma";
                                    break;
                                }
                            case "Strongman":
                                {
                                    sport = "Strongman";
                                    break;
                                }
                        }

                    }
                    #endregion
                    if (bfBox.Text == "")
                    {
                        Utente generic = new Utente(double.Parse(altezzaBox.Text), double.Parse(pesoBox.Text), sesso, aF, int.Parse(etàBox.Text), sport);
                      
                        user = generic;
                    }
                    else
                    {
                        Utente generic = new Utente(double.Parse(altezzaBox.Text), double.Parse(pesoBox.Text), sesso, aF, int.Parse(etàBox.Text), sport, int.Parse(bfBox.Text));
                
                        user = generic;
                    }
                    user.Kcal = CalcoloKcal();
                    kcalC.Text = Convert.ToString(user.Kcal) + " kcal";
                    eLabel.Text = Convert.ToString(user.Età);
                    pLabel.Text = Convert.ToString(user.Peso);
                    aLabel.Text = Convert.ToString(user.Altezza);
                    sLabel.Text = user.Sesso;
                    afLabel.Text = user.AttivitàFisica;
                    if(user.BodyFat != 0)
                    {
                    bfLabel.Text = Convert.ToString(user.BodyFat);
                    }
                    else
                    {
                    bfLabel.Text = "Body fat non specificata";
                    }
                #region graphics
                etàBox.Clear();
                pesoBox.Clear();
                altezzaBox.Clear();
                bfBox.Clear();
                sessoBox.ResetText();
                attivitàFisicabox.ResetText();
                button1.Show();
                button2.Show();
                button3.Show();
                #endregion
            }
            catch
            {
                MessageBox.Show("Compila ogni campo");
            }
        }

        private void attivitàFisicabox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(attivitàFisicabox.SelectedItem.ToString().Trim() != "Lavoro sedentario(nessuna attività)")
            {
                label6.Show();
                sportBox.Show();
            }
            if(attivitàFisicabox.SelectedItem.ToString().Trim() == "Lavoro sedentario(nessuna attività)")
            {
                sportBox.Hide();
                label6.Hide();
            }
        }
        double CalcoloKcal()
        {
            double kcal = 0;
            if(user.Età > 0 && user.Età < 3)
            {
                kcal = 59.2 * user.Peso - 31;
                basaleM.Text = Convert.ToString(kcal) + " kcal";
            }
            if(user.Età >= 3 && user.Età < 9)
            {
                kcal = 22.7 * user.Peso + 504;
                basaleM.Text = Convert.ToString(kcal) + " kcal";
            }
            if(user.Età > 9 && user.Età <= 17)
            {
                kcal = 17.7 * user.Peso + 650;
                basaleM.Text = Convert.ToString(kcal) + " kcal";
            }
            if(user.Età >= 18 && user.Età <= 29)
            {
                kcal = 15.3 * user.Peso + 679;
                basaleM.Text = Convert.ToString(kcal) + " kcal";
            }
            if(user.Età >= 30 && user.Età <= 59)
            {
                kcal = 11.6 * user.Peso + 879;
                basaleM.Text = Convert.ToString(kcal) + " kcal";
            }
            if(user.Età > 59 && user.Età <= 75)
            {
                kcal = 11.9 * user.Peso + 700;
                basaleM.Text = Convert.ToString(kcal) + " kcal";
            }
            if(user.Età >75)
            {
                kcal = 8.4 * user.Peso + 819;
                basaleM.Text = Convert.ToString(kcal) + " kcal";
            }
            if (user.AttivitàFisica == "Lavoro sedentario(nessuna attività)")
            {
                if(user.Sesso == "Maschio")
                {
                    kcal = kcal * 1.4;
                }
                if(user.Sesso == "Femmina")
                {
                    kcal = kcal * 1.0;
                }
            }
            if(user.AttivitàFisica == "Esercizio leggero(1-2 volte a settimana)")
            {
                if (user.Sesso == "Maschio")
                {
                    kcal = kcal * 1.5;
                }
                if (user.Sesso == "Femmina")
                {
                    kcal = kcal * 1.4;
                }
            }
            if(user.AttivitàFisica == "Esercizio moderato(3-5 volte a settimana)")
            {
                if (user.Sesso == "Maschio")
                {
                    kcal = kcal * 1.9;
                }
                if (user.Sesso == "Femmina")
                {
                    kcal = kcal * 1.6;
                }
            }
            if(user.AttivitàFisica == "Esercizio pesante(6-7 volte a settimana)" || user.AttivitàFisica== "Atleta(2 volte al giorno ogni giorno)")
            {
                if (user.Sesso == "Maschio")
                {
                    kcal = kcal * 2.3;
                }
                if (user.Sesso == "Femmina")
                {
                    kcal = kcal * 1.9;
                }
            }
            return kcal - 200;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Per massa grassa, o dall'inglese BF (body fat), si intende la parte di massa di un organismo costituita dall'organo adiposo, ovvero dal grasso corporeo. La parte restante di massa è definita massa magra. I vari modi per misurare la bf sono: tramite il plicometro o tramite il dexa scan(effettuabile in una clinica).");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Il metabolismo basale, o BMR, dall'inglese Basal metabolic rate, è il dispendio energetico di un organismo vivente a riposo, comprendente dunque l'energia necessaria per le funzioni metaboliche vitali. Rappresenta circa il 45-75% del dispendio energetico totale nella giornata.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spiegazioneBox.Text = "Il cut, è un tipo di dieta da seguire per perdere peso \n essa si basa sul concetto di deficit calorico \n ovvero assumere meno kcal di quelle che si bruciano";
            kcalS.Show();
            kcaltoeat.Text = Convert.ToString(user.Kcal - 500) + " kcal";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spiegazioneBox.Text = "Il mantenimento, è un tipo di dieta da seguire per mantere il proprio peso \n essa si basa sul mangiare le stesse kcal che si bruciano";
            kcalS.Show();
            kcaltoeat.Text = Convert.ToString(user.Kcal) + " kcal";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            spiegazioneBox.Text = "Il bulk è un tipo di dieta da seguire per aumentare peso e massa muscolare \n essa si basa sull'introdurre piu kcal di quelle che si bruciano";
            kcalS.Show();
            kcaltoeat.Text = Convert.ToString(user.Kcal + 500) + " kcal";
        }
    }
}
