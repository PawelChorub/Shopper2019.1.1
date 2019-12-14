using Autofac;
using Shopper2019.Documents;
using Shopper2019.Logic;
using Shopper2019.Logic.BusinessLogicFolder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopper2019.UI
{
    public partial class SaleUI : Form
    {
        IContainer container;
        IContainer container_Documents;
        ISaleBusinessLogic saleBusinessLogic;
        IBusinessLogic_Documents businessLogic_Documents;

        public SaleUI()
        {
            InitializeComponent();

            container = Logic.DI_Container.Configure();
            container_Documents = Documents.DI_Container.Config();

            saleBusinessLogic = container.Resolve<ISaleBusinessLogic>();
            businessLogic_Documents = container_Documents.Resolve<IBusinessLogic_Documents>();

            SaleInit();
        }

        private int index;
        //public bool IsSaleComplete { get; set; } = false;
        //public bool IsInvoiceRequired { get; set; } = false;
        private bool IsSaleComplete = false;
        private bool IsInvoiceRequired = false;

        private void SaleInit()
        {
            saleBusinessLogic.NewSaleItemList();

            IsSaleComplete = false;
            IsInvoiceRequired = false;
            InvoiceButton.Enabled = true;
            InvoiceButton.BackColor = SystemColors.Control;

            ReceiptBtn.Enabled = true;
            ReceiptBtn.BackColor = SystemColors.Control;

            DeleteBtn.Enabled = false;
            TotalBtn.Enabled = false;
            SaleCompleteBtn.Enabled = false;
            itemSearchBtn.Enabled = false;

            totalGrossPriceLabel.BackColor = Color.White;

            BuyerDetailsGroupBox.Visible = false;
        }

        private void ViewListOfSaleItem()
        {
            try
            {
                saleListView.Items.Clear();
                int counter = 0;
                foreach (var item in saleBusinessLogic.ReturnSaleItemList())
                {
                    counter++;
                    ListViewItem i = new ListViewItem(counter.ToString());

                    i.SubItems.Add(item.Code);
                    i.SubItems.Add(item.Name);
                    i.SubItems.Add(item.SaleQuantity.ToString("F"));
                    i.SubItems.Add(item.UnitOfMeasurements);
                    i.SubItems.Add(item.VatValue.ToString());
                    i.SubItems.Add(item.Gross_Price.ToString("F"));
                    i.SubItems.Add(item.TotalGross_Price.ToString("F"));

                    saleListView.Items.Add(i);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania składowych listy sprzedaży.\n" + ex.ToString());
            }

        }

        private string SaleGrossPriceTotalView()
        {
            decimal price = 0;
            decimal totalPrice = 0;
            foreach (var item in saleBusinessLogic.ReturnSaleItemList())
            {
                price = item.TotalGross_Price;
                totalPrice += price;
            }
            return totalPrice.ToString("F");
        }
        private void ItemSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteBtn.Enabled = false;
                TotalBtn.Enabled = true;
                totalGrossPriceLabel.BackColor = Color.White;

                saleListView.Items.Clear();
                //znajdź w bazie
                saleBusinessLogic.ReturnSaleItemFromStock(ItemSearchCodeTb.Text);

                if (saleBusinessLogic.CheckSaleItemExists(ItemSearchCodeTb.Text, ItemSearchQuantityTb.Text) != null)
                {   // dodaj jeśli nie ma nulla
                    saleBusinessLogic.SendValuesToSaleListItemProcessor(saleBusinessLogic.CheckSaleItemExists(ItemSearchCodeTb.Text, ItemSearchQuantityTb.Text));
                    totalGrossPriceLabel.Text = SaleGrossPriceTotalView();
                }
                else
                {
                    MessageBox.Show("Za mało towaru na magazynie, lub nierozpoznany kod!", "Błąd!");
                }

                ItemSearchCodeTb.Text = "";
                ItemSearchQuantityTb.Text = "";

                ViewListOfSaleItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas szukania towaru.\n" + ex.ToString());
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                saleBusinessLogic.DeleteItemFromSaleItemList(index);
                ViewListOfSaleItem();
                totalGrossPriceLabel.Text = SaleGrossPriceTotalView();
                DeleteBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas usuwania towaru z listy sprzedaży.\n" + ex.ToString());
            }
        }
        private void TotalBtn_Click(object sender, EventArgs e)
        {
            totalGrossPriceLabel.BackColor = Color.IndianRed;
            DeleteBtn.Enabled = false;
            TotalBtn.Enabled = false;
            SaleCompleteBtn.Enabled = true;
            NewSaleButton.Enabled = false;
        }

        private void SaleListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (saleListView.SelectedItems.Count > 0)
            {
                DeleteBtn.Enabled = true;
                ListViewItem item = saleListView.SelectedItems[0];
                index = item.Index;             
            }
        }

        private void InvoiceButton_Click(object sender, EventArgs e)
        {
            BuyerDetailsGroupBox.Visible = true;

            ReceiptBtn.Enabled = false;
            InvoiceButton.BackColor = Color.Crimson;
            BuyerDetailsSaveBtn.FlatAppearance.BorderColor = Color.Red;
            BuyerDetailsSaveBtn.FlatAppearance.BorderSize = 3;
            BuyerDetailsSaveBtn.Enabled = true;
        }
        private void ReceiptBtn_Click(object sender, EventArgs e)
        {
            IsInvoiceRequired = false;

            ReceiptBtn.BackColor = Color.Crimson;
            itemSearchBtn.Enabled = true;
            InvoiceButton.Enabled = false;
            ReceiptBtn.Enabled = false;
        }

        private void SaleCompleteBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in saleBusinessLogic.ReturnSaleItemList())
            {
                saleBusinessLogic.ReturnSaleItemFromStock(item.Code); // najpierw stwórz obiekt!
                if (saleBusinessLogic.CheckSaleItemExists(item.Code, item.SaleQuantity.ToString()) != null)  // póżniej sprawdz!
                {
                    saleBusinessLogic.UpdateStockItemQuantityByItem(item.Code, item.SaleQuantity); // póżniej zredukuj stan w magazynie

                    IsSaleComplete = true;  // dla ukończenia
                }
                else
                {
                    MessageBox.Show("Brak towaru: Kod : " + item.Code + " Nazwa : " + item.Name + " w żądanej ilości :" + item.SaleQuantity + " " + item.UnitOfMeasurements + ".");
                }

            }
            if (IsSaleComplete)
            {                
                saleListView.Items.Clear();
                totalGrossPriceLabel.Text = SaleGrossPriceTotalView();

                itemSearchBtn.Enabled = true;
                SaleCompleteBtn.Enabled = false;
                NewSaleButton.Enabled = true;
                totalGrossPriceLabel.Text = "0,00";
                totalGrossPriceLabel.BackColor = Color.White;

                //-------------- wydruk
                try
                {
                    if (IsInvoiceRequired)
                    {
                        businessLogic_Documents.InvoiceDetailsBuilder(saleBusinessLogic.ReturnSaleItemList(), BuyerNameTb.Text, BuyerPostCodeTb.Text, BuyerCityTb.Text, BuyerStreetTb.Text, BuyerStreetNumberTb.Text, BuyerTaxNumber.Text);
                    }
                    else
                    {
                        businessLogic_Documents.ReceiptDetailsBuilder(saleBusinessLogic.ReturnSaleItemList());
                    }
                    saleBusinessLogic.NewSaleItemList();

                    SaleInit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd wydruku. \n" + ex.ToString());
                }
            }
        }

        private void BuyerDetailsSaveBtn_Click(object sender, EventArgs e)
        {
            IsInvoiceRequired = true;

            itemSearchBtn.Enabled = true;
            ReceiptBtn.Enabled = false;
            InvoiceButton.Enabled = false;
            BuyerDetailsSaveBtn.FlatAppearance.BorderSize = 1;
            BuyerDetailsSaveBtn.FlatAppearance.BorderColor = Color.Green;
            BuyerDetailsSaveBtn.Enabled = false;
        }

        private void NewSaleButton_Click(object sender, EventArgs e)
        {
                SaleInit();
                saleListView.Items.Clear();
                totalGrossPriceLabel.Text = SaleGrossPriceTotalView();
        }

        private void SaleUI_Load(object sender, EventArgs e)
        {

        }
    }
}
