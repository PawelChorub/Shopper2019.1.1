using Shopper2019.Logic;
using Shopper2019.Logic.BusinessLogicFolder;
using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shopper2019.Documents;
using Autofac;

namespace Shopper2019.UI
{
    public partial class StockUI : Form
    {
        IContainer container;
        IStockBusinessLogic stockBusinessLogic;

        public StockUI()
        {
            InitializeComponent();

            container = Logic.DI_Container.Configure();
            stockBusinessLogic = container.Resolve<IStockBusinessLogic>();

            stockBusinessLogic.NewStockItemList();
        }

        private int index;

        public void ClearTextBoxes()
        {
            indexTb.Text = "";
            codeTb.Text = "";
            nameTb.Text = "";
            quantityTb.Text = "";
            //unitOfMeasurementTb.Text = "";
            unitOfMeasurementCbox.Text = "wybierz...";
            unitOfMeasurementCbox.SelectedItem = null;
            netPriceTb.Text = "";
            vatTaxTb.Text = "";
            grossPriceTb.Text = "";
        }
        public void LockTextBoxes()
        {
            codeTb.ReadOnly = true;
            nameTb.ReadOnly = true;
            quantityTb.ReadOnly = true;
            //unitOfMeasurementTb.ReadOnly = true;
            unitOfMeasurementCbox.Enabled = false;
            netPriceTb.ReadOnly = true;
            vatTaxTb.ReadOnly = true;
        }
        public void UnLockTextBoxes()
        {
            codeTb.ReadOnly = false;
            nameTb.ReadOnly = false;
            quantityTb.ReadOnly = false;
            //unitOfMeasurementTb.ReadOnly = false;
            unitOfMeasurementCbox.Enabled = true;
            netPriceTb.ReadOnly = false;
            vatTaxTb.ReadOnly = false;
        }
        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            if ((codeTb.Text != "") && (netPriceTb.Text != "") && (quantityTb.Text!="") && (unitOfMeasurementCbox.SelectedItem != null))
            {
                stockBusinessLogic.SendValuesToStockListItemProcessor(codeTb.Text, nameTb.Text, quantityTb.Text, /*unitOfMeasurementTb.Text*/ unitOfMeasurementCbox.SelectedItem.ToString(), netPriceTb.Text, vatTaxTb.Text, "");
                ViewListOfStockItem();
                ClearTextBoxes();
                EditBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("Musisz zdefiniować pozycję dostawy!");
            }
        }

        private void StockListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditBtn.Enabled = true;
            DeleteBtn.Enabled = true;
            AddItemBtn.Enabled = false;
            SaveToDbBtn.Enabled = false;

            if (stockListView.SelectedItems.Count > 0)
            {
                ListViewItem item = stockListView.SelectedItems[0];
                index = item.Index;

                indexTb.Text = item.SubItems[0].Text;
                codeTb.Text = item.SubItems[1].Text;
                nameTb.Text = item.SubItems[2].Text;
                quantityTb.Text = item.SubItems[3].Text;
                //unitOfMeasurementTb.Text = item.SubItems[4].Text;
                unitOfMeasurementCbox.Text = item.SubItems[4].Text;

                netPriceTb.Text = item.SubItems[5].Text;
                vatTaxTb.Text = item.SubItems[6].Text;
                grossPriceTb.Text = item.SubItems[7].Text;

                LockTextBoxes();
            }
        }

        public void ViewListOfStockItem()
        {
            stockListView.Items.Clear();
            int counter = 0;
            foreach (var item in stockBusinessLogic.ReturnStockItem_List())
            {
                counter++;
                ListViewItem i = new ListViewItem(counter.ToString());

                i.SubItems.Add(item.Code);
                i.SubItems.Add(item.Name);
                i.SubItems.Add(item.StockQuantity.ToString("F"));
                i.SubItems.Add(item.UnitOfMeasurements);
                i.SubItems.Add(item.Net_Price.ToString("F"));
                i.SubItems.Add(item.VatValue.ToString());
                i.SubItems.Add(item.Gross_Price.ToString("F"));

                stockListView.Items.Add(i);
            }
        }

        private void DeleteBtnClick(object sender, EventArgs e)
        {
            stockBusinessLogic.DeleteStockItemListByIndex(index);
            ViewListOfStockItem();

            EditBtn.Enabled = false;
            DeleteBtn.Enabled = false;
            AddItemBtn.Enabled = true;
            ClearTextBoxes();
            UnLockTextBoxes();
            SaveToDbBtn.Enabled = true;
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            ViewListOfStockItem();

            SaveToDbBtn.Enabled = false;
            EditBtn.Enabled = false;
            DeleteBtn.Enabled = false;
            AddEditChangesBtn.Enabled = true;
            AddItemBtn.Enabled = false;
            //ClearTextBoxes();
            UnLockTextBoxes();
        }
        private void SaveToDbBtn_Click(object sender, EventArgs e)
        {
            bool complete = false;

            foreach (var item in stockBusinessLogic.ReturnStockItem_List())
            {
                // najpierw sprawdż istnienie obiektu!
                stockBusinessLogic.ReturnSaleItemFromStock(item.Code); // najpierw stwórz obiekt!
                if (stockBusinessLogic.CheckSaleItemExists(item.Code, item.StockQuantity.ToString()) != null)  // póżniej sprawdz!
                {
                    stockBusinessLogic.UpdateIncreaseStockItemQuantity(item.Code, item.StockQuantity.ToString()); // póżniej zmień stan w magazynie

                    logBoxTb.Text += "Przyjęto : Kod : " + item.Code + " Nazwa : " + item.Name + " w ilości :" + item.StockQuantity + "\r\n";
                    complete = true;  // dla zerowania                  
                }
                else
                {                                                           
                    stockBusinessLogic.SaveToStock(item.Code, item.Name, item.StockQuantity.ToString(), item.UnitOfMeasurements, item.Net_Price.ToString(), item.VatValue.ToString(), "");
                    logBoxTb.Text += "Przyjęto nowy: Kod : " + item.Code + " Nazwa : " + item.Name + " w ilości :" + item.StockQuantity + "\r\n";
                    complete = true;
                }

                EditBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
            if (complete)
            {
                stockBusinessLogic.NewStockItemList();
                stockListView.Items.Clear();
                ClearTextBoxes();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewItemBtn_Click(object sender, EventArgs e)
        {
            UnLockTextBoxes();
            ClearTextBoxes();
            AddItemBtn.Enabled = true;
            EditBtn.Enabled = false;
            DeleteBtn.Enabled = false;
            SaveToDbBtn.Enabled = true;
            AddEditChangesBtn.Enabled = false;
        }

        private void AddEditChangesBtn_Click(object sender, EventArgs e)
        {
            if (unitOfMeasurementCbox.SelectedItem != null)
            {
                stockBusinessLogic.EditItemFromListByIndex(index, codeTb.Text, nameTb.Text, quantityTb.Text, /*unitOfMeasurementTb.Text*/unitOfMeasurementCbox.SelectedItem.ToString(), netPriceTb.Text, vatTaxTb.Text, "");
                ViewListOfStockItem();
                EditBtn.Enabled = false;
                DeleteBtn.Enabled = false;
                ClearTextBoxes();
                EditBtn.Enabled = false;
                AddItemBtn.Enabled = true;
                SaveToDbBtn.Enabled = true;
                AddEditChangesBtn.Enabled = false;
            }
        } 
    }
}
