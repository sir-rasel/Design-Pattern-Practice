using SimpleFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryDesignPattern.Classes
{
    class Client
    {
        public ISimpleFactory simpleFactory { get; set; }

        public Client()
        {
            simpleFactory = new SimpleFactory();
        }

        public void PlaceOrder(string productType = "A")
        {
            IProduct product = simpleFactory.CreateProduct(productType);
            product.Ready();
        }
    }
}
