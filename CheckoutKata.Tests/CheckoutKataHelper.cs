using CheckoutKata.Interfaces;
using CheckoutKata.Model;
using CheckoutKata.Strategies;

namespace CheckoutKata.Tests
{
    public static class CheckoutKataHelper
    {
        public static List<PricingRule> SetupProductListing()
        {
            var pricingRule = new List<PricingRule>();

            pricingRule.Add(new PricingRule
            {
                Product = new Product
                {
                    SKU = "A",
                },
                Quantity = 3,
                SpecialPrice = 15,
                Price = 10
            });

            pricingRule.Add(new PricingRule
            {
                Product = new Product
                {
                    SKU = "B",
                },
                Quantity = 1,
                SpecialPrice = 0,
                Price = 5
            });

            pricingRule.Add(new PricingRule
            {
                Product = new Product
                {
                    SKU = "C",
                },
                Quantity = 2,
                SpecialPrice = 30,
                Price = 20
            });

            return pricingRule;
        }

        public static List<ICalculatorStrategy> SetupCalculatorStrategy()
        {
            return new List<ICalculatorStrategy>()
            {
                new DiscountCalculator(),
                new RegularPriceCalculator(),
            };
        }
    }
}
