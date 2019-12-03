using Shopper2019.Logic.BusinessLogicFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Logic
{
    public class DependencyContainer
    {
        // kontener do wstrzyku konkretnej logiki biznesowej
        public static IBusinessLogic BusinessLogicInject()
        {
            return new BusinessLogic();
        }
        public static ISaleBusinessLogic SaleBusinessLogicInject()
        {
            return new SaleBusinessLogic();
        }
        public static IStockBusinessLogic StockBusinessLogicInject()
        {
            return new StockBusinessLogic();
        }

    }
}
