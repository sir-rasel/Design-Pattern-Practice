using FactoryMethodDesignPattern.Classes;
using System;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new ProductAFactory();
            factory.OrderProduct();

            factory = new ProductBFactory();
            factory.OrderProduct();
        }
    }
}
