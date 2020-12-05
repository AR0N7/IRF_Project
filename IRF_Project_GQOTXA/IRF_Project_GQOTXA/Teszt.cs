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
    public partial class Teszt : Form
    {
        BindingList<Adatok> Rates = new BindingList<Adatok>();

        public Teszt()
        {
            InitializeComponent();
            //currenciesTest();
        }

        //        public void currenciesTest()
        //        {
        //            comboBox1.Items.Clear();

        //            var mnbService = new MNBArfolyamServiceSoapClient();

        //            var request = new GetCurrenciesRequestBody();

        //            var response = mnbService.GetCurrencies(request);

        //            string result = response.GetCurrenciesResult;

        //            int currCounter = 1;

        //            var xml = new XmlDocument();
        //            xml.LoadXml(result);

        //            XmlNodeList nodes = xml.SelectNodes("/MNBCurrencies/Currencies/Curr");

        //            foreach (XmlNode xn in nodes)
        //            {
        //                string Valuta = xn.InnerText;
        //                comboBox1.Items.Add(Valuta);
        //                currCounter++;
        //            }

        //            WebszolgaltatashivasaTest(currCounter);

        //        }

        //        public void WebszolgaltatashivasaTest(int currCnt)
        //        {
        //            var mnbService = new MNBArfolyamServiceSoapClient();

        //            var request = new GetCurrentExchangeRatesRequestBody();

        //            var response = mnbService.GetCurrentExchangeRates(request);

        //            var result = response.GetCurrentExchangeRatesResult;

        //            dataGridView1.DataSource = Rates;

        //            xmltest(result, currCnt);
        //        }

        //        public void xmltest(string result, int currCnt)
        //        {
        //            var xml = new XmlDocument();
        //            xml.LoadXml(result);

        //            foreach (XmlElement element in xml.DocumentElement)
        //            {

        //                //for (int child = 0; child <= currCnt; child++)
        //                //{
        //                //    var rate = new Adatok();

        //                //    rate.Date = DateTime.Parse(element.GetAttribute("date"));


        //                //    var childElement = (XmlElement)element.ChildNodes[child];
        //                //    if (childElement == null)
        //                //    {
        //                //        continue;
        //                //    }
        //                //    rate.Currency = childElement.GetAttribute("curr");


        //                //    var unit = decimal.Parse(childElement.GetAttribute("unit"));
        //                //    var value = decimal.Parse(childElement.InnerText);
        //                //    if (unit != 0)
        //                //        rate.Value = value / unit;

        //                //    Rates.Add(rate);
        //                }

        //            }
        //        }
    }
}
