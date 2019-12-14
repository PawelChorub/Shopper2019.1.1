using Shopper2019.Documents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents
{
    public class InvoiceSummaryProcessor
    {
        public void CreateInvoiceSummaryProcessor(int? tax, decimal taxValue, decimal netPrice, decimal grossPrice, ref TaxSummary taxSummary)
        {
            if (tax == 5)
            {
                taxSummary._tax5summary += taxValue;
                taxSummary._netPrice5summary += netPrice;
                taxSummary._grossPrice5summary += grossPrice;
            }
            else if (tax == 8)
            {
                taxSummary._tax8summary += taxValue;
                taxSummary._netPrice8summary += netPrice;
                taxSummary._grossPrice8summary += grossPrice;
            }
            else if (tax == 23)
            {
                taxSummary._tax23summary += taxValue;
                taxSummary._netPrice23summary += netPrice;
                taxSummary._grossPrice23summary += grossPrice;
            }
            else
            {
                taxSummary._taxFreeSummary += taxValue;
                taxSummary._netPriceFreeSummary += netPrice;
                taxSummary._grossPriceFreeSummary += grossPrice;
            }
        }

    }
}
