using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Logic.Processors
{
    public interface ISaleListItemProcessor
    {
        List<ISaleItem> SaleItemList { get; set; } // ta liste sprobuj przerzucic do modelu

        void AddItemToSaleList(ISaleItem item);
        void CreateNewSaleList();
        string ViewListSaleItem(List<ISaleItem> listName);
        void DeleteSaleItemFromList(string code);
        void DeleteSaleItemFromListByIndex(int index);
        void EditSaleItemListElement(List<ISaleItem> listName, ISaleItem saleItem, int index);
        List<ISaleItem> ReturnSaleItemList();
    }   
}
