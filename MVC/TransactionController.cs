using ConsoleApp4.Strategies;
using MvcPatternDemo.MVC;
using MvcPatternDemo.Observers;

using System;

namespace MvcPatternDemo.MVC
{
    public class TransactionController
    {
        private readonly TransactionModel _model;

        public TransactionController(TransactionModel model)
        {
            _model = model;
        }

        public void Run()
        {
            // Реєструємо підписників
            _model.Attach(new ConsoleLogger());
            _model.Attach(new EmailNotifier());
            _model.Attach(new UIAnalyticsView());

            while (true)
            {
                TransactionConsoleView.DisplayMenu();
                string? choice = Console.ReadLine();

                if (choice == "1")
                {
                    double amount = TransactionConsoleView.PromptAmount();
                    if (amount > 0)
                    {
                        string currentStrat = _model.TaxStrategy.GetType().Name;
                        TransactionConsoleView.DisplayMessage($"Обробка... (Поточна стратегія: {currentStrat})");
                        _model.ExecuteTransaction(amount);
                    }
                }
                else if (choice == "2")
                {
                    int stratChoice = TransactionConsoleView.PromptStrategy();
                    if (stratChoice == 2)
                    {
                        _model.TaxStrategy = new ITSectorTaxStrategy();
                        TransactionConsoleView.DisplayMessage("Стратегію змінено на: IT-сектор (5%)\n");
                    }
                    else
                    {
                        _model.TaxStrategy = new StandardTaxStrategy();
                        TransactionConsoleView.DisplayMessage("Стратегію змінено на: Стандартна (18%)\n");
                    }
                }
                else if (choice == "3")
                {
                    TransactionConsoleView.DisplayMessage("Завершення роботи програми.");
                    break;
                }
                else
                {
                    TransactionConsoleView.DisplayMessage("Некоректний вибір. Спробуйте ще раз.\n");
                }
            }
        }
    }
}
