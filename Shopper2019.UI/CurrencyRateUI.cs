using Shopper2019.CurrencyRate.Models;
using Shopper2019.CurrencyRate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopper2019.UI
{
    public partial class CurrencyRateUI : Form
    {
        public CurrencyRateUI()
        {
            InitializeComponent();
            CurrencyRateRun();
        }
        private ICurrencyRateApiProcessor currencyRateApiProcessor = new CurrencyRateApiProcessor();

        private async void GetCurrencyRateBtn_Click(object sender, EventArgs e)
        {
            currencyTable.Items.Clear();
            try
            {
                ReadCurrencyRateList(await currencyRateApiProcessor.GetCurrencyRateList());

            }
            catch (Exception)
            {
                MessageBox.Show("Błąd pobierania danych lub połączenia z internetem.");
            }

        }
        private async void CurrencyRateRun()
        {
            try
            {
                ReadCurrencyRateList(await currencyRateApiProcessor.GetCurrencyRateList());

            }
            catch (Exception)
            {
                MessageBox.Show("Błąd pobierania danych lub połączenia z internetem.");
            }

        }
        public void ReadCurrencyRateList(List<ICurrency> list)
        {
            foreach (var item in list)
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.Rate);

                currencyTable.Items.Add(listViewItem);
            }
        }

    }
}
