using System.Collections.Generic;
using Shopper2019.Documents.Models;
using Shopper2019.Logic.Models;

namespace Shopper2019.Documents
{
    public interface IReceiptProcessor
    {
        //string SetReceiptDetailsFromList(List<ISaleItem> list);
        //string ReceiptComplete();
        void ReceiptBuilder(List<ISaleItem> list);
        void ReceiptView();
    }
}