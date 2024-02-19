using CheckoutKata.Interfaces;
using CheckoutKata.Model;

namespace CheckoutKata.Strategies
{
    public class RegularPriceCalculator : ICalculatorStrategy
    {
        public double CalculatePrice(PricingRule pricingRule, int scannedQuantity)
        {
            if (pricingRule.SpecialPrice == 0)
            {
                var productprice = (scannedQuantity / pricingRule.Quantity) * pricingRule.Price;
                return productprice;
            }
            return 0;
        }
       
    }
}
