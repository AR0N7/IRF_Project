using IRF_Project_GQOTXA.Entities;
using IRF_Project_GQOTXA.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IRF_Project_GQOTXA
{
    public partial class Valutavaltas : UserControl
    {
        BindingList<Adatok> Ertekek = new BindingList<Adatok>();

        public Valutavaltas(string osszeg)
        {
            InitializeComponent();
            Valutak();
            labelOsszes.Text = osszeg;
            GetValues();
        }

        public void Valutak()
        {
            comboBox1.Items.Clear();

            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetCurrenciesRequestBody();

            var response = mnbService.GetCurrencies(request);

            string result = response.GetCurrenciesResult;

            var xml = new XmlDocument();
            xml.LoadXml(result);

            XmlNodeList nodes = xml.SelectNodes("/MNBCurrencies/Currencies/Curr");

            foreach (XmlNode xn in nodes)
            {
                string Valuta = xn.InnerText;
                comboBox1.Items.Add(Valuta);
            }

        }

        private void GetValues()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetCurrentExchangeRatesRequestBody();

            var response = mnbService.GetCurrentExchangeRates(request);

            var result = response.GetCurrentExchangeRatesResult;

            ReadXML(result);

        }

        public void ReadXML(string result)
        {
            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {
                for (int child = 0; child <= 100; child++)
                {
                    var rate = new Adatok();

                    var childElement = (XmlElement)element.ChildNodes[child];
                    if (childElement == null)
                    {
                        continue;
                    }
                    rate.Valuta = childElement.GetAttribute("curr");


                    var unit = decimal.Parse(childElement.GetAttribute("unit"));
                    var value = decimal.Parse(childElement.InnerText);
                    if (unit != 0)
                        rate.Árfolyam = value / unit;

                    Ertekek.Add(rate);
                }

            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxVALUE.Text) | String.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Kérem töltse ki a kötelező részeket!");
            }
            else
            {
                //Ha nem találja a beírt valutakódot, akkor error
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            //MessageBox sikeres vásárlás, after Unit test
            //"Sikeres vásárlás, a tételek listáját megtalálja egy letöltött csv-ben"
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void textBoxVALUE_Validating(object sender, CancelEventArgs e)
        {
            int parsedValue;
            if (int.TryParse(textBoxVALUE.Text, out parsedValue))
            {
                e.Cancel = false;
                textBoxVALUE.BackColor = Color.White;
            }
            else
            {
                textBoxVALUE.BackColor = Color.Red;
                e.Cancel = true;
            }
            if (string.IsNullOrEmpty(textBoxVALUE.Text))
            {
                e.Cancel = false;
                textBoxVALUE.BackColor = Color.White;
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"[A-Z]{3}");
            if (r.IsMatch(comboBox1.Text))
            {
                e.Cancel = false;
                comboBox1.BackColor = Color.White;
            }
            else
            {
                comboBox1.BackColor = Color.Red;
                e.Cancel = true;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                e.Cancel = false;
                comboBox1.BackColor = Color.White;
            }
        }

        private void textBoxVALUE_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Validate();
        }
    }
}
