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
            #endregion
            if(bfBox.Text == "")
            { 
            Utente generic = new Utente(Convert.ToDouble(altezzaBox.Text), Convert.ToDouble(pesoBox.Text), sesso, aF, Convert.ToInt32(etàBox), sport);
            }
            else
            {
            Utente generic = new Utente(Convert.ToDouble(altezzaBox.Text), Convert.ToDouble(pesoBox.Text), sesso, aF, Convert.ToInt32(etàBox), sport, Convert.ToInt32(bfBox.Text));
            }

        }
    }
}
