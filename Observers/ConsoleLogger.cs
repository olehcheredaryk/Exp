using System;

namespace MvcPatternDemo.Observers
{
    public class ConsoleLogger : IObserver
    {
        public void Update(string data) =>
            Console.WriteLine($"📡 [ConsoleLogger] Отримано новий запис системи: {data}");
    }
}
