using SimpleFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryDesignPattern.Classes
{
    class SimpleFactory : ISimpleFactory
    {
        public IProduct CreateProduct(string type = "A")
        {
            if (type == "A")
                return new ConcreteProductA();
            else 
                return new ConcreteProductB();
        }
    }
}
