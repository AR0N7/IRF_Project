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

namespace IRF_Project_GQOTXA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WebszolgaltatashivasaTest();
        }

        public void WebszolgaltatashivasaTest()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetCurrentExchangeRatesRequestBody()
            {
                currencyNames = "GBP",
                startDate = "2020-10-01",
                endDate = "2020-11-30"
            };

            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;
        }
    }
}
