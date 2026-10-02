using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp4.Strategies
{
    public interface ITaxCalculationStrategy
    {
        double CalculateTax(double amount);
    }
}
