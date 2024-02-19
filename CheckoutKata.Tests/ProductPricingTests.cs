using CheckoutKata.Interfaces;

namespace CheckoutKata.Tests
{
    public class ProductPricingTests
    {
        private IProductPricing _productPricing;

        public ProductPricingTests()
        {
            // Arrange
            SetupProductPricing();
        }

        [Theory]
        [InlineData("E", 1, 0)]
        public void ProductPricing_GetTotalPrice_If_ItemIsNull(string sku, int scannedQuantity, int expected_total)
        {
            // Act                                                               
            var actualTotal = _productPricing.GetTotalPrice(sku, scannedQuantity);

            // Assert
            Assert.Equal(expected_total, actualTotal);
        }


        [Theory]
        [InlineData("A", 1, 10)]
        public void ProductPricing_GetTotalPrice_If_ItemIsNotNull(string sku, int scannedQuantity, int expected_total)
        {
            // Act                                                               
            var actualTotal = _productPricing.GetTotalPrice(sku, scannedQuantity);

            // Assert
            Assert.Equal(expected_total, actualTotal);
        }

        private void SetupProductPricing()
        {
            var pricingRule = CheckoutKataHelper.SetupProductListing();
            var calculatorStrategy = CheckoutKataHelper.SetupCalculatorStrategy();
            _productPricing = new ProductPricing(pricingRule, calculatorStrategy);
        }
    }
}