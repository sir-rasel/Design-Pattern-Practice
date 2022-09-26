using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryDesignPattern.Interfaces
{
    interface ISimpleFactory
    {
        public IProduct CreateProduct(string type = "A");
    }
}
