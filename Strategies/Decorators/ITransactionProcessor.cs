using System;
using System.Collections.Generic;
using System.Text;

namespace MvcPatternDemo.Decorators
{
    public interface ITransactionProcessor
    {
        string Process(double amount);
    }
}
