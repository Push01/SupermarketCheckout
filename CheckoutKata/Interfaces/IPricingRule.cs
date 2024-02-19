using CheckoutKata.Model;

namespace CheckoutKata.Interfaces
{
    public interface IPricingRule
    {
        int Quantity { get; set; }
        double SpecialPrice { get; set; }
        double Price { get; set; }
        Product Product { get; set; }
    }
}