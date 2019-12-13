using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents
{
    public class InvoiceSummaryProcessor
    {
        public void CreateInvoiceSummaryProcessor(int? tax, decimal taxValue, decimal netPrice, decimal grossPrice, ref decimal _taxFreeSummary, ref decimal _tax5summary, ref decimal _tax8summary, ref decimal _tax23summary, ref decimal _netPrice5summary, ref decimal _netPrice8summary, ref decimal _netPrice23summary, ref decimal _netPriceFreeSummary, ref decimal _grossPrice5summary, ref decimal _grossPrice8summary, ref decimal _grossPrice23summary, ref decimal _grossPriceFreeSummary)
        {
            if (tax == 5)
            {
                _tax5summary += taxValue;
                _netPrice5summary += netPrice;
                _grossPrice5summary += grossPrice;
            }
            else if (tax == 8)
            {
                _tax8summary += taxValue;
                _netPrice8summary += netPrice;
                _grossPrice8summary += grossPrice;
            }
            else if (tax == 23)
            {
                _tax23summary += taxValue;
                _netPrice23summary += netPrice;
                _grossPrice23summary += grossPrice;
            }
            else
            {
                _taxFreeSummary += taxValue;
                _netPriceFreeSummary += netPrice;
                _grossPriceFreeSummary += grossPrice;
            }
        }

    }
}
