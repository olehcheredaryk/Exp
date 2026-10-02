using System;
using System.Text;
using MvcPatternDemo.MVC;

namespace MvcPatternDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Налаштування кодування для коректного виведення кирилиці та емодзі
            Console.OutputEncoding = Encoding.UTF8;

            // Створюємо архітектурну тріаду MVC та запускаємо додаток
            TransactionModel model = new TransactionModel();
            TransactionController controller = new TransactionController(model);

            controller.Run();
        }
    }
}
