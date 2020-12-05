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
            labelTime.Text= DateTime.Now.ToString();
            WebszolgaltatashivasaTest();
        }

        public void WebszolgaltatashivasaTest()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetCurrentExchangeRatesRequestBody();

            var response = mnbService.GetCurrentExchangeRates(request);

            var result = response.GetCurrentExchangeRatesResult;

            dataGridView1.DataSource = Rates;

            xmltest(result);
        }

        public void xmltest(string result)
        {
            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {
                int child = 0;

                do
                {
                    var rate = new Adatok();

                    rate.Date = DateTime.Parse(element.GetAttribute("date"));


                    var childElement = (XmlElement)element.ChildNodes[child];
                    if (childElement == null)
                    {
                        continue;
                    }
                    rate.Currency = childElement.GetAttribute("curr");


                    var unit = decimal.Parse(childElement.GetAttribute("unit"));
                    var value = decimal.Parse(childElement.InnerText);
                    if (unit != 0)
                        rate.Value = value / unit;

                    Rates.Add(rate);
                } while (child < 100);

                //for (int child = 0; child <= currCnt; child++)
                //{
                //    var rate = new Adatok();

                //    rate.Date = DateTime.Parse(element.GetAttribute("date"));


                //    var childElement = (XmlElement)element.ChildNodes[child];
                //    if (childElement == null)
                //    {
                //        continue;
                //    }
                //    rate.Currency = childElement.GetAttribute("curr");


                //    var unit = decimal.Parse(childElement.GetAttribute("unit"));
                //    var value = decimal.Parse(childElement.InnerText);
                //    if (unit != 0)
                //        rate.Value = value / unit;

                //    Rates.Add(rate);
                //}

            }
        }
    }
}
