using SimpleFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryDesignPattern.Classes
{
    class ConcreteProductB : IProduct
    {
        public void Ready()
        {
            Console.WriteLine("Ready Product B");
        }
    }
}
