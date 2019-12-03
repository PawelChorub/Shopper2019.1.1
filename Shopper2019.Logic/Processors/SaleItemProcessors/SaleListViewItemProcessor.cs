using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopper2019.Logic.Processors.SaleItemProcessors
{
    public class SaleListViewItemProcessor : ISaleListViewItemProcessor
    {
        public int Counter { get; set; } = 1;

        public ListViewItem LoadSaleItemsToSaleListView(ISaleItem saleItem)
        {

            if (saleItem != null)       // zabezpieczenie ilości i istneinia obiektu
            {
                ListViewItem saleList = new ListViewItem(Counter.ToString());
                saleList.SubItems.Add(saleItem.Code);
                saleList.SubItems.Add(saleItem.Name);
                saleList.SubItems.Add(saleItem.SaleQuantity.ToString("F"));
                saleList.SubItems.Add(saleItem.VatValue.ToString());
                saleList.SubItems.Add(saleItem.Gross_Price.ToString("F"));
                saleList.SubItems.Add(TotalPriceValueProcessor.CalculateTotalPriceValue(saleItem.SaleQuantity, saleItem.Gross_Price).ToString("F"));
                Counter++;

                return saleList;
            }
            else return null;           
        }
    }
}
