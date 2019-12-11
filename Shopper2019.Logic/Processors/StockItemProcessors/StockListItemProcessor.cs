using Autofac;
using Shopper2019.Logic;
using Shopper2019.Logic.Models;
using Shopper2019.Logic.Processors;
using Shopper2019.Logic.Processors.StockItemProcessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopper2019.Logic.Processors
{
    public class StockListItemProcessor : IStockItemListModel, IStockListItemProcessor
    {
        IContainer container;
        ISaveToStockProcessor save;

        public StockListItemProcessor()
        {
            container = DI_Container.Configure();
            save = container.Resolve<ISaveToStockProcessor>();
        }
        public List<IStockItem> StockItemList { get; set; }

        public void CreateNewList()
        {
            StockItemList = new List<IStockItem>();
        }

        public void AddItemToStockList(IStockItem item)
        {
            StockItemList.Add(item);
        }

        public void DeleteStockItemFromListByIndex(int index)
        {
            try
            {
                StockItemList.RemoveAt(index);
            }
            catch
            {
                MessageBox.Show("Lista jest pusta!");
            }
        }

        public void EditStockItemListElement(List<IStockItem> listName, IStockItem stockItem, int index)
        {
            try
            {
                var item = StockItemList.ElementAt(index);

                item.Code = stockItem.Code;
                item.Name = stockItem.Name;
                item.StockQuantity = stockItem.StockQuantity;
                item.UnitOfMeasurements = stockItem.UnitOfMeasurements;
                item.Net_Price = stockItem.Net_Price;
                item.VatValue = stockItem.VatValue;
                item.Gross_Price = stockItem.Gross_Price;
            }
            catch (Exception)
            {
                MessageBox.Show("Lista jest pusta!");
            }
        }

        public List<IStockItem> ReturnStockItemList()
        {
            return StockItemList;
        }

        public void SaveListToDatabase(List<IStockItem> listName)
        {
            foreach (var item in listName)
            {
                save.SaveItemToSqlStock(item);
            }
        }

        public void DeleteStockItemFromList(string code)
        {
            for (int i = 0; i < StockItemList.Count; i++)
            {
                if (StockItemList[i].Code == code)
                {
                    StockItemList.RemoveAt(i);
                }
            }
        }
    }
}
