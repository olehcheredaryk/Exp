using System;

namespace MvcPatternDemo.Observers
{
    public class UIAnalyticsView : IObserver
    {
        public void Update(string data) =>
            Console.WriteLine($"📊 [UIAnalyticsView] Оновлення графіків аналітики даними: {data}\n");
    }
}
