using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopper2019.Logic.Processors.StockItemProcessors
{
    public class StockListViewItemProcessor : IStockListViewItemProcessor
    {
        // prawdopodobnie /niepotrzebne - do przerobienia z UI
        // tylko dla widoku
       

        public int Counter { get; set; } = 1;

        public ListViewItem LoadStockItemsToStockListView(IStockItem stockItem, int counter)
        {
            //if (counter > 0) Counter = counter;
            if (stockItem != null)
            {
                
                //ListViewItem stockList = new ListViewItem(Counter.ToString());
                ListViewItem stockList = new ListViewItem(counter.ToString());
                


                stockList.SubItems.Add(stockItem.Code);
                stockList.SubItems.Add(stockItem.Name);
                stockList.SubItems.Add(stockItem.StockQuantity.ToString("F"));
                stockList.SubItems.Add(stockItem.Net_Price.ToString("F"));
                stockList.SubItems.Add(stockItem.VatValue.ToString());
                stockList.SubItems.Add(stockItem.Gross_Price.ToString("F"));
               // Counter++;
                

                return stockList;
                
            }
            else return null;
        }
        public ListViewItem LoadStockItemsToStockListView2(IStockItem stockItem)
        {
            //if (counter > 0) Counter = counter;
            if (stockItem != null)
            {

                //ListViewItem stockList = new ListViewItem(Counter.ToString());
                ListViewItem stockListItem = new ListViewItem(Counter.ToString());



                stockListItem.SubItems.Add(stockItem.Code);
                stockListItem.SubItems.Add(stockItem.Name);
                stockListItem.SubItems.Add(stockItem.StockQuantity.ToString("F"));
                stockListItem.SubItems.Add(stockItem.Net_Price.ToString("F"));
                stockListItem.SubItems.Add(stockItem.VatValue.ToString());
                stockListItem.SubItems.Add(stockItem.Gross_Price.ToString("F"));
                Counter++;


                return stockListItem;

            }
            else return null;
        }



    }
}
