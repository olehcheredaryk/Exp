using ConsoleApp4.Strategies;
using MvcPatternDemo.Decorators;
using MvcPatternDemo.Observers;
using System.Collections.Generic;

namespace MvcPatternDemo.MVC
{
    public class TransactionModel
    {
        private string _processedData = string.Empty;
        private readonly List<IObserver> _observers = new();

        public ITaxCalculationStrategy TaxStrategy { get; set; } = new StandardTaxStrategy();

        public void Attach(IObserver observer)
        {
            if (!_observers.Contains(observer)) _observers.Add(observer);
        }

        public void Detach(IObserver observer) => _observers.Remove(observer);

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_processedData);
            }
        }

        public void ExecuteTransaction(double rawAmount)
        {
            double taxAmount = TaxStrategy.CalculateTax(rawAmount);
            double finalAmount = rawAmount - taxAmount;

            // Збирання конвеєра декораторів
            ITransactionProcessor pipeline = new LoggingDecorator(
                new EncryptionDecorator(
                    new BasicTransactionProcessor()
                )
            );

            _processedData = pipeline.Process(finalAmount);
            NotifyObservers();
        }
    }
}
