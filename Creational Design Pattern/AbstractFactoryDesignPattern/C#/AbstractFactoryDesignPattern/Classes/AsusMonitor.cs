using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Classes
{
    class AsusMonitor : IMonitor
    {
        public void Assemble()
        {
            Console.WriteLine("Asus Monitor");
        }
    }
}
