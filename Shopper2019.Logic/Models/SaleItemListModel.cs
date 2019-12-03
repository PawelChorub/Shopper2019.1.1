using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Logic.Models
{
    public class SaleItemListModel : ISaleItemListModel
    {
        public List<ISaleItem> SaleItemList { get; set; }
    }
}
