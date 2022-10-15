using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Interfaces
{
    interface ISubject
    {
        public void Subscribe(IObserver observer);
        public void UnSubscribe(IObserver observer);
        public void NotifyObservers(int? state);

        // pull style notify implementation
        // public void NotifyObservers();
    }
}
