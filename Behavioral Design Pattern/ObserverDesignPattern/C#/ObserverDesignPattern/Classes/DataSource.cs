using ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Classes
{
    class DataSource : Subject, IDataSource
    {
        public int State { get; set; }

        public void SetStateValue(int state)
        {
            State = state;

            // pull style notify implementation
            // NotifyObservers();

            // push style notify implementation
            NotifyObservers(state);
        }
        public int GetStateValue()
        {
            return State;
        }
    }
}
