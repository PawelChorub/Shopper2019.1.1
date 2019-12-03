namespace Shopper2019.Documents.Models
{
    public interface IVendor
    {
        string City { get; set; }
        string Name { get; set; }
        string PostCode { get; set; }
        string Street { get; set; }
        string StreetNumber { get; set; }
        string TaxNumber { get; set; }
    }
}