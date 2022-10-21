using ProxyDesignPattern.Interfaces;
using System;

namespace ProxyDesignPattern.Classes
{
    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
