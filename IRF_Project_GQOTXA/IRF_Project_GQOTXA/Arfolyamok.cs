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
    public partial class Arfolyamok : UserControl
    {
        BindingList<Adatok> Rates = new BindingList<Adatok>();

        public Arfolyamok()
        {
            InitializeComponent();
            labelTime.Text= DateTime.Now.ToString("yy.MM.dd. hh:mm:ss");
            JelenlegiArfolyamok();
            timer1.Start();
        }

        public void JelenlegiArfolyamok()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetCurrentExchangeRatesRequestBody();

            var response = mnbService.GetCurrentExchangeRates(request);

            var result = response.GetCurrentExchangeRatesResult;

            dataGridView1.DataSource = Rates;

            GetXML(result);
        }

        public void GetXML(string result)
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

                    Rates.Add(rate);
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("yy.MM.dd. hh:mm:ss");
            JelenlegiArfolyamok();
        }
    }
}
