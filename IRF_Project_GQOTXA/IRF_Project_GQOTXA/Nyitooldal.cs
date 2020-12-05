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
        public Nyitooldal(string email)
        {
            InitializeComponent();
            labelEmail.Text = email;
            Random rnd = new Random();
            int osszeg = (rnd.Next(1000, 50000)*100);
            InvisibleLabel.Text = osszeg.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
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
    }
}
