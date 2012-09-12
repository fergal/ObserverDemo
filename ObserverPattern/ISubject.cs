using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface ISubject
    {
         void RegisterObserver(IObserver o);
         void RemoveObserver(IObserver o);
         void NotifyObservers();
    }
}
