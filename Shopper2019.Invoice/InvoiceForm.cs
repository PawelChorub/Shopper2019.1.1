using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Da się.Tylko zależy od przyjętej rozdzielczości. Standardowo do wydruku przyjmuje się 72 piksele na cal (dots per inch - dpi). Resztę wylicz sobie sam Wesoły
//Albo OK.Policzmy.

//Kartka A4 ma rozmiary 210 x 297 mm, czyli w calach 8.26 x 11.69. To mnożymy przez 72, i otrzymujemy:

//595 x 842 - i to jest rozmiar kartki A4 przy normalnej rozdzielczości.

//Do wydruku wysokiej jakości(na przykład zdjęć) przyjmuje się 300dpi, czyli obrazek powinien mieć:

//2478 x 3507 pikseli.
namespace Shopper2019.Invoice
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
            InvoiceInit();
            
        }
        int fvNumb = 3;
        public void InvoiceInit() // przy każdorazowym utworzeniu dokumentu
        {
            // naglowki
            //string Date = DateTime.Now.ToShortDateString();
            CityAndDateLbl.Text = "Częstochowa, " + DateTime.Now.ToShortDateString();
            InvoiceNumberLbl.Text = "Faktura VAT nr: " + DateTime.Now.Year.ToString() + " \\ " + ++fvNumb + " \\ " + "MAG";
        }
        public void InvoiceData(ListViewItem i)
        {
            // dane wchodzące
            InvoiceListView.Items.Add(i);
            //var x = InvoiceListView.Size.Height;
            //x = x + 22;
            
        }
        //klient w obiekcie!
        public void InvoiceBuyer(string name, string city, string postCode, string street, string taxNumber)
        {
            BuyerNameLbl.Text = name;
            BuyerAddressLbl.Text = city + " " + postCode + " " + street;
            BuyerTaxNumberLbl.Text = taxNumber;
        }
    }
}
