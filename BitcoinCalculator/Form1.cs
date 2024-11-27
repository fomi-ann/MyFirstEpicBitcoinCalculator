using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BitcoinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bitcoinamountinput.Text.ToString() == "" || bitcoinamountinput.Text.ToString() == "0")
            {
                MessageBox.Show("Palun sisesta valuuta summa number");
            }
            
            else if (currencyselector.Text.ToString() == "EUR" || currencyselector.Text.ToString() == "EEK")
            {
                resultlabel.Visible = true;
                tulemuslabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float;
                resultlabel.Text = $"{result} {newbitcoinrate.Bpi.EUR.code}";
                
                if (currencyselector.Text.ToString() == "EEK")
                {
                    result *= (float)(15.64664);
                    resultlabel.Text = $"{result} Bitcoini eesti kroonides";
                }
                else
                {
                    resultlabel.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.EUR.code}";

                }
                
            }
            else if (currencyselector.Text.ToString() == "GBP")
            {
                resultlabel.Visible = true;
                tulemuslabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.GBP.rate_float;
                resultlabel.Text = $"{result} {newbitcoinrate.Bpi.GBP.code}";
            }

            else if (currencyselector.Text.ToString() == "USD")
            {
                resultlabel.Visible = true;
                tulemuslabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.USD.rate_float;
                resultlabel.Text = $"{result} {newbitcoinrate.Bpi.USD.code}";
            }

           


        }
        public static BitcoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates bitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
            }
            return bitcoin;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
 
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void resultlabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
