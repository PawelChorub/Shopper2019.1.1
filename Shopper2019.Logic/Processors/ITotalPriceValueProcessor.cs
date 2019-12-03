namespace Shopper2019.Logic.Processors
{
    public interface ITotalPriceValueProcessor
    {
        double CalculateTotalPriceValue(decimal quantity, decimal price);
    }
}