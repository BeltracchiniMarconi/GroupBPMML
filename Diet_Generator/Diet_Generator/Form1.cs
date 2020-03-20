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
        public Form1()
        {
            InitializeComponent();
            sportBox.Hide();
            label6.Hide();
        }

        private void salva_Click(object sender, EventArgs e)
        {
            #region combos
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
                case "Esercizio moderato (3-5 volte a settimana)":
                    {
                        aF = "Esercizio moderato (3-5 volte a settimana)";
                        break;
                    }
                case "Esercizio pesante(6-7 volte a settimana)":
                    {
                        aF = "Esercizio pesante(6 - 7 volte a settimana)";
                        break;
                    }
                case "Atleta(2 volte al giorno ogni giorno)":
                    {
                        aF = "Atleta(2 volte al giorno ogni giorno)";
                        break;
                    }
            }
            if(aF != "Lavoro sedentario(nessuna attività)")
            {
                switch(sportBox.SelectedItem.ToString().Trim())
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
            if(bfBox.Text == "")
            { 
            Utente generic = new Utente(double.Parse(altezzaBox.Text), double.Parse(pesoBox.Text), sesso, aF, int.Parse(etàBox.Text), sport);
                MessageBox.Show(generic.ToString());
            }
            else
            {
            Utente generic = new Utente(double.Parse(altezzaBox.Text), double.Parse(pesoBox.Text), sesso, aF, int.Parse(etàBox.Text), sport, int.Parse(bfBox.Text));
                MessageBox.Show(generic.ToString());
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
    }
}
