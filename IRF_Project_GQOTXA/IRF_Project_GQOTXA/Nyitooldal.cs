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
        //15 perc inaktivitás után kilép az oldal
        public int visszaszamlalo = 900;

        public Nyitooldal(string email, string password)
        {
            MessageBox.Show("Kérjük első belépés után változtassa meg a jelszavát!", "Üdvözöljük!");
            InitializeComponent();
            labelEmail.Text = email;
            Random rnd = new Random();  //Véletlenszámgenerátor adja meg a felhasználható összeget
            decimal osszeg = (rnd.Next(1000, 50000) * 100);
            InvisibleLabel.Text = osszeg.ToString();
            Passwordlabel.Text = password;
            timer.Start();  //Belépéskor indul a számláló
            TimeSpan time = TimeSpan.FromSeconds(visszaszamlalo);
            labelTimer.Text = time.ToString(@"mm\:ss");
            this.MouseClick += Kattintas; //Eseménykezelő kattintás esetén
        }

        //Minden kattintás restartolja a timert
        private void Kattintas(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RestartTimer();
            }
        }

        //Visszaszámláló újraindítása függvény
        public void RestartTimer()
        {
            visszaszamlalo = 900;
            timer.Start();
            TimeSpan time = TimeSpan.FromSeconds(visszaszamlalo);
            labelTimer.Text = time.ToString(@"mm\:ss");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //Kilépés
            timer.Stop();
            this.Close();
        }

        private void buttonArfolyamok_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Arfolyamok af = new Arfolyamok();
            panel1.Controls.Clear();
            panel1.Controls.Add(af);
            RestartTimer();
        }

        private void buttonValuta_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Valutavaltas v = new Valutavaltas(InvisibleLabel.Text);
            panel1.Controls.Clear();
            panel1.Controls.Add(v);
            RestartTimer();
        }

        private void buttonPwChange_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Jelszocsere jcs = new Jelszocsere(Passwordlabel.Text);
            panel1.Controls.Clear();
            panel1.Controls.Add(jcs);
            RestartTimer();
        }

        //Visszaszámláló működése
        public void timer_Tick(object sender, EventArgs e)
        {
            visszaszamlalo--;
            TimeSpan time = TimeSpan.FromSeconds(visszaszamlalo);
            labelTimer.Text = time.ToString(@"mm\:ss");
            if (visszaszamlalo==0)
            {
                timer.Stop();
                this.Close();  //Ha lejár, kilép a program
            }
        }
    }
}
