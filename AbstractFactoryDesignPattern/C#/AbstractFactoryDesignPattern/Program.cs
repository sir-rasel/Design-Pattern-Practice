using AbstractFactoryDesignPattern.Classes;
using AbstractFactoryDesignPattern.Interfaces;
using System;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new AsusManufacturer();
            factory.AssembleProduct();

            factory = new MsiManufacturer();
            factory.AssembleProduct();
        }
    }
}
