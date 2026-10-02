using System;
using System.Collections.Generic;
using System.Text;

namespace MvcPatternDemo.Decorators
{
    public abstract class TransactionDecorator : ITransactionProcessor
    {
        protected readonly ITransactionProcessor _wrappedProcessor;

        protected TransactionDecorator(ITransactionProcessor processor)
        {
            _wrappedProcessor = processor;
        }

        public virtual string Process(double amount) => _wrappedProcessor.Process(amount);
    }
}
