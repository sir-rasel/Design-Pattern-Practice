using FactoryMethodDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Classes
{
    abstract class Factory
    {
        public void OrderProduct()
        {
            IProduct product = CreateProduct();
            product.Ready();
        }

        protected abstract IProduct CreateProduct();
    }
}
