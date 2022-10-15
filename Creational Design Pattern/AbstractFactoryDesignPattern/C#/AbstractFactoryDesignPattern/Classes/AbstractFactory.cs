using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Classes
{
    abstract class AbstractFactory : IFactory
    {
        public void AssembleProduct()
        {
            IGPU gpu = CreateGpu();
            IMonitor monitor = CreateMonitor();

            gpu.Assemble();
            monitor.Assemble();
        }
        public abstract IGPU CreateGpu();

        public abstract IMonitor CreateMonitor();
    }
}
