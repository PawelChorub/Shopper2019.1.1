using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shopper2019.Logic.Models;

namespace Shopper2019.Logic.Processors
{
    public class SaleListItemProcessor : ISaleListItemProcessor, ISaleItemListModel
    {
        public List<ISaleItem> SaleItemList { get; set; }

        public void CreateNewSaleList()
        {
            SaleItemList = new List<ISaleItem>();
        }
        public void AddItemToSaleList(ISaleItem item)
        {
            SaleItemList.Add(item);
        }

        public void DeleteSaleItemFromListByIndex(int index)
        {
            try
            {
                SaleItemList.RemoveAt(index);
            }
            catch
            {
                MessageBox.Show("Lista jest pusta!");
            }
        }

        public void EditSaleItemListElement(List<ISaleItem> listName, ISaleItem saleItem, int index)
        {
            try
            {
                var item = SaleItemList.ElementAt(index);
                item.Code = saleItem.Code;
                item.Name = saleItem.Name;
                item.SaleQuantity = saleItem.SaleQuantity;
                item.VatValue = saleItem.VatValue;
                item.Gross_Price = saleItem.Gross_Price;
                item.TotalGross_Price = saleItem.TotalGross_Price;
            }
            catch (Exception)
            {
                MessageBox.Show("Lista jest pusta!");
            }
        }

        // może na później
        public void DeleteSaleItemFromList(string code)
        {
            for (int i = 0; i < SaleItemList.Count; i++)
            {
                // if it is List<String>
                if (SaleItemList[i].Code == code)
                {
                    SaleItemList.RemoveAt(i);
                }
            }
        }
        public List<ISaleItem> ReturnSaleItemList()
        {
            return SaleItemList;
        }
        // na poaragon może jak nie do do kosza
        public string ViewListSaleItem(List<ISaleItem> listName)
        {
            string output = "";

            foreach (var item in listName)
            {
                output = output + item.Code + " / " +
                item.Name + " / " + 
                item.SaleQuantity + " / " + 
                item.VatValue + " / " + 
                item.Gross_Price + " / " + 
                item.TotalGross_Price + "\r\n";
            }
            return output;
        }
    }
}
