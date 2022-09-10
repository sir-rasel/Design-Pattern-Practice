using ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Classes
{
    class ConcreteObserverA : IObserver
    {
        public void Update(int? state  = null)
        {
            // push style observation implementation
            Console.WriteLine("Current state is : " + state.Value);
        }
    }
}
