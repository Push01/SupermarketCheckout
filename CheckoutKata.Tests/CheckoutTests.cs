using CheckoutKata.Interfaces;

namespace CheckoutKata.Tests
{
    public class CheckoutTests
    {
        private ICheckout _checkout;
        public CheckoutTests()
        {
            // Arrange
            SetupCheckout();
        }

        [Theory]
        [InlineData("AAAACCBEE", 60)]
        [InlineData("EE", 0)]
        public void Checkout_Total_If_ScanItems_NotExist(string itemStream, int expected_total)
        {
            // Act                                                               
            foreach (var item in itemStream)
            {
                _checkout.Scan(item.ToString());
            }

            // Assert
            Assert.Equal(expected_total, _checkout.Total);
        }

        [Theory]
        [InlineData("AAAACCB", 60)]
        [InlineData("A", 10)]
        [InlineData("AA", 20)]
        [InlineData("AAA", 15)]
        [InlineData("AAAA", 25)]
        [InlineData("B", 5)]
        [InlineData("BB", 10)]
        public void Checkout_Total_If_ScanItems_Exist(string itemStream, int expected_total)
        {
            //Act
            foreach (var item in itemStream)
            {
                _checkout.Scan(item.ToString());
            }

            // Assert
            Assert.Equal(expected_total, _checkout.Total);
        }

        private void SetupCheckout()
        {
            var pricingRule = CheckoutKataHelper.SetupProductListing();
            var calculatorStrategy = CheckoutKataHelper.SetupCalculatorStrategy();
            _checkout = new Checkout(new ProductPricing (pricingRule, calculatorStrategy));
        }

    }
}