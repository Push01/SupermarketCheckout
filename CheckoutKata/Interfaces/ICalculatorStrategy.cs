using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutKata.Model;

namespace CheckoutKata.Interfaces
{
    public interface ICalculatorStrategy
    {
        double CalculatePrice(PricingRule pricingRule, int scannedQuantity);
    }
}
