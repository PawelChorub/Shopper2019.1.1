using System.Collections.Generic;
using Shopper2019.Documents.Models;
using Shopper2019.Logic.Models;

namespace Shopper2019.Documents
{
    public interface IBusinessLogic_Documents
    {
        void ReceiptDetailsBuilder(List<ISaleItem> _list);
        void InvoiceDetailsBuilder(List<ISaleItem> _list, string name, string postCode, string city, string street, string streetNumber, string taxNumber);
    }
}