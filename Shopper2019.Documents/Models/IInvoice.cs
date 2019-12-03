namespace Shopper2019.Documents.Models
{
    public interface IInvoice
    {
        string Date { get; set; }
        int InvoiceNumber { get; set; }
        string InvoiceNumberYear { get; set; }
    }
}