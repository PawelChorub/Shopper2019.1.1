using Shopper2019.Logic.Models;
using Shopper2019.Logic.Processors;
using Shopper2019.Logic.Processors.SaleItemProcessors;
using Shopper2019.Logic.Processors.StockItemProcessors;
using Shopper2019.Logic.Processors.UpdateInMsSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Logic
{
    public static class Factory
    {
       
        public static IStockItem CreateStockItem()
        {
            return new StockItem();
        }
                        
        public static IStockItemProcessor CreateStockItemProcessor()
        {
            return new StockItemProcessor();
        }

        public static IStockListItemProcessor CreateStockListItemProcessor()
        {
            return new StockListItemProcessor();
        }

        public static IStockListViewItemProcessor CreateStockListViewItemProcessor()
        {
            return new StockListViewItemProcessor();
        }


        public static IVatTaxRateProcessor SetVatTaxValue()
        {
            return new VatTaxRateProcessor();
        }


        public static ISaleItem CreateSaleItem()
        {
            return new SaleItem();
        }

        public static ISaleItemProcessor CreateSaleItemProcessor()
        {
            return new SaleItemProcessor();
        }

        public static ISaleListItemProcessor CreateSaleListItemProcessor()
        {
            return new SaleListItemProcessor();
        }

        public static ISaleListViewItemProcessor CreateSaleListViewItemProcessor()
        {
            return new SaleListViewItemProcessor();
        }

        public static ISaveToStockProcessor CreateSaveToStockProcessor()
        {
            return new SaveToStockProcessor();
        }

        public static IReadFromStockProcessor CreateReadFromStockProcessor()
        {
            return new ReadFromStockProcessor();
        }

        public static IUpdateStockItemProcessor CreateUpdateStockItemProcessor()
        {
            return new UpdateStockItemProcessor();
        }
    }
}
