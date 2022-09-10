using ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Classes
{
    abstract class Subject : ISubject
    {
        private IList<IObserver> Observers;
        public Subject()
        {
            Observers = new List<IObserver>();
        }

        public void NotifyObservers(int? state = null)
        {
            foreach (var observer in Observers)
            {
                observer.Update(state);

                // pull style update implementation
                // observer.Update();
            }
        }

        public void Subscribe(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnSubscribe(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}
