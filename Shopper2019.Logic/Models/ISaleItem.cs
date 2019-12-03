namespace Shopper2019.Logic.Models
{
    public interface ISaleItem
    {
        string Code { get; set; }
        string Name { get; set; }
        decimal SaleQuantity { get; set; }
        decimal Net_Price { get; set; }
        decimal Gross_Price { get; set; }
        decimal TotalGross_Price { get; set; }
        int VatValue { get; set; }
        string UnitOfMeasurements { get; set; }
    }
}