using System;

namespace MvcPatternDemo.Observers
{
    public class EmailNotifier : IObserver
    {
        public void Update(string data) =>
            Console.WriteLine($"📧 [EmailNotifier] Надсилання звіту на email... Дані: {data}");
    }
}
