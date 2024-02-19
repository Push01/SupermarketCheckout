using CheckoutKata.Interfaces;

namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        private readonly Dictionary<string, int> _scannedItems;
        private readonly IProductPricing _productPricing;

        public Checkout(IProductPricing productPricing)
        {
            _productPricing = productPricing;
            _scannedItems = new Dictionary<string, int>();
        }

        public void Scan(string item)
        {
            if (_scannedItems.ContainsKey(item))
            {
                _scannedItems[item]++;
            }
            else
            {
                _scannedItems.Add(item, 1);
            }
        }

        public double Total
        {
            get
            {
                double total = 0;
                foreach (var item in _scannedItems)
                {
                    var sku = item.Key;
                    var itemquantity = item.Value;
                    total += _productPricing.GetTotalPrice(sku, itemquantity);

                }
                return total;
            }

        }
    }
}
