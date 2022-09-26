using FactoryMethodDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Classes
{
    class ProductBFactory : Factory
    {
        protected override IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}
