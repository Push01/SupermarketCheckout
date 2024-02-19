using CheckoutKata.Interfaces;
using CheckoutKata.Model;

namespace CheckoutKata
{
    public class ProductPricing : IProductPricing
    {
        private List<PricingRule> _pricingRules { get; set; }
        private List<ICalculatorStrategy> _calculatorStrategy { get; set; }

        public ProductPricing(List<PricingRule> pricingRules, List<ICalculatorStrategy> calculatorStrategy)
        {
            _pricingRules = pricingRules;
            _calculatorStrategy = calculatorStrategy;
        }

        public double GetTotalPrice(string sku, int scannedQuantity)
        {
            double result = 0;
            foreach (var cs in _calculatorStrategy)
            {
                var item = _pricingRules.Where(i => i.Product.SKU == sku).FirstOrDefault();
                if (item != null)
                {
                    result += cs.CalculatePrice(item, scannedQuantity);
                }
            }
            return result;

        }
    }
}
