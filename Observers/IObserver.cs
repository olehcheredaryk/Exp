using System;
using System.Collections.Generic;
using System.Text;

namespace MvcPatternDemo.Observers
{
    public interface IObserver
    {
        void Update(string data);
    }
}