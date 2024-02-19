using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutKata.Interfaces;
using CheckoutKata.Model;

namespace CheckoutKata.Strategies
{
    public class DiscountCalculator : ICalculatorStrategy
    {
        public double CalculatePrice(PricingRule pricingRule, int scannedQuantity)
        {
            var discount = (scannedQuantity / pricingRule.Quantity) * pricingRule.SpecialPrice;
            var remainingItemPrice = (scannedQuantity % pricingRule.Quantity) * pricingRule.Price;
            return discount + remainingItemPrice;
        }
    }

}
