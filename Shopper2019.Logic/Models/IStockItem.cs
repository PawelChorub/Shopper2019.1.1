namespace Shopper2019.Logic.Models
{
    public interface IStockItem
    {
        string Code { get; set; }
        decimal Gross_Price { get; set; }
        string Name { get; set; }
        decimal Net_Price { get; set; }
        decimal StockQuantity { get; set; }
        int VatValue { get; set; }
        decimal TotalGross_Price { get; set; }
        string UnitOfMeasurements { get; set; }

    }
}