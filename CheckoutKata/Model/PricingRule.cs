using CheckoutKata.Interfaces;

namespace CheckoutKata.Model
{
    public class PricingRule : IPricingRule
    {
        public int Quantity { get; set; }
        public double SpecialPrice { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
    }
}
