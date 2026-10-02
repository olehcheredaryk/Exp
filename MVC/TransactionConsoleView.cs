using System;

namespace MvcPatternDemo.MVC
{
    public static class TransactionConsoleView
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ТРАНЗАКЦІЯМИ ===");
            Console.WriteLine("1. Ввести нову транзакцію");
            Console.WriteLine("2. Змінити стратегію оподаткування");
            Console.WriteLine("3. Вихід");
            Console.Write("Оберіть дію: ");
        }

        public static double PromptAmount()
        {
            Console.Write("Введіть суму транзакції (UAH): ");
            if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
            {
                return amount;
            }
            Console.WriteLine("❌ Помилка: Введено некоректне число.");
            return 0.0;
        }

        public static int PromptStrategy()
        {
            Console.WriteLine("\nОберіть стратегію оподаткування:");
            Console.WriteLine("1. Стандартний податок (18%)");
            Console.WriteLine("2. Податок для IT-сектору (5%)");
            Console.Write("Ваш вибір: ");

            int.TryParse(Console.ReadLine(), out int choice);
            return choice;
        }

        public static void DisplayMessage(string message) => Console.WriteLine($"ℹ️ {message}");
    }
}
