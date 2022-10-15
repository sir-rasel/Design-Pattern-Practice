using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Classes
{
    class MsiMonitor : IMonitor
    {
        public void Assemble()
        {
            Console.WriteLine("Msi Monitor");
        }
    }
}
