namespace CheckoutKata.Interfaces
{
    public interface IProductPricing
    {
        double GetTotalPrice(string sku, int scannedQuantity);
    }
}