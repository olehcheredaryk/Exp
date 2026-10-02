using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Strategies
{
    public class ITSectorTaxStrategy : ITaxCalculationStrategy
    {
        // Пільгова ставка для IT-сектору (5%)
        public double CalculateTax(double amount) => amount * 0.05;
    }
}