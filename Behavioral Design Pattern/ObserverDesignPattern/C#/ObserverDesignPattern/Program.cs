using ObserverDesignPattern.Classes;
using System;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSource DataSource = new DataSource();
            ConcreteObserverA A = new ConcreteObserverA();
            ConcreteObserverB B = new ConcreteObserverB(DataSource);

            DataSource.Subscribe(A);
            DataSource.Subscribe(B);
            DataSource.SetStateValue(5);

            DataSource.UnSubscribe(A);
            DataSource.SetStateValue(10);
        }
    }
}
