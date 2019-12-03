namespace Shopper2019.Documents.Models
{
    public interface IBuyer
    {
        string BuyerCity { get; set; }
        string BuyerName { get; set; }
        string BuyerPostCode { get; set; }
        string BuyerStreet { get; set; }
        string BuyerStreetNumber { get; set; }
        string BuyerTaxNumber { get; set; }
    }
}