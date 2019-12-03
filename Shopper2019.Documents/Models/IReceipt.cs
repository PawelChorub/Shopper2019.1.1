namespace Shopper2019.Documents.Models
{
    public interface IReceipt
    {
        string DateAndTime { get; set; }
        string ReceiptDetails { get; set; }
        string ReceiptFooter { get; set; }
        string ReceiptHeader { get; set; }
    }
}