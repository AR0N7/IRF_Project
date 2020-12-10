using IRF_Project_GQOTXA.Entities;
using IRF_Project_GQOTXA.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IRF_Project_GQOTXA
{
    public partial class Kezdolap : Form
    {
        public Kezdolap()
        {
            InitializeComponent();
            textBoxPASSWORD.PasswordChar = '*';
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //Program bezárása
            this.Close();
        }

        private void buttonGO_Click(object sender, EventArgs e)
        {
            //Belépési adatok ellenőrzése (Unit test)
            Nyitooldal ny = new Nyitooldal(textBoxEMAIL.Text, textBoxPASSWORD.Text);
            ny.ShowDialog();
            textBoxEMAIL.Clear();
            textBoxPASSWORD.Clear();
        }

        //Súgó
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kérjük adja meg az email címét és a bankjától kapott jelszót!", "Súgó?");
        }
    }
}
