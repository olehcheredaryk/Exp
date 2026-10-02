using System;
using System.Collections.Generic;
using System.Text;

namespace MvcPatternDemo.Decorators
{
    public class BasicTransactionProcessor : ITransactionProcessor
    {
        public string Process(double amount) => $"Сума: {amount:F2} UAH";
    }
}
