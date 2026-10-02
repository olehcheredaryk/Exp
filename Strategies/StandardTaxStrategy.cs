using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Strategies
{
    public class StandardTaxStrategy : ITaxCalculationStrategy
    {
        // Стандартна ставка податку (18%)
        public double CalculateTax(double amount) => amount * 0.18;
    }
}
