using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Interfaces
{
    interface IObserver
    {
        // pull style observation implementation
        // public void Update();

        // push style observation implementation
        public void Update(int? state);
    }
}
