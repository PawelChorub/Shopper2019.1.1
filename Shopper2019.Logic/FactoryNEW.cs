using Autofac;
using Shopper2019.Logic.BusinessLogicFolder;
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
    public static class FactoryNEW
    {      
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<StockItem>().As<IStockItem>();
            builder.RegisterType<StockItemProcessor>().As<IStockItemProcessor>();
            builder.RegisterType<StockListItemProcessor>().As<IStockListItemProcessor>();
            builder.RegisterType<StockListViewItemProcessor>().As<IStockListViewItemProcessor>();
            builder.RegisterType<VatTaxRateProcessor>().As<IVatTaxRateProcessor>();
            builder.RegisterType<SaleItem>().As<ISaleItem>();
            builder.RegisterType<SaleItemProcessor>().As<ISaleItemProcessor>();
            builder.RegisterType<SaleListItemProcessor>().As<ISaleListItemProcessor>();
            builder.RegisterType<SaleListViewItemProcessor>().As<ISaleListViewItemProcessor>();
            builder.RegisterType<SaveToStockProcessor>().As<ISaveToStockProcessor>();
            builder.RegisterType<ReadFromStockProcessor>().As<IReadFromStockProcessor>();
            builder.RegisterType<UpdateStockItemProcessor>().As<IUpdateStockItemProcessor>();
            builder.RegisterType<SaleBusinessLogic>().As<ISaleBusinessLogic>();
            builder.RegisterType<StockBusinessLogic>().As<IStockBusinessLogic>();

            return builder.Build();
        }
    }
}
