using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IRF_Project_GQOTXA.Entities;
using IRF_Project_GQOTXA.MnbServiceReference;
using System.Xml;

namespace IRF_Project_GQOTXA
{
    public partial class Nyitooldal : Form
    {
        public Nyitooldal(string email, string password)
        {
            MessageBox.Show("Kérjük első belépés után változtassa meg a jelszavát!", "Üdvözöljük!");
            InitializeComponent();
            labelEmail.Text = email;
            Random rnd = new Random();  //Véletlenszámgenerátor adja meg a felhasználható összeget
            decimal osszeg = (rnd.Next(1000, 50000)*100);
            InvisibleLabel.Text = osszeg.ToString();
            Passwordlabel.Text = password;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //Kilépés
            this.Close();
        }

        private void buttonArfolyamok_Click(object sender, EventArgs e)
        {
            Arfolyamok af = new Arfolyamok();
            panel1.Controls.Clear();
            panel1.Controls.Add(af);
        }

        private void buttonValuta_Click(object sender, EventArgs e)
        {
            Valutavaltas v = new Valutavaltas(InvisibleLabel.Text);
            panel1.Controls.Clear();
            panel1.Controls.Add(v);
        }

        private void buttonPwChange_Click(object sender, EventArgs e)
        {
            Jelszocsere jcs = new Jelszocsere(Passwordlabel.Text);
            panel1.Controls.Clear();
            panel1.Controls.Add(jcs);
        }
    }
}
