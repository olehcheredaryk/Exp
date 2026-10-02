using System;

namespace MvcPatternDemo.Decorators
{
    public class LoggingDecorator : TransactionDecorator
    {
        public LoggingDecorator(ITransactionProcessor processor) : base(processor) { }

        // Додає часову мітку
        public override string Process(double amount)
        {
            string originalResult = base.Process(amount);
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return $"[{timestamp}] {originalResult}";
        }
    }
}
