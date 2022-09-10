using ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Classes
{
    class ConcreteObserverB : IObserver
    {
        public IDataSource DateSource;

        public ConcreteObserverB(IDataSource dateSource)
        {
            DateSource = dateSource;
        }

        public void Update(int? state = null)
        {
            // pull style observation implementation
            Console.WriteLine("Current state is : " + DateSource.GetStateValue());
        }
    }
}
