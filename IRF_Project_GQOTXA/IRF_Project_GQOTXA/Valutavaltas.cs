using IRF_Project_GQOTXA.Entities;
using IRF_Project_GQOTXA.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        //Új binding list, ami a kosárba rakott elemeket tartalmazza, AddedValues típusú
        BindingList<AddedValues> Ertekek = new BindingList<AddedValues>();

        public Valutavaltas(string osszeg)
        {
            InitializeComponent();
            Valutak();
            labelOsszes.Text = osszeg;
        }

        //Lekérdezi az összes elérhető valutát és betölti a comboboxba
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

        //Ha van megadott érték és valuta, hozzáadja a kosárhoz az elemeket
        public void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxVALUE.Text) | String.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Kérem töltse ki a kötelező részeket!", "Hiba");
            }
            else
            {
                GetValues();
            }
        }

        //Lekérdezi a kiválasztott valuta aktuális árfolyamát
        public void GetValues()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request2 = new GetExchangeRatesRequestBody()
            {
                currencyNames = comboBox1.Text,
                startDate = DateTime.Now.ToString("yyyy-MM-dd"),
                endDate = DateTime.Now.ToString("yyyy-MM-dd")
            };

            var response2 = mnbService.GetExchangeRates(request2);

            var result2 = response2.GetExchangeRatesResult;

            SelectedView.DataSource = Ertekek;

            ReadXML(result2);
        }

        //Feldolgozza az XML-t és hozzáadja a datagridview-hoz az adott sort
        public void ReadXML(string val)
        {
            var xml = new XmlDocument();
            xml.LoadXml(val);

            foreach (XmlElement element in xml.DocumentElement)
            {
                var rate2 = new AddedValues();

                var childElement = (XmlElement)element.ChildNodes[0];
                if (childElement == null)
                { //Vannak olyan valuták, amikhez nem elérhető az árfolyam
                    MessageBox.Show("A kiválasztott valuta nem elérhető!", "Hiba");
                    return;
                }
                rate2.Valuta = childElement.GetAttribute("curr");


                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate2.Árfolyam = value / unit;

                rate2.Mennyiség = int.Parse(textBoxVALUE.Text);

                rate2.Érték = (rate2.Árfolyam * rate2.Mennyiség);

                Ertekek.Add(rate2);

                //Amennyiben nagyobb érték van a kosárban, mint az egyenlegünk, jelez
                labelOsszes.Text = (decimal.Parse(labelOsszes.Text) - rate2.Érték).ToString();
                if (decimal.Parse(labelOsszes.Text) < 0)
                {
                    labelOsszes.ForeColor = Color.Red;
                }
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(labelOsszes.Text) < 0) //Legyen elég egyenleg a vásárláshoz
            {
                MessageBox.Show("A megadott valuták ára meghaladja az Ön elérhető egyenlegét! Kérjük töltsön fel többet vagy töröljön a kosarából a Törlés gombbal!", "Hiba");
            }
            else
            {
                if (Ertekek.Count<1) //Nem lehet üres a kosár
                {
                    MessageBox.Show("Kérjük adjon elemet a kosarához!", "Hiba");
                }
                else
                {
                    SaveFileDialog sfd = new SaveFileDialog();

                    sfd.Filter = "Comma Separated Values (*.csv)|*.csv";  //Kiválasztható formátumok
                    sfd.DefaultExt = "csv"; //Alapértelmezetten csv-be menti
                    sfd.AddExtension = true; //Hozzáadja a kiterjesztést
                    sfd.FileName = DateTime.Now.ToString("yyyy-MM-dd"); //Alapértelmezett filenév a mai dátum

                    if (sfd.ShowDialog() != DialogResult.OK) return;

                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        //Fejlécet felveszi
                        sw.Write("Valuta");
                        sw.Write(";");
                        sw.Write("Árfolyam");
                        sw.Write(";");
                        sw.Write("Mennyiség");
                        sw.Write(";");
                        sw.Write("Érték");
                        sw.WriteLine();

                        //Az összes sort felviszi a csv-be
                        foreach (var v in Ertekek)
                        {
                            sw.Write(v.Valuta);
                            sw.Write(";");
                            sw.Write(v.Árfolyam);
                            sw.Write(";");
                            sw.Write(v.Mennyiség);
                            sw.Write(";");
                            sw.Write(v.Érték);
                            sw.WriteLine();
                        }
                    }
                    MessageBox.Show("Sikeres vásárlás! A megvásárolt valuták összesítőjét megtalálja a kiválasztott elérési úton.", "Siker");
                    Ertekek.Clear();
                    SelectedView.Refresh();
                }
            }
        }

        //Kitörli a legutoljára hozzáadott elemet
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Ertekek.Count>0)
            {
                var v = Ertekek.ElementAt(Ertekek.Count - 1);

                labelOsszes.Text = (decimal.Parse(labelOsszes.Text) + v.Érték).ToString();
                if (decimal.Parse(labelOsszes.Text) < 0)
                {
                    labelOsszes.ForeColor = Color.Red;
                }
                else
                {
                    labelOsszes.ForeColor = Color.Yellow;
                }

                Ertekek.Remove(v);
                SelectedView.Refresh();  
            }
        }

        //Csak számok írhatóak az összeghez
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

        //Csak három számjegyű kódok írhatóak a valutához
        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            //UNIT TEST IDE!!!

            Regex r = new Regex("^([A-Z]{3})$");
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

        //Validálások
        private void textBoxVALUE_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }
    }
}
